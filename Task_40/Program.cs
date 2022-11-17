// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. С помощью рекурсии!!!
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int  SumNumbers (int m, int n)
{
    if (m < n) return n + SumNumbers (m, n-1);
    else return n;
}
Console.WriteLine(SumNumbers(4, 8));

