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
            double buffVida = this.getStatus().getVidaMax() * 1.1;
            this.getStatus().setVidaMax(buffVida);
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
            Arma[] equipMao = this.getMao();
            Arma maoDireita = equipMao[0];
            Arma maoEsquerda = equipMao[0];



            if(maoDireita.getClasse() != "" || maoEsquerda.getClasse() != "")
            {
                double danoBase = (forca + (maoDireita.getPeso() * 0.25)) + (agilidade * 0.2);

                if (random.Next(0, 100) <= (int)sorte)
                {
                    danoBase *= 1.5;
                }

                return danoBase;

            }

            else
            {
                double danoBase = forca + (agilidade * 0.2);

                if (random.Next(0, 100) <= (int)sorte)
                {
                    danoBase *= 1.5;
                }

                return danoBase;
            }
        }
    }
}
