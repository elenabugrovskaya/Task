// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Элементы задаются рандомно (диапазон 
// выбрать самостоятельно) Итоговый массив должен содержать в себе суммы цифр числа. Т.е. необходимо подсчитывать суммы цифр
// каждого числа и записывать их в новый массив.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 10]
// 63, 12, 33, 36 -> [9, 3, 6, 9]

void Fillarray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 99);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

int[]  Summa(int[] coll)
{
for (int i = 0; i<coll.Length; i++)
{
   coll[i] = coll[i]/10 + coll[i]%10;
}
return coll;
}

int[] array = new int[8];
Fillarray(array);
PrintArray(array);
Console.WriteLine();
Summa(array);
PrintArray(array);
Console.ReadKey();


