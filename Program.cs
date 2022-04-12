using System;

namespace MainOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            long entrada;
            do
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("1 - Selection Sort");
                Console.WriteLine("2 - Quick Sort");
                Console.WriteLine("3 - Bubble Sorte");
                Console.WriteLine("0 -  Sair");
                Console.WriteLine("---------------------");

                entrada = long.Parse(Console.ReadLine());

                switch (entrada)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 0:
                        break;
                }
            } while (entrada != 0);
        }
    }
}
