using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefFunctionsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 5;
            //int x;
            //Console.WriteLine("Przed: " + x);
            int[] tab = new int[2];
            tab[0] = 1;
            tab[1] = 0;

            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Przed:" + tab[i]);
            }
            IncreaseWithoutChange(tab);
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Po 1:" + tab[i]);
            }

            IncreaseWithChange(tab);
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Po 2:" + tab[i]);
            }

            //SmtDoFunction(ref x);
            //SmtDoFunction(out x);
            //Console.WriteLine("Po: " + x);

            Console.ReadLine();
        }

        static void IncreaseWithoutChange(int[] numbersToIncrease)
        {
            numbersToIncrease = new int[2];
            for (int i = 0; i < numbersToIncrease.Length; i++)
            {
                numbersToIncrease[i]++;
                Console.WriteLine("W trakcie 1:" + numbersToIncrease[i]);
            }
        }

        static void IncreaseWithChange(int[] numbersToIncrease)
        {
            for (int i = 0; i < numbersToIncrease.Length; i++)
            {
                numbersToIncrease[i]++;
                Console.WriteLine("W trakcie 2:" + numbersToIncrease[i]);
            }
        }

        //static void SmtDoFunction(ref int numberWillChange)
        //{
        //    numberWillChange++;
        //}

        //static void SmtDoFunction(out int numberWillChange)
        //{
        //    numberWillChange = 1;
        //    numberWillChange++;
        //}


    }
}
