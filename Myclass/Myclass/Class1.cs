using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myclass
{
    public class Myclass
    {
        public int[] num = { 23, 25, 41, 36 };
        public int number1 = 32;
        public int number2 = 100;
        public string name = "Aziza";

        public void For()
    {
        for (int i = 1; i <= 10; i++)
        {
            num[2] = 1;
            Console.WriteLine(num[2]);
        }
    }

        public void Foreach()
        {
            foreach (char name in "Aziza")
            {
                Console.WriteLine(name);           
            }
            foreach(int num1 in num)
            {
                Console.Write(num + " ");
            }
        }

    }
}
