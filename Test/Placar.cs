using System;

namespace Bowling
{
    public class Placar
    {
        public int Pontuacao { get; set; }
        public bool EhSpare { get; private set; }
        public int Spare { get; private set; }
        public bool EhStrike { get; private set; }
        public int Strike { get; private set; }

        public Placar() { }

        public void Pontuar(int primeiraTentativa, int segundaTentativa)
        {
            ValidarJogada(primeiraTentativa, segundaTentativa);
            var totalQuadro = primeiraTentativa + segundaTentativa;
            Pontuacao += totalQuadro;

            if (EhStrike)
                totalQuadro *= 2;
            else if (EhSpare)
                totalQuadro += primeiraTentativa;


            TipoJogada(primeiraTentativa, segundaTentativa);
        }

        private void ValidarJogada(int primeiraTentativa, int segundaTentativa)
        {
            if (primeiraTentativa + segundaTentativa > 10)
                throw new ArgumentException("Jogada inválida");
        }

        private void TipoJogada(int primeiraTentativa, int segundaTentativa)
        {
            var totalQuadro = primeiraTentativa + segundaTentativa;
            EhStrike = primeiraTentativa == 10 && segundaTentativa == 0;
            EhSpare = (primeiraTentativa != 10 && totalQuadro == 10);
        }
    }
}