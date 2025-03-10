using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2

            //int[,] array = new int[5, 5];
            //Random random = new Random();
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        array[i, j] = random.Next(-100, 101);
            //    }
            //}
            //Console.WriteLine("Масив:");
            //foreach (var num in array)
            //    Console.Write($"{num,5}"); //5 - вирівнювання по правому краю з шириною 5
            //Console.WriteLine("\n");
            //int min = array[0, 0], max = array[0, 0];
            //int minIndex = 0, maxIndex = 0, index = 0;
            //int[] linearArray = new int[25];

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        linearArray[index] = array[i, j];

            //        if (array[i, j] < min)
            //        {
            //            min = array[i, j];
            //            minIndex = index;
            //        }
            //        if (array[i, j] > max)
            //        {
            //            max = array[i, j];
            //            maxIndex = index;
            //        }

            //        index++;
            //    }
            //}
            //int start = Math.Min(minIndex, maxIndex) + 1;
            //int end = Math.Max(minIndex, maxIndex);
            //int sum = 0;
            //for (int i = start; i < end; i++)
            //{
            //    sum += linearArray[i];
            //}
            //Console.WriteLine($"Мінімальний елемент: {min}, Максимальний елемент: {max}");
            //Console.WriteLine($"Сума елементів між ними: {sum}");


            //4

            //    const int size = 2; // фіксований розмір 2 на 2

            //    int[,] matrix1 = GetMatrix(size, "першої");
            //    int[,] matrix2 = GetMatrix(size, "другої");

            //    Console.Write("Введіть число для множення матриці: ");
            //    int scalar = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("\n Множення першої матриці на число:");
            //    PrintMatrix(MultiplyByScalar(matrix1, scalar));

            //    Console.WriteLine("\n Додавання матриць:");
            //    PrintMatrix(AddMatrices(matrix1, matrix2));

            //    Console.WriteLine("\n Добуток матриць:");
            //    PrintMatrix(MultiplyMatrices(matrix1, matrix2));
            //}


            //static int[,] GetMatrix(int size, string name)  // введення матриці
            //{
            //    int[,] matrix = new int[size, size];
            //    Console.WriteLine($"\nВведіть елементи {name} матриці:");

            //    for (int i = 0; i < size; i++)
            //    {
            //        for (int j = 0; j < size; j++)
            //        {
            //            Console.Write($"Елемент [{i + 1},{j + 1}]: ");
            //            matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            //        }
            //    }

            //    return matrix;
            //}


            //static int[,] MultiplyByScalar(int[,] matrix, int scalar)   // множення матриці на число
            //{
            //    int size = matrix.GetLength(0);
            //    int[,] result = new int[size, size];

            //    for (int i = 0; i < size; i++)
            //        for (int j = 0; j < size; j++)
            //            result[i, j] = matrix[i, j] * scalar;

            //    return result;
            //}

            //static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)        //додавання матриць
            //{
            //    int size = matrix1.GetLength(0);
            //    int[,] result = new int[size, size];

            //    for (int i = 0; i < size; i++)
            //        for (int j = 0; j < size; j++)
            //            result[i, j] = matrix1[i, j] + matrix2[i, j];

            //    return result;
            //}
            //static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)        // множення двох матриць
            //{
            //    int size = matrix1.GetLength(0);
            //    int[,] result = new int[size, size];

            //    for (int i = 0; i < size; i++)
            //    {
            //        for (int j = 0; j < size; j++)
            //        {
            //            result[i, j] = 0;
            //            for (int k = 0; k < size; k++)
            //            {
            //                result[i, j] += matrix1[i, k] * matrix2[k, j];
            //            }
            //        }
            //    }

            //    return result;
            //}
            //static void PrintMatrix(int[,] matrix)        // виведення матриці
            //{
            //    int size = matrix.GetLength(0);

            //    for (int i = 0; i < size; i++)
            //    {
            //        for (int j = 0; j < size; j++)
            //            Console.Write(matrix[i, j] + "\t");

            //        Console.WriteLine();
            //    }
        }
    }
}
