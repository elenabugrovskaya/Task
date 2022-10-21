// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число от 1 до 7: ");
int num = int.Parse(Console.ReadLine());

if (num < 8 && num != 0)
{
    if (num < 6)
    Console.WriteLine("рабочий день");
    else Console.WriteLine("выходной");
}
else Console.WriteLine("Число не обозначает день недели");