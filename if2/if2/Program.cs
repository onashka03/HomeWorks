using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5; 

            if (number > 0)
            {
                number += 1;
            }
            else
            {
                number -= 2;
            }

            Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
