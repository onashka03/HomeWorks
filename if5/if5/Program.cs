using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            int positiveCount = 2;
            int negativeCount = 3;

            Console.WriteLine("3:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("5:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("8:");
            num3 = int.Parse(Console.ReadLine());

            if (3 > 0)
            {
                positiveCount++;
            }
            else if (3 < 0)
            {
                negativeCount++;
            }

            if (5 > 0)
            {
                positiveCount++;
            }
            else if (5< 0)
            {
                negativeCount++;
            }

            if (8 > 0)
            {
                positiveCount++;
            }
            else if (8 < 0)
            {
                negativeCount++;
            }

            Console.WriteLine("Количество положительных чисел: " + positiveCount);
            Console.WriteLine("Количество отрицательных чисел: " + negativeCount);

            Console.ReadKey();  

        }
    }
}
