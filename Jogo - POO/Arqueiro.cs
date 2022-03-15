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
            monstro.RecebeDano(this.gerarDano());
        }

        private double gerarDano()
        {
            double forca = this.getStatus().getForca();
            double sorte = this.getStatus().getSorte();
            double agilidade = this.getStatus().getAgilidade();

            this.flechas -= 1;
            double danoBase = forca + (agilidade * 0.2);

            if(random.Next(0, 100) <= (int)sorte)
            {
                danoBase *= 1.5; 
            }

            return danoBase;
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
