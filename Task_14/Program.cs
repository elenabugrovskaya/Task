// Создание массива из двух массивов. В итоговом массиве должны быть элементы первого и второго массива.
// [1,2,3] [4,5,6] -> [1,2,3,4,5,6]

using System;
public class Example
{
    public static void Main()
{
    int[] arr1 = { 1, 2, 3};
    Console.WriteLine(String.Join(" ", arr1));
    int[] arr2 = {4, 5, 6};
    Console.WriteLine(String.Join(" ", arr2));
    int[] result = new int[arr1.Length + arr2.Length];
    Array.Copy(arr1, result, arr1.Length);
    Array.Copy(arr2, 0, result, arr1.Length, arr2.Length);
    Console.WriteLine("Итоговый массив:");
    Console.WriteLine(String.Join(" ", result));
}
}





           