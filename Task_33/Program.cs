/// Отсортировать в матрице столбцы по убыванию значений элементов в первой строке. Использовать заполнение случайными 
// значениями.
// 3 -2 6 4        
// 8 1 12 2 ->
// 5 4 -8 0

//  6 4 3 -2 
// 12 2 8  1  
// -8 0 5  4 

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
    for (int j=0; j<mylist.Count-1; j++)
    {
        for(int i=0; i<mylist.Count; i++)
        {  
        if (mylist[i][j] < mylist[i][j+1] )
        {  //Console.WriteLine(mylist[i][j+1]); 
            int temp = mylist[i][j];
            mylist[i][j] = mylist[i][j+1];
            mylist[i][j+1] = temp;
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

//Console.WriteLine("Hello, World!");
PrintList(numbers); 
