using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo___POO
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] configPersonagem;
            Heroi heroi = new Heroi();
            Arma arma;

            //Config personagem -> index 0 - nome, 1 - idade, 2 - classe
            configPersonagem = RpgUtil.CriarPersonagem();

            switch(configPersonagem[2])
            {
                //Arqueiro
                case "1":
                    heroi = new Arqueiro(configPersonagem[0], Int32.Parse(configPersonagem[1]));
                    arma = new Arma("Arco longo", true, 100, 10);

                    heroi.equiparArma(arma);
                    break;
                //Mago
                case "2":
                    heroi = new Mago(configPersonagem[0], Int32.Parse(configPersonagem[1]));
                    arma = new Arma("Cajado de madeira", false, 100, 15);


                    heroi.equiparArma(arma);
                    break;
                //Guerreiro
                case "3":
                    heroi = new Guerreiro(configPersonagem[0], Int32.Parse(configPersonagem[1]));
                    arma = new Arma("Espada longa", false, 100, 15);
                    Arma escudo = new Arma("Escudo de madeira", false, 100, 50);

                    heroi.equiparArma(arma);
                    heroi.equiparArma(escudo);

                    break; 
            }

            RpgUtil.printStatus(heroi);

            Aranha monstro1 = new Aranha("Aranha", 1);
            RpgUtil.printStatusM(monstro1);

            RpgUtil.criarBatalha(monstro1, heroi);


            Console.ReadLine();
;        }
    }
}
