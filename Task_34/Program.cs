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

            void FillMas (int[,] arr)
            {
            Random ran = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = ran.Next(0, 10);
                }
            }
            }
            void Sort (int[,] arr)
            {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    temp[j] = arr[i, j];
                Array.Sort(temp);
                Array.Reverse(temp);
                for (int k = 0; k < n; k++)
                {
                    arr[i, k] = temp[k];
                }
            }
            }
            void Output (int [,] arr)
            {
                for (int i = 0; i < n; i++)
                {
                for (int j = 0; j < n; j++)
                {
                     Console.Write("{0}\t", arr[i, j]);
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