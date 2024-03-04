using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Net.Security;

namespace MenuProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = (1);
            
            
            while (choice != 0)
            {
                Console.Clear();
                Console.WriteLine("********MENU********\n");
                Console.WriteLine("\nEscolha entre as opções: \n");
                Console.WriteLine("Digite (1) : Conversão de (°C),(°F) ");
                Console.WriteLine("Digite (2) : Média de notas");
                Console.WriteLine("Digite (3) : Cambio\n");
                Console.WriteLine("Digite (0) : para sair");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 0)
                {
                    Console.Clear();
                    break;
                }

                else if (choice == 1)
                {
                    CelsiusToFahrenheit();
                }
                else if (choice == 2)
                {
                    
                    Media();
                }
                else if (choice == 3)
                {
                    Cambio();
                }
            }

        }

        private static void Cambio()
        {
            Console.WriteLine(
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                );
        }

        private static void Media()
        {
            double teste1,teste2,trabalho1,trabalho2,trabalho_final,nota;

            Console.Clear ();
            Console.WriteLine("********MÉDIAS********\n");
            Console.WriteLine("Introduza as seguintes notas:\n");
            Console.WriteLine("Teste 01: ");
            teste1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Teste 02:");
            teste2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Trabalho 01:");
            trabalho1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Trabalho 02");
            trabalho2 = double.Parse(Console.ReadLine());Console.WriteLine("Trabalho final:");
            trabalho_final = double.Parse(Console.ReadLine());
            nota = (teste1+teste2+trabalho1+trabalho2+trabalho_final) / 5 ;
            
            Console.Clear();
            Console.Write("A media do aluno  é: " + nota );
            
            if (nota >= 5)
            {
                Console.WriteLine("\nO aluno foi APROVADO");
                Console.WriteLine("\nEnter para voltar ao ****MENU****.");
                Console.ReadKey();
            }
            else if(nota < 5)
            {
                Console.WriteLine("\nO aluno foi REPROVADO");
                Console.WriteLine("\nEnter para voltar ao ****MENU****.");
                Console.ReadKey();
            }


        }

        private static void CelsiusToFahrenheit()
        {
            int umoudois, celsius, fahrenheit;
            Console.Clear();
            Console.WriteLine("********CONVERSOR DE TEMPERATURA********\n");
            Console.WriteLine("Digite (1) para °C - °F\nDigite (2) para °F - °C");
            umoudois = Convert.ToInt32(Console.ReadLine());
           // Console.ReadKey();


            while (umoudois == 1)
            {
                Console.Clear();
                Console.WriteLine("Diga a temperatura em Celsius (°C): ");
                celsius = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("A temperatura em Fahrenheit é: \n" + ((celsius * 1.8) + 32) + "°F\n");
                Console.WriteLine("Enter para voltar ao ****MENU****.");
                Console.ReadKey();

                break;
            }
            if (umoudois == 2)
            {
                Console.Clear();
                Console.WriteLine("Diga a temperatura em Fahrenheit (°F): ");
                fahrenheit = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("A temperatura em Celsius é: \n" + ((fahrenheit - 32) / 1.8) + "°C\n");
                Console.WriteLine("Enter para voltar ao ****MENU****.");
                Console.ReadKey();


            }


        }
    }
    
}
