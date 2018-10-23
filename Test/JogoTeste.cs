using System;
using Xunit;

namespace Bowling
{
    public class JogoTeste
    {
        public JogoTeste()
        {
        }

        [Fact]
        public void Cada_jogo_deve_possuir_dez_jogadas()
        {
            Jogo jogo = new Jogo();

            Assert.Equal(10, jogo.Jogadas);
        }
    }
}
