using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo___POO
{
    class Mago : Heroi 
    {
        private Random random = new Random();


        public Mago() : base("", 0)
        {

        }

        public Mago(String nome, int idade) : base(nome, idade)
        {
        }

        public override void atacar(Monstro monstro)
        {
            monstro.RecebeDano(this.gerarDano(), this.getStatus().getInteligencia());
        }

        private double gerarDano()
        {
            double inteligencia = this.getStatus().getInteligencia();
            double sorte = this.getStatus().getSorte();
            double agilidade = this.getStatus().getAgilidade();
            double mana = this.getStatus().getManaAtual();

            this.getStatus().setManaAtual(mana * 0.15);

            return (inteligencia + agilidade) * (1 + random.Next(0, (int)sorte));
        }

        public void curar()
        {
            double vidaAtual = this.getStatus().getVidaAtual();
            double vidaMax = this.getStatus().getVidaMax();
            double inteligencia = this.getStatus().getInteligencia();
            double sorte = this.getStatus().getSorte();
            double mana = this.getStatus().getManaAtual();

            double novaVida = vidaAtual + inteligencia * random.Next(0, (int) sorte);

            if(novaVida > vidaMax)
            {
                this.getStatus().setVidaAtual(vidaMax);
            }
            else
            {
                this.getStatus().setVidaAtual(novaVida);
            }

            this.getStatus().setManaAtual(mana * 0.15);

        }
    }
}
