using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean5
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 10;
            int B = 20;

            bool statement = A >= 0 || B < -2;

            Console.WriteLine("Истинность высказывания: " + statement);

            Console.ReadKey();

        }
    }
}
