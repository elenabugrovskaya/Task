// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Таблица кубов чисел от 1 до {n}:");

for (int i=1; i<=n; i++)
{
    Console.WriteLine(Math.Pow(i, 3));
}

