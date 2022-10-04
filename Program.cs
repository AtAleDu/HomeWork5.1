using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Sum(int[,] matrix, int row, int col, int[,] matrix2)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{matrix[i,j] = matrix2[i,j] + matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }
        static void Filling(int [,] matrix, int row,int col)
        {
            Random rand = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = rand.Next(0,9);
                }
            }
        }
        static void Filling(int row, int col, int[,] matrix2)
        {
            Random rand2 = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix2[i, j] = rand2.Next(0, 9);
                }
            }
        }
        static void Print(int[,] matrix, int row, int col)
        {
            Console.WriteLine("Исходная матрица");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
        static void Print(int row, int col, int[,] matrix2)
        {
            Console.WriteLine("Исходная матрица");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matrix2[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Multiplication(int value, int[,] matrix, int row, int col)
        {
            Console.WriteLine("Перемноженная матрица");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matrix[i, j] * value );
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов");
            int col = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число на каторое умножать");
            int value = int.Parse(Console.ReadLine());

            int[,] matrix = new int[row, col];
            int[,] matrix2 = new int[row, col];

            Filling(matrix,row,col);
            Filling(row,col,matrix2);
            Print(matrix,row,col);
            Print(row, col, matrix2);
            Multiplication(value,matrix,row,col);
            Sum(matrix,row,col,matrix2);
            Console.ReadKey();
        }
    }
}
