using System;

namespace Bowling
{
    public class Placar
    {
        public int Pontuacao { get; set; }
        public bool EhSpare { get; private set; }

        public Placar() { }

        public void Pontuar(int primeiraTentativa, int segundaTentativa)
        {
            var totalQuadro = primeiraTentativa + segundaTentativa;
            if (EhSpare)
            {
                Pontuacao += primeiraTentativa;
                return;
            }

            Pontuacao += totalQuadro;
            TipoJogada(primeiraTentativa, segundaTentativa);
        }

        private void TipoJogada(int primeiraTentativa, int segundaTentativa)
        {
            var totalQuadro = primeiraTentativa + segundaTentativa;
            EhSpare = (primeiraTentativa != 10 && totalQuadro == 10);
        }
    }
}