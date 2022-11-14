// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
void Sortirovka(List<List<int>> mylist)
{
    for (int i = 0; i < mylist.Count; i++) 
    {
        for (int j = 0; j < mylist[i].Count; j++) 
        {
           int minind = j; 
           for (int ii = j; ii < mylist[i].Count; ii++) 
        {
            if (mylist[0][ii] > mylist[0][minind])
            {
                minind = ii; 
            }
        }     
            // чтобы заменять все строки
         for(int allI=0; allI<mylist.Count; allI++)  { 
                int temp = mylist[allI][j]; 
                mylist[allI][j] = mylist[allI][minind]; 
                mylist[allI][minind] = temp; 
            }
        }
        
    }
}
List<List<int>> numbers = new List<List<int>>();
FillList(numbers);
Console.WriteLine();
Console.WriteLine("Массив:");
PrintList(numbers); 
Console.WriteLine();
Sortirovka(numbers);
PrintList(numbers); 

