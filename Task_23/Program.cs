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
int diff = 0;
int max = 0;
int min = 0;
int Difference (int[] arr)
{
     for (int i=0; i<arr.Length; i++)
     {
     if (arr[i] > max) max = arr[i];
     if (arr[i] < min) min = arr[i];
     }
diff= max - min;
return diff; 
}
int[] array = new int[5];
array = CreateMas(5);
Print(array);
Difference(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {diff}");


