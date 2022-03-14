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

        public Arqueiro() : base ("", 0)
        {

        }

        public Arqueiro(String nome, int idade) : base (nome, idade)
        {
            
        }

        public override void atacar(Monstro monstro)
        {
            monstro.RecebeDano(this.gerarDano(), this.getStatus().getForca());
        }

        private double gerarDano()
        {
            double forca = this.getStatus().getForca();
            double sorte = this.getStatus().getSorte();
            double agilidade = this.getStatus().getAgilidade();

            this.flechas -= 1;

            return (forca + agilidade) * (1 + random.Next(0, (int)sorte));
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
