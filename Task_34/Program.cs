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
 
namespace Draft
{
    class Program
    {
        static void Main()
        {
            int[][] mas = new int[3][];
            mas[0] = new int[4];
            mas[1] = new int[4];
            mas[2] = new int[4];
 
            // Заполняем массив случайными числами
            Random random = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas[i].Length; j++)
                    mas[i][j] = random.Next(0, 10);
            }

            // Исходное содержимое массива
            Console.WriteLine("Массив");
            foreach (int[] item in mas)
            {
                foreach (int element in item)
                    Console.Write(element + " ");
                Console.WriteLine();
            }
 
            // Сортировка массива
            foreach (int[] item in mas)
            {
                foreach (int element in item)
                {
                    Array.Sort(item);
                    Array.Reverse(item);
                }
                    
            }
 
            // Отсортированное содержимое массива
            Console.WriteLine("\nОтсортированный массив");
            foreach (int[] item in mas)
            {
                foreach (int element in item)
                    Console.Write(element + " ");
                Console.WriteLine();
            }
        }
    }
}        
