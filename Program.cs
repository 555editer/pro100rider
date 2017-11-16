using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontr_Zadanie
{
    class Cell
    {
        char[,] mycell = new char[20,20];
        Random rand = new Random();
        public void _cell()
        {
            Console.Write("\t");
            for (int i = 0; i < 21; i++)
                Console.Write("**");

            Console.WriteLine();

            int g = rand.Next(1, 20);
            int f = rand.Next(1, 20);

            for (int i = 0; i < 20; i++)
            {
                Console.Write("\t"+"|");
                for (int j = 0; j < 20; j++)
                {
                    mycell[i, j] = Convert.ToChar(rand.Next(0, 2));
                   if ( i == f && j == g)
                        mycell[i, j] = '@';

                    if (mycell[i, j] == 1 || mycell[i, j] == 2)
                        mycell[i, j] = '#';

                    Console.Write(mycell[i, j] + " ");
                }
                Console.WriteLine("|");
            }
            Console.Write("\t");
            for (int i = 0; i < 21; i++)
                Console.Write("**");
            Console.WriteLine();
            //==================================================
            Console.WriteLine("\t" + "@ - персонаж");
            Console.WriteLine("\t" + "# - препятствия");
        }



        class Program
        {
            static void Main(string[] args)
            {
                Cell cell = new Cell();
                cell._cell();
            }
        }
    }
}
