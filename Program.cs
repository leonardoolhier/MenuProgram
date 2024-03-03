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
                Console.WriteLine("Escolha entre as opções: \n");
                Console.WriteLine("Digite (1) : Conversão de (°C),(°F) ");
                Console.WriteLine("Digite (2) : Média de notas");
                Console.WriteLine("Digite (3) : paraoutracoisa\n");
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
            }

        }
        private static void CelsiusToFahrenheit()
        {
            int umoudois, celsius, fahrenheit;
            Console.Clear();
            Console.WriteLine("Digite (1) para °C - °F\nDigite (2) para °F - °C");
            umoudois = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();


            while (umoudois == 1)
            {
                Console.Clear();
                Console.WriteLine("Diga a temperatura em Celsius (°C): ");
                celsius = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("A temperatura em Fahrenheit é: \n" + ((celsius * 1.8) + 32) + "°F\n");
                Console.WriteLine("Enter para voltar ao menu anterior.");
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
                Console.WriteLine("Enter para voltar ao menu anterior.");
                Console.ReadKey();


            }


        }
    }
    
}
