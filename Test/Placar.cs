using System;

namespace Bowling
{
    public class Placar
    {
        public int Pontuacao { get; set; }
        public bool EhSpare { get; private set; }
        public int Spare { get; private set; }
        public bool EhStrike { get; private set; }

        public Placar() { }

        public void Pontuar(int primeiraTentativa, int segundaTentativa)
        {
            ValidarJogada(primeiraTentativa, segundaTentativa);
            TipoJogada(primeiraTentativa, segundaTentativa);
            var totalQuadro = primeiraTentativa + segundaTentativa;

            if (EhSpare)
            {
                if (Spare != 0)
                    Spare += primeiraTentativa;

                Spare += 10;
                return;
            }
            Pontuacao += Spare + totalQuadro;
            Spare = 0;
        }

        private void ValidarJogada(int primeiraTentativa, int segundaTentativa)
        {
            if (primeiraTentativa + segundaTentativa > 10)
                throw new ArgumentException("Jogada inválida");
        }

        private void TipoJogada(int primeiraTentativa, int segundaTentativa)
        {
            var totalQuadro = primeiraTentativa + segundaTentativa;
            EhStrike = primeiraTentativa == 10;
            EhSpare = (primeiraTentativa != 10 && totalQuadro == 10);
        }
    }
}