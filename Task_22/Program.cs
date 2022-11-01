// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
int sum = 0;
int ColChet (int[] arr)
{
    {
     for (int i=0; i<arr.Length; i++)
     if (arr[i]%2 != 0) sum =sum +arr[i];
    }
return sum;
}
int[] array = new int[5];
array = CreateMas(5);
Print(array);
ColChet(array);
Console.WriteLine($"Сумма нечетных элементов массива: {sum}");

