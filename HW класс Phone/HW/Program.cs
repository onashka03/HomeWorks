using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
   public class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix(2, 2);
        matrix1.SetValue(0, 0, 1);
        matrix1.SetValue(0, 1, 2);
        matrix1.SetValue(1, 0, 3);
        matrix1.SetValue(1, 1, 4);

        Matrix matrix2 = new Matrix(2, 2);
        matrix2.SetValue(0, 0, -1);
        matrix2.SetValue(0, 1, -2);
        matrix2.SetValue(1, 0, -3);
        matrix2.SetValue(1, 1, -4);

        Console.WriteLine("Матрица 1:");
        matrix1.Print();

        Console.WriteLine("Матрица 2:");
        matrix2.Print();

        matrix1.Add(matrix2);
        Console.WriteLine("Сумма матриц 1 и 2:");
        matrix1.Print();

        matrix1.MultiplyByScalar(2);
        Console.WriteLine("Матрица 1, умноженная на 2:");
        matrix1.Print();

        Matrix matrix3 = matrix1.MultiplyByMatrix(matrix2);
        Console.WriteLine("Умножение матрицы 1 на матрицу 2:");
        matrix3.Print();
        Console.ReadKey();
    }
        }
    }
