using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo___POO
{
    class Arqueiro : Heroi
    {
        private Random random = new Random();
        private int flechas;
        private double atacar()
        {
            double forca = this.getStatus().getForca();
            double sorte = this.getStatus().getSorte();
            double agilidade = this.getStatus().getAgilidade();

            this.flechas -= 1;

            return (forca + agilidade) * (1 + random.Next(0, (int)sorte) / 100);
        }

        public void setFlechas(int flechas)
        {
            this.flechas = flechas;
        }

        public int getFlechas()
        {
            return this.flechas;
        }
    }
}
