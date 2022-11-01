// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] CreateMas (int n)
{
    int[] arr = new int[n];
    for (int i=0; i<n; i++)
    arr[i] = new Random().Next(-99, 99);
    return arr; 
} 
void Print(int[] arr)
{
    Console.WriteLine(String.Join(" ", arr));
    Console.Write("\n");
}
int difference = 0;
int ColChet (int[] arr)
{
    {
     for (int i=0; i<arr.Length; i++)
     int max = arr[0];
     if (arr[i] > max) max = 
    }
return difference;
}
int[] array = new int[5];
array = CreateMas(5);
Print(array);
difference = sum +arr[i];
ColChet(array);
Console.WriteLine($"Сумма нечетных элементов массива: {sum}");


