using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo___POO
{
    class Status
    {
        private double forca;
        private double defesa;
        private double agilidade;
        private double manaAtual;
        private double manaMax;
        private double sorte;
        private double vidaMax;
        private double vidaAtual;
        private double inteligencia;
        private Random random = new Random();


        public Status()
        {
            this.forca = RpgUtil.gerarStatus(1, 10);
            this.defesa = RpgUtil.gerarStatus(1, 10);
            this.agilidade = RpgUtil.gerarStatus(1, 10);
            this.sorte = RpgUtil.gerarStatus(1, 10);

            this.inteligencia = RpgUtil.gerarStatus(1, 10);

            this.vidaMax = RpgUtil.gerarStatus(25, 50);

            this.manaMax = RpgUtil.gerarStatus(25, 50);
            this.vidaAtual = this.vidaMax;
            this.manaAtual = this.manaMax;


        }
        public double getForca()
        {
            return this.forca;
        }

        public double getInteligencia()
        {
            return this.inteligencia;
        }

        public double getDefesa()
        {
            return this.defesa;
        }

        public double getAgilidade()
        {
            return this.agilidade;
        }

        public double getManaAtual()
        {
            return this.manaAtual;
        }

        public double getSorte()
        {
            return this.sorte;
        }

        public double getVidaMax()
        {
            return this.vidaMax;
        }

        public void setForca(double forca)
        {
            this.forca = forca;
        }

        public void setDefesa(double defesa)
        {
            this.defesa = defesa;
        }

        public void setManaAtual(double mana)
        {
            this.manaAtual = mana;
        }
        public void setManaMax(double mana)
        {
            this.manaMax = mana;
        }
        public double getManaMax()
        {
            return this.manaMax;
        }
        public void setVidaMax(double vida)
        {
            this.vidaMax = vida;
        }

        public void setSorte(double sorte)
        {
            this.sorte= sorte;
        }

        public void setAgilidade(double agilidade)
        {
            this.agilidade = agilidade;
        }

        public void setInteligencia(double inteligencia)
        {
            this.inteligencia = inteligencia;
        }

        public void setVidaAtual(double vida)
        {
            this.vidaAtual = vida;
        }

        public double getVidaAtual()
        {
            return this.vidaAtual;
        }

        public void resetStatus()
        {
            this.agilidade = 0;
            this.forca = 0;
            this.defesa = 0;
            this.inteligencia = 0;
            this.manaMax = 0;
            this.manaAtual = 0;
            this.vidaAtual = 0;
            this.vidaMax = 0;
            this.inteligencia = 0;
        }
    }
}
