using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainOrder.Algorithm;

namespace MainOrder
{
    class Order
    {
        long entrada;

        public Order()
        {
            entrada = 0;
        }

        public void Menu()
        {
            Selection algSelection = new Selection();
            Quick algQuick = new Quick();
            Bubble algBubble = new Bubble();

            do
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("1 - Selection Sort");
                Console.WriteLine("2 - Quick Sort");
                Console.WriteLine("3 - Bubble Sort");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("-------------------------------");

                entrada = long.Parse(Console.ReadLine());

                this.CmdClear();

                switch (entrada)
                {
                    case 1:
                        algSelection.AlgoSelection();
                        break;
                    case 2:
                        algQuick.AlgoQuick();
                        break;
                    case 3:
                        algBubble.AlgoBubble();
                        break;
                    case 0:
                        break;
                    default:
                        break;
                }
            } while (entrada != 0);
        }

        public void CmdClear()
        {
            Console.Clear();
        }
    }


}
