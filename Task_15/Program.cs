// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Сделать в функции, сделать проверку на отрицательность.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());
void stepen()
{
    Console.WriteLine($"А в степени В равно: {Math.Pow(A, B)}");
}
stepen();