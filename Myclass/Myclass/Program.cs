using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Myclass myclass1 = new Myclass();
            myclass1.For();
            Myclass myclass2= new Myclass();
            myclass2.Foreach();
            Console.ReadKey();

        }
    }
}
