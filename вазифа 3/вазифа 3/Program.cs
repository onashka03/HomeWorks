using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace вазифа_3
{
    class Program
    {
        static void Main(string[] args)
        {
            library[] readers = new library[2];
        
        readers[0] = new library("Азиза ", 12345, "Физика", new DateTime(1990, 5, 15), "123-456-7890");
        readers[1] = new library("Аниса ", 54321, "Математика", new DateTime(1985, 10, 20), "987-654-3210");

        readers[0].takeBook(3);
        readers[0].takeBook("Приключения", "Словарь", "Энциклопедия");
        readers[0].takeBook(new Book("Приключения", "Автор1"), new Book("Словарь", "Автор2"), new Book("Энциклопедия", "Автор3"));

        readers[1].returnBook(2);
        readers[1].returnBook("Роман", "Поэма");
        readers[1].returnBook(new Book("Роман", "Автор4"), new Book("Поэма", "Автор5"));
        Console.ReadKey();
    }
        }
    }
