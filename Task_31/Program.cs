// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillList(List<List<int>> mylist)
{
    for(int i=0; i<4; i++)
    {
        mylist.Add(new List<int>());
        for(int j=0; j<4; j++)
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
    for(int j=0; j<4; j++)
    {
    for(int i=0; i<4; i++)
    {
          sum += mylist[i][j];
          mid = sum/mylist.Count; 
    }
    if (j==0) Console.Write(mid + "\t");  sum = 0;
    if (j==1) Console.Write(mid + "\t");  sum = 0;
    if (j==2) Console.Write(mid + "\t");  sum = 0;
    if (j==3) Console.Write(mid + "\t");
    }
}  
List<List<int>> numbers = new List<List<int>>();
FillList(numbers);
PrintList(numbers); 
Console.WriteLine("Среднее арифметическое по столбцам:");
Average(numbers);
