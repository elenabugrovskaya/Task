// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using System;
 
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int[,] a = new int[n, n];
            int[] temp = new int[n];

            int[,] FillMas (int[,] a)
            {
            Random ran = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = ran.Next(1, 5);
                }
            }
            return a;
            }
            int[,] Sort (int[,] a)
            {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    temp[j] = a[i, j];
                Array.Sort(temp);
                Array.Reverse(temp);
                for (int k = 0; k < n; k++)
                {
                    a[i, k] = temp[k];
                }
            }
            return a;
            }
            void Output (int [,] arr)
            {
                for (int i = 0; i < n; i++)
                {
                for (int j = 0; j < n; j++)
                {
                     Console.Write("{0}\t", a[i, j]);
                }
                Console.WriteLine();
                }
            }    

            FillMas(a);
            Console.WriteLine("\n Массив: ");
            Output(a);
            Sort(a);
            Console.WriteLine("\n Сортировка по строкам: ");
            Output(a);
        }
    }