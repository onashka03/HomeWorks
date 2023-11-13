using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_класс_Phone
{
    public class Phone
    {
        public string number;
        public string model;
        public double weight;
        // Конструктор с тремя параметрами
        public Phone(string number, string model, double weight)
        {
            this.number = number;
            this.model = model;
            this.weight = weight;
        }

        // Конструктор с двумя параметрами
        public Phone(string number, string model)
        {
            this.number = number;
            this.model = model;
            this.weight = 0.0;
        }

        // Конструктор без параметров
        public Phone()
        {
            this.number = "";
            this.model = "";
            this.weight = 0.0;
        }

        public string Number
        {
            get { return number; }
        }

        public void ReceiveCall(string name)
        {
            Console.WriteLine("Звонит " + name);
        }
        // Перегруженный метод ReceiveCall
        public void ReceiveCall(string name, string phoneNumber)
        {
            Console.WriteLine("Звонит " + name + " (номер телефона: " + phoneNumber + ")");
        }

        public void SendMessage(params string[] phoneNumbers)
        {
            foreach (string number in phoneNumbers)
            {
                Console.WriteLine("Отправлено сообщение на номер " + number);
            }
        }

        public string Model { get; set; }

        public string Weight { get; set; }
    }
}

