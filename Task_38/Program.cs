// Напишите программу, которая заполнит спирально массив 4 на 4. 
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillMas (int[,] arr)
{
    for (int i=0; i<arr.GetLength(0); i++)
    for (int j=0; j<arr.GetLength(1); j++)
    arr[i, j] = new Random().Next(2, 10);
}
void Output (int [,] arr)
{
    for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        Console.Write("{0,2} ", arr[i, j]);
        Console.WriteLine();
    }
    Console.WriteLine();
} 
void Spiral (int[,] arr)
{ 
int temp = 1; 
int i = 0;
int j = 0; 
while (temp <= arr.GetLength(0)*arr.GetLength(1))
{
arr[i,j] = temp;
temp++;
if (i <= j + 1 && i + j < arr.GetLength(1) - 1) j++;
else if (i < j && i + j >= arr.GetLength(0) - 1) i++;
else if (i >= j && i + j > arr.GetLength(1) - 1) j--;
else i--;
}
//return arr;
}

int[,] array = new int [4, 4];
FillMas(array);
Spiral(array); 
Output(array);


