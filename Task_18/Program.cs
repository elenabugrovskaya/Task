// Преобразовать массив так, чтобы сначала шли нулевые элементы, а затем все остальные.
//-1 -3 -1 -3 -1 0 -4 -2 -> 0 -3 -1 -3 -1 -1 -4 -2

int[] arr = {-1, -3, -1, -3, -1, 0, -4, -2};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
} 

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        if (array[i] == 0)
        {
            int a = array[i];
            array[i] = array[0];
            array[0] = a;
        }   
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);


