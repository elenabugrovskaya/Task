// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 5
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillList(List<List<int>> mylist)
{
    Console.WriteLine("Задайте рамер массива: ");
    int n = int.Parse(Console.ReadLine());
    int m = int.Parse(Console.ReadLine());
    for(int i=0; i<n; i++)
    {
        mylist.Add(new List<int>());
        for(int j=0; j<m; j++)
        mylist[i].Add(new Random().Next(0,10));
    }
}
void PrintList(List<List<int>> mylist)
{
    for(int i=0; i<mylist.Count; i++)
    {
        for(int j=0; j<mylist.Count; j++)
        Console.Write(mylist[i][j] + "\t");
        Console.WriteLine();
    }
}
void Average(List<List<int>> mylist)
{ 
    double sum = 0;
    double mid = 0;
    for(int j=0; j<mylist.Count; j++)
    {
    for(int i=0; i<mylist.Count; i++)
    {
          sum += mylist[i][j];
          mid = sum/mylist.Count; 
    }
     Console.Write(mid + "\t");  sum = 0;
    }
}  
int k = 0;
List<List<int>> numbers = new List<List<int>>();
FillList(numbers);
Console.WriteLine();
Console.WriteLine("Массив:");
PrintList(numbers); 
Console.WriteLine();
Console.WriteLine("Среднее арифметическое по столбцам:");
Average(numbers);
