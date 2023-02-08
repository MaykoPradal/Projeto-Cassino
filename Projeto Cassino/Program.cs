using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cassino
{
    internal class Program
    {   
        static Random rnd = new Random();
        static string nome = " ";
        static double saldo = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            int op = 1;
            while (op !=0) 
            {
                Console.Clear();
                Console.WriteLine("Bem-vindo " + nome + ", Este aplicativo se trata de um cassino virtual com três jogos");
                Console.WriteLine("Saldo atual: R$"+ saldo);
                Console.WriteLine("Selecione uma das opções abaixo.");
                Console.WriteLine("1 - Loteria");
                Console.WriteLine("2 - Raspadinha");
                Console.WriteLine("3 - Saques/Depósitos");
                Console.WriteLine("0 - Sair");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        break;
                    case 1:
                        Loteria();
                        break;
                    case 2:
                        Raspadinha();
                        break;
                    case 3:
                        Banca();
                        break;
                    default:
                        Console.WriteLine("Opção Invalida");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void Banca()
        {
            int op = 1;
            while (op != 0) 
            {
                Console.Clear();
                Console.WriteLine("Bem-vindo ao menu de Saques/Depósitos");
                Console.WriteLine("Seu saldo é: R$" + saldo);
                Console.WriteLine("1 - Saques");
                Console.WriteLine("2 - Depósitos");
                Console.WriteLine("0 - Voltar ao menu anterior");
                op = int.Parse (Console.ReadLine());

                switch (op) 
                {
                    case 0:
                        break;

                    case 1:
                        Saques(); 
                        break;

                    case 2: Depósitos(); 
                        break;

                    default:
                        Console.WriteLine("Opção Invalida");
                        Console.ReadKey();
                        break;
                }

            }
        }

        private static void Depósitos()
        {
            Console.Clear();

            Console.WriteLine("Qual o valor que deseja depositar? ");
            int valor = int.Parse (Console.ReadLine());

            saldo += valor;

            Console.WriteLine("Deposito realizado com sucesso, novo saldo: R$" + saldo);
            Console.ReadKey();
        }

        private static void Saques()
        {
            Console.Clear();

            Console.WriteLine("Qual o valor que deseja sacar? ");
            int valor = int.Parse(Console.ReadLine());

            if (saldo - valor < 0 )
            {
                Console.WriteLine("Valor de Saque indisponivel");
            }
            else 
            { 
            saldo -= valor;

            Console.WriteLine("Saque realizado com sucesso, novo saldo: R$" + saldo);
            }
            Console.ReadKey();
        }

        private static void Raspadinha()
        {
            int op = 1;
            while (op != 0) 
            {
                Console.Clear();
                Console.WriteLine("Menu Raspadinhas");
                Console.WriteLine("Saldo atual: R$" + saldo);
                Console.WriteLine("1 - Raspadinha A");
                Console.WriteLine("2 - Raspadinha B");
                Console.WriteLine("0 - Voltar ao menu");
                op = int.Parse(Console.ReadLine());

                if (op == 0)
                    break;
                else if (op == 1)
                    RaspadinhaA();
                else if (op == 2)
                    RaspadinhaB();
                else 
                {
                    Console.WriteLine("Opção Invalida");
                    Console.ReadKey();
                } 
                    
               

            }
        }

        private static void RaspadinhaB()
        {
            Console.Clear();
            if (saldo - 2 < 0)
            {
                Console.WriteLine("Saldo insuficiente, realize um depósito antes de jogar");
                Console.ReadKey();
                return;
            }

            saldo -= 2;

            int nprincipal = rnd.Next(1, 10);
            int premio = rnd.Next(1, 100);

            int n1 = rnd.Next(1, 10);
            int n2 = rnd.Next(1, 10);
            int n3 = rnd.Next(1, 10);
            int n4 = rnd.Next(1, 10);
            int n5 = rnd.Next(1, 10);
            int n6 = rnd.Next(1, 10);
            int n7 = rnd.Next(1, 10);
            int n8 = rnd.Next(1, 10);
            int n9 = rnd.Next(1, 10);

            int cont = 0;

            if (nprincipal == n1) cont++;
            if (nprincipal == n2) cont++;
            if (nprincipal == n3) cont++;
            if (nprincipal == n4) cont++;
            if (nprincipal == n5) cont++;
            if (nprincipal == n6) cont++;
            if (nprincipal == n7) cont++;
            if (nprincipal == n8) cont++;
            if (nprincipal == n9) cont++;

            Console.WriteLine("Número principal: "+nprincipal+ " ( R$"+premio+" )");
            Console.WriteLine(n1 + " " + n2 + " " + n3);
            Console.WriteLine(n4 + " " + n5 + " " + n6);
            Console.WriteLine(n7 + " " + n8 + " " + n9);

            if (cont >= 3)
            {
                Console.WriteLine("Parabéns você foi premiado!! Ganhou  R$"+premio);
                saldo += premio;
            }
                
            else
                Console.WriteLine("Sinto muito, Você não foi premiado.");
            Console.ReadKey();

        }

        private static void RaspadinhaA()
        {
            Console.Clear();
            if (saldo - 2 < 0)
            {
                Console.WriteLine("Saldo insuficiente, realize um depósito antes de jogar");
                Console.ReadKey();
                return;
            }

            saldo -= 2;

            int nprincipal = rnd.Next(1, 10);
            int n1 = rnd.Next(1, 10); int p1 = rnd.Next(1, 101);
            int n2 = rnd.Next(1, 10); int p2 = rnd.Next(1, 101);
            int n3 = rnd.Next(1, 10); int p3 = rnd.Next(1, 101);
            int n4 = rnd.Next(1, 10); int p4 = rnd.Next(1, 101);
            int n5 = rnd.Next(1, 10); int p5 = rnd.Next(1, 101);

            Console.WriteLine("Número principal: "+nprincipal);
            Console.WriteLine("1ª número: " + n1 + " (R$" + p1 + ".00)");
            Console.WriteLine("2ª número: " + n2 + " (R$" + p2 + ".00)");
            Console.WriteLine("3ª número: " + n3 + " (R$" + p3 + ".00)");
            Console.WriteLine("4ª número: " + n4 + " (R$" + p4 + ".00)");
            Console.WriteLine("5ª número: " + n5 + " (R$" + p5 + ".00)");

            int premio = 0;

            if (n1 == nprincipal) premio += p1; 
            if (n2 == nprincipal) premio += p2;
            if (n3 == nprincipal) premio += p3;
            if (n4 == nprincipal) premio += p4;
            if (n5 == nprincipal) premio += p5;

            Console.WriteLine("Premio: R$"+premio+".00");
            saldo += premio;

            Console.ReadKey();
        }

        private static void Loteria()
        {
            Console.Clear();
            if (saldo - 5 < 0) 
            {
                Console.WriteLine("Saldo insuficiente, realize um depósito antes de jogar");
                Console.ReadKey();
                return;
            }

            saldo -= 5;
            int npremiado = rnd.Next(1000, 10000);
            int njogador = 0;
            double premio = rnd.Next(0, 10000);
            while (njogador < 1000 || njogador > 9999)
            {
                Console.Clear();
                Console.WriteLine("Qual jogo quer fazer em nossa loteria? digite 4 numeros de 1000 a 9999. ");
                Console.WriteLine("Nesta rodada o 1° Prêmio é: R$" + premio);
                Console.WriteLine("Nesta rodada o 2° Prêmio é: R$" + premio * 0.50);
                Console.WriteLine("Nesta rodada o 3° Prêmio é: R$" + premio * 0.20);
                njogador = int.Parse(Console.ReadLine());

            }


            if ( npremiado == njogador) 
            {

                Console.WriteLine("PARABENS, GANHOU O 1° PREMIO!!");
                Console.WriteLine("O prêmio é de: R$" + premio);
                saldo += premio;

            }
            else if (npremiado % 1000 == njogador % 1000)
            {

                Console.WriteLine("PARABENS, GANHOU O 2° PREMIO!!");
                Console.WriteLine("O prêmio é de: R$" + premio * 0.50);
                saldo += (premio * 0.50);
            }
            else if (npremiado % 100 == njogador % 100)
            {

                Console.WriteLine("PARABENS, GANHOU O 3° PREMIO!!");
                Console.WriteLine("O prêmio é de: R$" + premio * 0.20);
                saldo += (premio * 0.20);

            }
            else
            {
                Console.WriteLine("Sinto muito, mas seu bilhete não foi premiado");
            }

            Console.WriteLine("O Bilhete premiado é: " + npremiado);

            Console.ReadKey();
        }
    }
}
