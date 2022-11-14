// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/* Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7 
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

void FillMas (int[,] arr)
{
    for (int i=0; i<arr.GetLength(0); i++)
    for (int j=0; j<arr.GetLength(1); j++)
    arr[i, j] = new Random().Next(2, 10);
}
void Output (int [,] arr)
{
    for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        Console.Write(arr[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
} 
void Average(int [,] arr)
{ 
 int minRowSum = int.MaxValue, indexMinRow = 0;
 
for (int i = 0; i < arr.GetLength(0); i++)
{
    int rowSum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    rowSum += arr[i, j];
                
    if (rowSum < minRowSum)
    {
        minRowSum = rowSum;
        indexMinRow = i;
    }
}
Console.WriteLine("Строка с минимальной суммой элементов:");
for(int j = 0;j<arr.GetLength(1);j++)
Console.Write(arr[indexMinRow, j] + "\t");    
}  

int[,] array = new int [4, 5];
FillMas(array);
Output(array);
Average(array);