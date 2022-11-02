// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int m = 5;
int[] CreateMas (int m)
{
    int[] arr = new int[m];
    for (int i=0; i<m; i++)
    arr[i] = int.Parse(Console.ReadLine());
    return arr; 
} 
// void Print(int[] arr)
// {
//     Console.WriteLine(String.Join(" ", arr));
//     Console.Write("\n");
// }

int Kolichestvo (int[] arr)
{
int k = 0;
for (int i=0; i<m; i++)
{
if (arr[i] > 0) k++;
}
Console.WriteLine($"Количество чисел больше 0: {k}");
return k;
}
Console.WriteLine("Введите 5 чисел: ");
int[] array = new int[5];
array = CreateMas(m);
Console.WriteLine();
//Print(array);
Kolichestvo(array);

