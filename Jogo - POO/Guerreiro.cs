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

        public Guerreiro() : base("", 0)
        {
            
        }

        public Guerreiro(String nome, int idade) : base(nome, idade)
        {
            this.getStatus().setForca(9);
            double buffVida = this.getStatus().getVidaMax() * 1.1;
            this.getStatus().setVidaMax(buffVida);
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

            return (forca + agilidade) * (1 + random.Next(0, (int)sorte) / 100);
        }
    }
}
