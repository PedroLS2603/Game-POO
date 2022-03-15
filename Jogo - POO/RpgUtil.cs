using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Jogo___POO
{
    internal class RpgUtil
    {
        private static Random random = new Random();
        public static string[] CriarPersonagem()
        {
            string[] retorno = new string[3];
            RpgUtil util = new RpgUtil();

            Console.WriteLine("-----------CRIE SEU PERSONAGEM---------------");
            Console.Write("Qual seu nome? ");
            Thread.Sleep(500);
            retorno[0] = Console.ReadLine();
            Thread.Sleep(500);

            Console.Write("Qual sua idade? ");
            Thread.Sleep(500);
            retorno[1] = Console.ReadLine();
            Thread.Sleep(500);
            Console.WriteLine("---------------------------------------------");

            Console.Clear();

            do
            {
                util.printMenuClasse();
                retorno[2] = Console.ReadLine();
            } while (retorno[2] != "1" && retorno[2] != "2" && retorno[2] != "3");

            return retorno;
        }

        private void printMenuClasse()
        {
            Console.WriteLine("-----------ESCOLHA UMA CLASSE-------------");
            Thread.Sleep(500);

            Console.WriteLine("|                                        |");
            Thread.Sleep(500);

            Console.WriteLine("|    1 - Arqueiro                        |");
            Thread.Sleep(500);

            Console.WriteLine("|                                        |");
            Thread.Sleep(500);

            Console.WriteLine("|    2 - Mago                            |");
            Thread.Sleep(500);

            Console.WriteLine("|                                        |");
            Thread.Sleep(500);

            Console.WriteLine("|    3 - Guerreiro                       |");
            Thread.Sleep(500);

            Console.WriteLine("|                                        |");
            Thread.Sleep(500);

            Console.WriteLine("------------------------------------------");
            Thread.Sleep(500);

            Console.WriteLine("Sua escolha: ");
            Thread.Sleep(500);
        }



        public static void criarBatalha(Monstro monstro, Heroi heroi)
        {
            bool turnoHeroi = true;
            while(monstro.getStatus().getVidaAtual() > 0 && heroi.getStatus().getVidaAtual() > 0)
            {
                if(turnoHeroi)
                {
                    heroi.atacar(monstro);
                    if(monstro.getStatus().getVidaAtual() >= 0)
                    {
                        Console.WriteLine("Vida do(a) {0} após ataque - {1:N0}", monstro.getNome(), monstro.getStatus().getVidaAtual());
                    }
                    else
                    {
                        Console.WriteLine("Vida do(a) {0} após ataque - 0", monstro.getNome());
                    }

                    turnoHeroi = false;
                    
                }
                else
                {
                    monstro.atacar(heroi);
                    if(heroi.getStatus().getVidaAtual() >= 0) {
                        Console.WriteLine("Vida do herói {0} após ataque - {1:N0}", heroi.getNome(), heroi.getStatus().getVidaAtual());
                    }
                    else
                    {
                        Console.WriteLine("Vida do herói {0} após ataque - 0", heroi.getNome());
                    }
                    
                    turnoHeroi = true;
                }
                Thread.Sleep(1000);
            }

            if (heroi.getStatus().getVidaAtual() < 0)
            {
                Console.WriteLine("{0} morreu", heroi.getNome());
            }

            else
            {
                Console.WriteLine("{0} morreu", monstro.getNome());
            }
        }

        public static double gerarStatus(int min, int max)
        {
            int randNum = random.Next(min, max);

            return Convert.ToDouble(randNum);
        } 

        public static void printStatus(Heroi heroi)
        {
            Status statusHeroi = heroi.getStatus();

            Console.WriteLine("------------ {0} ------------", heroi.getNome());
            Console.WriteLine("Força: {0:N0}", statusHeroi.getForca());
            Console.WriteLine("Agilidade: {0:N0}", statusHeroi.getAgilidade());
            Console.WriteLine("Inteligência: {0:N0}", statusHeroi.getInteligencia());
            Console.WriteLine("Sorte: {0:N0}", statusHeroi.getSorte());
            Console.WriteLine("Defesa: {0:N0}", statusHeroi.getDefesa());
            Console.WriteLine("Vida: {0:N0}", statusHeroi.getVidaMax());
            Console.WriteLine("Mana: {0:N0}", statusHeroi.getManaMax());


        }

        public static void printStatusM(Monstro monstro)
        {
            Status statusMonstro = monstro.getStatus();

            Console.WriteLine("------------ {0} ------------", monstro.getNome());
            Console.WriteLine("Força: {0:N0}", statusMonstro.getForca());
            Console.WriteLine("Agilidade: {0:N0}", statusMonstro.getAgilidade());
            Console.WriteLine("Inteligência: {0:N0}", statusMonstro.getInteligencia());
            Console.WriteLine("Sorte: {0:N0}", statusMonstro.getSorte());
            Console.WriteLine("Defesa: {0:N0}", statusMonstro.getDefesa());
            Console.WriteLine("Vida: {0:N0}", statusMonstro.getVidaMax());
            Console.WriteLine("Mana: {0:N0}", statusMonstro.getManaMax());


        }
    }
}
