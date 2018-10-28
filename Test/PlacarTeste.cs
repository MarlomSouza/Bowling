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
            Assert.Equal(34, placar.Pontuacao);
        }

        // [Fact]
        // public void Nao_deve_calcular_ponto_em_um_spare_sem_a_proxima_jogada()
        // {
        //     //Given
        //     Placar placar = new Placar();
        //     //When
        //     placar.Pontuar(1, 4);
        //     placar.Pontuar(4, 5);
        //     placar.Pontuar(6, 4);
        //     //Then
        //     Assert.Equal(14, placar.Pontuacao);
        // }

        [Fact]
        public void Deve_calcular_dois_spare()
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
            Assert.Equal(41, placar.Pontuacao);
        }


        [Fact]
        public void Deve_informar_um_strike()
        {
            //Given
            Placar placar = new Placar();
            //When
            placar.Pontuar(10, 0);

            //Then
            Assert.True(placar.EhStrike);
        }

        [Fact]
        public void Nao_deve_informar_um_strike()
        {
            //Given
            Placar placar = new Placar();
            //When
            placar.Pontuar(1, 4);

            //Then
            Assert.False(placar.EhStrike);
        }

        [Fact]
        public void Deve_informar_strike_e_nao_spare()
        {
            //Given
            Placar placar = new Placar();
            //When
            placar.Pontuar(10, 0);

            //Then
            Assert.True(placar.EhStrike);
            Assert.False(placar.EhSpare);
        }
        [Fact]
        public void Deve_informar_spare_e_nao_strike()
        {
            //Given
            Placar placar = new Placar();
            //When
            placar.Pontuar(0, 10);
            //Then
            Assert.False(placar.EhStrike);
            Assert.True(placar.EhSpare);
        }

        [Fact]
        public void Nao_deve_calcular_jogada_com_mais_de_dez_pinos()
        {
            //Given
            Placar placar = new Placar();
            //When
            Action testCode = () => placar.Pontuar(6, 5);
            //Then
            var erro = Assert.Throws<ArgumentException>(testCode);
            Assert.Equal("Jogada inválida", erro.Message);
        }

        [Fact]
        public void Deve_calcular_um_spare_e_um_strike()
        {
            //Given
            Placar placar = new Placar();
            //When
            placar.Pontuar(1, 4);
            placar.Pontuar(4, 5);
            placar.Pontuar(6, 4);
            placar.Pontuar(5, 5);
            placar.Pontuar(10, 0);
            placar.Pontuar(0, 1);
            //Then
            Assert.Equal(61, placar.Pontuacao);
        }

        [Fact]
        public void Deve_calcular_o_valor_de_um_strike()
        {
            //Given
            Placar placar = new Placar();
            //When
            placar.Pontuar(10, 0);
            placar.Pontuar(5, 3);
            //Then
            Assert.Equal(26, placar.Pontuacao);
        }

        [Fact]
        public void Deve_calcular_um_jogo_completo()
        {
            //Given
            Placar placar = new Placar();
            //When
            placar.Pontuar(1, 4);
            placar.Pontuar(4, 5);
            placar.Pontuar(6, 4);
            placar.Pontuar(5, 5);
            placar.Pontuar(10, 0);
            placar.Pontuar(0, 1);
            placar.Pontuar(7, 3);
            placar.Pontuar(6, 4);
            placar.Pontuar(10, 0);
            placar.Pontuar(2, 8);
            placar.Pontuar(6, 0);
            //Then
            Assert.Equal(133, placar.Pontuacao);
        }

    }
}
