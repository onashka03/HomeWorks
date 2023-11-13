using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_класс_Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone1 = new Phone("7777777", "Samsung", 0.3);
            Phone phone2 = new Phone("987654321", "iPhone", 0.2);
            Phone phone3 = new Phone();

            Console.WriteLine("Номер телефона: " + phone1.Number);
            Console.WriteLine("iPhone: " + phone1.Model);
            Console.WriteLine("0.2: " + phone1.Weight);

            phone1.ReceiveCall("anisa");
            phone2.ReceiveCall("Mary", "937000070");
            phone3.SendMessage("927990304", "934456789", "923456789");
            Console.ReadKey();
        }
    }
}
