using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo___POO
{
    class Guerreiro : Heroi 
    {
        private Random random = new Random();

        public Guerreiro()
        {
            double buffVida = this.getStatus().getVidaMax() * 1.1;
            this.getStatus().setVidaMax(buffVida);
        }
        private double atacar()
        {
            double forca = this.getStatus().getForca();
            double sorte = this.getStatus().getSorte();
            double agilidade = this.getStatus().getAgilidade();

            return (forca + agilidade) * (1 + random.Next(0, (int)sorte) / 100);
        }
    }
}
