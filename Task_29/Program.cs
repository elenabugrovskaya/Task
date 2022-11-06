// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 3. 
// Пример:
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillList(List<List<double>> mylist)
{
    for(int i=0; i<3; i++)
    {
        mylist.Add(new List<double>());
        for(int j=0; j<3; j++)
        mylist[i].Add(new Random().NextDouble()*5);
    }
}
void PrintList(List<List<double>> mylist)
{
    for(int i=0; i<mylist.Count; i++)
    {
        for(int j=0; j<mylist.Count; j++)
        Console.Write(mylist[i][j] + " ");
        Console.WriteLine();
    }
}
List<List<double>> numbers = new List<List<double>>();
FillList(numbers);
PrintList(numbers); 

    

