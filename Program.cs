using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07Jogos
{
    class Program
    {
        static void Main(string[] args)
        {
            void jogo1
          {
                Random sorteador = new Random();
                int numero;
                int sorteio = sorteador.Next(1, 11);


                Console.WriteLine("Bem-vindo a Conradito Jogos\n");
                Console.WriteLine("Adivinhe o número entre 1 e 10");
                Console.WriteLine("Digite o número");
                numero = int.Parse(Console.ReadLine());

                //&& -> E -> junção de condições
                // Todas as condições precisam ser satisfeitas

                // || -> OU -> independência das condições
                // ao menos uma condição precisa ser satisfeita

                if (numero > 10 || numero < 1)
                {
                    Console.WriteLine("Digite um número válido");
                    Main(null);
                    return;
                }

                if (numero == sorteio)
                {
                    Console.WriteLine("Parabéns vc venceu o jogo!");
                    Console.WriteLine("Voce acertou o numero:" + sorteio);
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine("Vc errou! Tente novamente");
                Main(null);

                Console.ReadKey();

            }

            void jogo2
          {
                Random sorteador1 = new Random();
                int numero1;
                int numero2;
                int numero3;
                int numero4;
                int sorteio1 = sorteador1.Next(1, 9);



                Console.WriteLine("Chegue até 21\n");
                Console.WriteLine("Digite o número:");
                numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                Console.WriteLine("Digite outro:");
                numero2 = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                Console.WriteLine("Digite outro:");
                numero3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Quer continuar? Se sim digite outro número:");
                numero4 = int.Parse(Console.ReadLine());

                if(numero1+numero2+numero3+numero4 > 21 || numero1+numero2+numero3+numero4 < 21)
                {
                    Console.WriteLine("Voce perdeu,tente novamente");
                }

                Console.WriteLine("Voce ganhou!");

               














                Console.ReadKey();



            }
        }
    }        }          
