// Напишите программу, которая заполнит спирально массив 4 на 4. 

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
//Console.WriteLine("Введите количество элементов в строке"); 
// int n = int.Parse(Console.ReadLine()); 
// Console.WriteLine("Введите количество элементов в cтолбце"); 
// int m = int.Parse(Console.ReadLine()); 
//int[,] arr = new int[m, n]; 
int k = 1; 
int t = 0; 
int i, j = 0; 
int n = arr.GetLength(1); 
int m = arr.GetLength(0); 
 
while (k <= arr.GetLength(1) * arr.GetLength(0)) 
{ 
for (i = t; i < arr.GetLength(1); i++) 
    arr[j, i] = k++; 
    j = arr.GetLength(1) - 1; 
for (i = t + 1; i < arr.GetLength(0); i++) 
    arr[i, j] = k++; 
    j = arr.GetLength(0) - 1; 
for (i = arr.GetLength(1) - 2; i >= t; i--) 
    arr[j, i] = k++; 
    j = t; 
for (i = arr.GetLength(0) - 2; i > t; i--) 
    arr[i, j] = k++; 
    n--; 
    m--; 
    t++; 
    j = t; 
} 
}

int[,] array = new int [4, 4];
FillMas(array);
Spiral(array); 
Output(array);


/*  void Spiral (int[,] arr)
{
//Console.WriteLine("Введите количество элементов в строке"); 
// int n = int.Parse(Console.ReadLine()); 
// Console.WriteLine("Введите количество элементов в cтолбце"); 
// int m = int.Parse(Console.ReadLine()); 
int[,] arr = new int[m, n]; 
int k = 1; 
int t = 0; 
int i, j = 0; 
int n1 = n; 
int m1 = m; 
 
while (k <= n1 * m1) 
{ 
for (i = t; i < n; i++) 
    arr[j, i] = k++; 
    j = n - 1; 
for (i = t + 1; i < m; i++) 
    arr[i, j] = k++; 
    j = m - 1; 
for (i = n - 2; i >= t; i--) 
    arr[j, i] = k++; 
    j = t; 
for (i = m - 2; i > t; i--) 
    arr[i, j] = k++; 
    n--; 
    m--; 
    t++; 
    j = t; 
} 
 for (i = 0; i < arr.GetLength(0); i++) 
    {    
        for (j = 0; j < arr.GetLength(1); j++) 
        Console.Write("{0,2} ", arr[i, j]); 
        Console.WriteLine(); 
    } 
}
int[,] array = new int [4, 4];

Spiral(array);  */