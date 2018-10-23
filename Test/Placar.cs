using System;

namespace Bowling
{
    public class Placar
    {
        public int Pontuacao { get; set; }
        public bool Spare { get; private set; }

        public Placar()
        {
        }

        public void Pontuar(int primeiraTentativa, int segundaTentiva)
        {
            if (Spare)
                Pontuacao += primeiraTentativa;

            var valorJogada = primeiraTentativa + segundaTentiva;
            Spare = valorJogada == 10;
            Pontuacao += valorJogada;
        }
    }

}