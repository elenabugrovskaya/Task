//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

int max = num1;

if (num2 > max)
    Console.WriteLine($"max = {num2}");

else
    Console.WriteLine($"max = {num1}");

