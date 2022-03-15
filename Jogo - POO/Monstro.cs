using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo___POO
{
    class Monstro
    {
        private string nome;
        private int level;
        private Status status = new Status();
        private Random random = new Random();


        public Monstro(string nome, int level)
        {   
            this.status.setVidaMax(this.status.getVidaMax() * 1.1);
            this.status.setVidaAtual(this.status.getVidaMax());
            this.status.setForca(this.status.getForca() * 1.25);
            this.status.setAgilidade(this.status.getAgilidade() * 1.1);
            this.status.setSorte(this.status.getSorte() * 1.05);
            this.status.setDefesa(this.status.getDefesa() * 2);


            this.level = level;
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }
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

        public void RecebeDano(double ataqueHeroi, double forcaHeroi)
        {
            double vida = this.getStatus().getVidaAtual();
            double defesa = this.gerarDefesa();

            double danoTomado = ataqueHeroi * (1 - (defesa / (defesa + 100)));

            this.getStatus().setVidaAtual(vida - danoTomado);
           


        }

        private double gerarDefesa()
        {
            double defesa = this.getStatus().getDefesa();
            double sorte = this.getStatus().getSorte();
            double agilidade = this.getStatus().getAgilidade();

            return (defesa + agilidade) * (1 + random.Next(0, (int)sorte));
        }


        public void atacar(Heroi heroi)
        {
            heroi.RecebeDano(this.gerarAtaque(), this.getStatus().getForca());
        }

        private double gerarAtaque()
        {
            double forca = this.getStatus().getForca();
            double sorte = this.getStatus().getSorte();
            double agilidade = this.getStatus().getAgilidade();

            return (forca + agilidade) * (1 + random.Next(0, (int)sorte) / 20);
        }
    }
}
