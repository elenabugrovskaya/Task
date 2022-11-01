// Дан список некоторых целых чисел, найдите значение 20 в нем и, если оно присутствует, замените его на 200. Обновите список
// только при первом вхождении числа 20.
// [21, 53,20, 56, 45,20] -> [21, 53,200, 56, 45,20]
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
int ColNeChet (int[] arr)
{
    {
     for (int i=0; i<arr.Length; i++)
     if (arr[i]%2 != 0) sum = sum +arr[i];
    }
return sum;
}
int[] array = new int[5];
array = CreateMas(5);
Print(array);
ColNeChet(array);
Console.WriteLine($"Сумма нечетных элементов массива: {sum}");

