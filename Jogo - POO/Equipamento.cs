using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo___POO
{
    class Equipamento

    
    {
        private int durabilidade;
        private Status status;
        private double peso;

        public Equipamento(int durabilidade, double peso) {
            this.durabilidade = durabilidade;
            this.peso = peso;
            this.status = new Status();
        }

        public Status getStatus()
        {
            return this.status;
        }

        public int getDurabilidade()
        {
            return this.durabilidade;
        } 

        public double getPeso()
        {
            return this.peso;
        }
    }
}
