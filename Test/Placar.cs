using System;

namespace Bowling
{
    public class Placar
    {
        public int Pontuacao { get; set; }
        public bool Strike { get; private set; }
        public bool Spare { get; private set; }

        public Placar()
        {
        }

        public void Pontuar(int primeiraTentativa, int segundaTentiva)
        {
            var valorJogada = primeiraTentativa + segundaTentiva;
            if (Spare || Strike)
                Pontuacao += primeiraTentativa;
            else
                Pontuacao += valorJogada;

            Strike = primeiraTentativa == 10;
            Spare = valorJogada == 10;
        }
    }

}