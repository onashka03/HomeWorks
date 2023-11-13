using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
  public  class Matrix
    {
        public double[,] matrix;
        public int rows;
        public int columns;

        public Matrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            matrix = new double[rows, columns];
        }

        public void Add(Matrix other)
        {
            if (rows != other.GetRows() || columns != other.GetColumns())
            {
                throw new ArgumentException("Размеры матриц не совпадают");
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] += other.GetValue(i, j);
                }
            }
        }

        public void MultiplyByScalar(double scalar)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] *= scalar;
                }
            }
        }

        public Matrix MultiplyByMatrix(Matrix other)
        {
            if (columns != other.GetRows())
            {
                throw new ArgumentException("Количество столбцов первой матрицы не совпадает с количеством строк второй матрицы");
            }

            Matrix result = new Matrix(rows, other.GetColumns());

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < other.GetColumns(); j++)
                {
                    for (int k = 0; k < columns; k++)
                    {
                        result.SetValue(i, j, result.GetValue(i, j) + GetValue(i, k) * other.GetValue(k, j));
                    }
                }
            }

            return result;
        }

        public void Print()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void SetValue(int row, int column, double value)
        {
            matrix[row, column] = value;
        }

        public double GetValue(int row, int column)
        {
            return matrix[row, column];
        }

        public int GetRows()
        {
            return rows;
        }

        public int GetColumns()
        {
            return columns;
        }
    }
}
