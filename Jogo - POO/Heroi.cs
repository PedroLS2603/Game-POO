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


        public Heroi()
        {

        }
        public Heroi(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
            this.level = 1;
            this.status = new Status();
            this.equipamentos = new Equipamento[6];
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
        private double defender()
        {
            double defesa = this.getStatus().getDefesa();
            double sorte = this.getStatus().getSorte();
            double agilidade = this.getStatus().getAgilidade();

            return (defesa + agilidade) * (1 + random.Next(0, (int)sorte) / 100);
        }

        public virtual void atacar(Monstro monstro)
        {

        }
        public void RecebeDano(double forcaInimigo)
        {
            double vida = this.getStatus().getVidaAtual();
            double defesa = this.getStatus().getDefesa();
            this.getStatus().setVidaAtual(vida - this.defender());
        }
        public void equipar(Equipamento equip)
        {
          
        }

        public void equiparArma(Arma arma)
        {

        }

        public void desequipar(Equipamento equip)
        {

        }

    }
}
