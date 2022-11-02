// Дано действительное положительное число a и целое неотрицательное число n. Вычислите a в степени n не используя циклы,
// возведение  в степень через ** и функцию math.pow(), а используя рекуррентное соотношение an=a⋅an-1.
// Решение оформите в виде функции power(a, n).
Console.Write("Введите действительное положительное число a: ");
float a = float.Parse(Console.ReadLine());
Console.Write("Введите целое неотрицательное число n: ");
int n = int.Parse(Console.ReadLine());

float Stepen (int n)
{
    float step = 0;
    if (n == 0) return 1;
    else step = a * Stepen(n-1);
    return step;
}
Console.WriteLine($"{a} в степени {n} = {Stepen(n)}");


