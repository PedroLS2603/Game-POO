using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo___POO
{
    class Arma: Equipamento
    {
        bool duasMaos;
        string classe;

        public Arma(string classe, bool duasMaos, int durabilidade, double peso) : base(durabilidade, peso)
        {
            this.classe = classe;
            this.duasMaos = duasMaos;
            Status status = this.getStatus();

            this.getStatus().setForca(status.getForca()/5);
            this.getStatus().setAgilidade(status.getAgilidade()/5);
            this.getStatus().setInteligencia(status.getInteligencia()/5);
            this.getStatus().setSorte(status.getSorte()/5);



            if(this.classe == "")
            {
                this.getStatus().resetStatus(); 
            }
        }

        public string getClasse()
        {
            return this.classe;
        }

        public bool getDuasMaos()
        {
            return this.duasMaos;
        }

        public void setClasse(string classe)
        {
            this.classe = classe;
        }

        public void setDuasMaos(bool duasMaos)
        {
            this.duasMaos = duasMaos;
        }
    }
}
