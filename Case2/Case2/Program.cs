using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case2
{
    class Program
    {
        static void Main(string[] args)
        {
            int K = 3;

        string result;

        switch (K)
        {
            case 1:
                result = "плохо";
                break;
            case 2:
                result = "неудовлетворительно";
                break;
            case 3:
                result = "удовлетворительно";
                break;
            case 4:
                result = "хорошо";
                break;
            case 5:
                result = "отлично";
                break;
            default:
                result = "ошибка";
                break;
        }

        Console.WriteLine(result);
        Console.ReadKey();
        }
    }
}
