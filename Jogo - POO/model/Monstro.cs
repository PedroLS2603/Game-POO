using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo___POO
{
    class Monstro
    {
        private int level;
        private Status status;
        private Random random = new Random();

        public int getLevel()
        {
            return this.level;
        }

        public Status getStatus()
        {
            return this.status;
        }

        public void setLevel(int level)
        {
            this.level = level;
        }

        public void setStatus(Status status)
        {
            this.status = status;
        }

        public void RecebeDano(double forcaInimigo)
        {
            double vida = this.getStatus().getVidaAtual();
            double defesa = this.getStatus().getDefesa();
            this.getStatus().setVidaAtual(vida - this.defender());
        }

        private double defender()
        {
            double defesa = this.getStatus().getDefesa();
            double sorte = this.getStatus().getSorte();
            double agilidade = this.getStatus().getAgilidade();

            return (defesa + agilidade) * (1 + random.Next(0, (int)sorte) / 100);
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
