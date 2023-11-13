using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 3;
            int B = 8;

            int N = B - A + 1;

            Console.WriteLine("Числа между {0} и {1}:", A, B);
            for (int i = A; i <= B; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Количество чисел: " + N);
        Console.ReadKey();
        }
    }
}
