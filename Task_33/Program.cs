/// Отсортировать в матрице столбцы по убыванию значений элементов в первой строке. Использовать заполнение случайными 
// значениями.
// 3 -2 6 4        
// 8 1 12 2 ->
// 5 4 -8 1

//  6 4 3 -2 
// 12 2 8  1  
// -8 1 5  4 

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
            if (mylist[0][ii] < mylist[0][minind])
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

/* void SortList(List <List <double>> Mylist){
    int k = 5; // ÐºÐ¾Ð»Ð¸Ñ‡ÐµÑÑ‚Ð²Ð¾ ÑÑ‚Ð¾Ð»Ð±Ñ†Ð¾Ð² -1 Mylist.Count - 1
    while (k>0){
        int index = 0;
        for (int j=1;j<k;j++)
            if (Mylist[0][j]>Mylist[0][index])
                index = j;
        //Console.Write(index+ " ");
        for(int i=0;i<5;i++){
            double temp = Mylist[i][index];
            Mylist[i][index] = Mylist[i][k-1];
            Mylist[i][k-1] = temp ;
        }
        //PrintList(Mylist); 
        k--;  
    }
}
List <List <double>> numbers = new List<List<double>>();
fillList(numbers);
PrintList(numbers);
SortList(numbers);
PrintList(numbers); */