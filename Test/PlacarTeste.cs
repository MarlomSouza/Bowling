using Xunit;
using System;

namespace Bowling
{
    public partial class PlacarTeste
    {
        [Fact]
        public void Deve_inicializar_o_placar_zerado()
        {
            Placar placar = new Placar();

            Assert.Equal(0, placar.Pontuacao);
        }

        [Fact]
        public void Deve_pontuar()
        {
            //Given
            Placar placar = new Placar();
            //When
            placar.Pontuar(1, 0);
            //Then
            Assert.Equal(1, placar.Pontuacao);
        }

        [Fact]
        public void Deve_calcular_a_pontuacao_de_quadro_completo()
        {
            //Given
            Placar placar = new Placar();
            //When
            placar.Pontuar(1, 4);
            //Then
            Assert.Equal(5, placar.Pontuacao);
        }

        [Fact]
        public void Deve_obter_pontuacao_completa_do_quadro()
        {
            //Given
            Placar placar = new Placar();
            //When
            placar.Pontuar(1, 4);
            placar.Pontuar(4, 5);
            //Then
            Assert.Equal(14, placar.Pontuacao);
        }
        [Fact]
        public void Deve_identificar_um_spare()
        {
            //Given
            Placar placar = new Placar();
            //When
            placar.Pontuar(6, 4);
            //Then
            Assert.True(placar.EhSpare);
        }

        [Fact]
        public void Nao_deve_considerar_um_spare()
        {
            //Given
            Placar placar = new Placar();
            //When
            placar.Pontuar(10, 0);
            //Then
            Assert.False(placar.EhSpare);
        }

        [Fact]
        public void Deve_calcular_um_spare()
        {
            //Given
            Placar placar = new Placar();
            //When
            placar.Pontuar(1, 4);
            placar.Pontuar(4, 5);
            placar.Pontuar(6, 4);
            placar.Pontuar(5, 0);
            //Then
            Assert.Equal(29, placar.Pontuacao);
        }

        [Fact]
        public void Nao_deve_calcular_ponto_em_um_spare_sem_a_proxima_jogada()
        {
            //Given
            Placar placar = new Placar();
            //When
            placar.Pontuar(1, 4);
            placar.Pontuar(4, 5);
            placar.Pontuar(6, 4);
            //Then
            Assert.Equal(24, placar.Pontuacao);
        }

        [Fact]
        public void Deve_calcular_duas_spare()
        {
            //Given
            Placar placar = new Placar();
            //When
            placar.Pontuar(1, 4);
            placar.Pontuar(4, 5);
            placar.Pontuar(6, 4);
            placar.Pontuar(5, 5);
            placar.Pontuar(1, 0);
            //Then
            Assert.Equal(40, placar.Pontuacao);
        }
    }
}
