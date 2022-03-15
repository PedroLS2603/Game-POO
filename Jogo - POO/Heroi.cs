using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo___POO
{
    class Heroi
    {
        private string nome;
        private int idade;
        private int level;
        private double xp;
        private Status status;
        private Random random = new Random();
        private Equipamento[] equipamentos;
        private Arma[] maos;


        public Heroi()
        {

        }
        public Heroi(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
            this.level = 1;
            this.status = new Status();
            this.equipamentos = new Equipamento[4];
            this.maos = new Arma[2];

            this.maos[0] = new Arma("", false, 0, 0);
            this.maos[1] = new Arma("", false, 0, 0);

        }
        public Arma[] getMao()
        {
            return this.maos;
        }

        public string getNome()
        {
            return this.nome;
        }

        public int getIdade()
        {
            return this.idade;
        }

        public int getLevel ()
        {
            return this.level;
        }

        public Status getStatus()
        {
            return this.status;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }

        public void setLevel(int level)
        {
            this.level = level;
        }

        public void setStatus(Status status)
        {
            this.status = status;
        }
        private double gerarDefesa()
        {
            double defesa = this.getStatus().getDefesa();
            double sorte = this.getStatus().getSorte();
            double agilidade = this.getStatus().getAgilidade();


            return (defesa + agilidade) * (1 + random.Next(0, (int)sorte) / 100);
        }

        public virtual void atacar(Monstro monstro)
        {

        }
        public void RecebeDano(double ataqueMonstro, double forcaMonstro)
        {
            double vida = this.getStatus().getVidaAtual();
            double defesa = this.gerarDefesa();
            double danoTomado = ataqueMonstro * (1 - (defesa / (defesa + 100)));
            this.getStatus().setVidaAtual(vida - danoTomado);
        }
        public void equipar(Equipamento equip)
        {
            
        }

        public void equiparArma(Arma arma)
        {
            Arma maoDireita = this.maos[0];
            Arma maoEsquerda = this.maos[1];

            if(maoDireita.getClasse()!= "")
            {
                this.maos[1] = arma;
            }
            else
            {
                this.maos[0] = arma;
            }

            this.status.setAgilidade(this.status.getAgilidade() - (arma.getStatus().getAgilidade() * 0.02));
            this.status.setForca(this.status.getForca() + arma.getStatus().getForca());
            this.status.setSorte(this.status.getSorte() + arma.getStatus().getSorte());
            this.status.setInteligencia(this.status.getInteligencia() + arma.getStatus().getInteligencia());

        }

        public void desequipar(Equipamento equip)
        {

        }

    }
}
