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
            Arqueiro heroiA = new Arqueiro();
            Mago heroiM = new Mago();
            Guerreiro heroiG = new Guerreiro();
            Heroi heroi = new Heroi();

            //Config personagem -> index 0 - nome, 1 - idade, 2 - classe
            configPersonagem = RpgUtil.CriarPersonagem();

            switch(configPersonagem[2])
            {
                //Arqueiro
                case "1":
                    heroi = new Arqueiro(configPersonagem[0], Int32.Parse(configPersonagem[1]));
                    break;
                //Mago
                case "2":
                    heroi = new Mago(configPersonagem[0], Int32.Parse(configPersonagem[1]));
                    break;
                //Guerreiro
                case "3":
                    heroi = new Guerreiro(configPersonagem[0], Int32.Parse(configPersonagem[1]));
                    break; 
            }

            RpgUtil.printStatus(heroi);

            Aranha monstro1 = new Aranha("Aranha", 1);

            RpgUtil.criarBatalha(monstro1, heroi);


            Console.ReadLine();
;        }
    }
}
