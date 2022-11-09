// Дана матрица целых чисел размером n*m. Выведите количество седловых точек. (Седловой точкой называется элемент, который 
// является наименьшим в своей строке и наибольшим в своем столбце или, наоборот, наибольшим в своей строке и наименьшим в 
// своем столбце).

// 3 4 - размерность
// 7 1 5 3
// 3 2 6 4 -> 2
// 5 2 8 6

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
void Sedl (List<List<int>> mylist)
{
    int SedlPoint = 0;
    List<double> MinRow = new List<double>();
    List<double> MaxCol = new List<double>();
    for (int i=0; i < mylist.Count; i++)
    {
        double MinI0 = mylist[i][0];
        for (int j=0; j < mylist.Count-1; j++)
        {
            double MinI1 = Math.Min(mylist[i][j], mylist[i][j+1]);
            if(MinI1<MinI0) MinI0=MinI1;
        }
        MinRow.Add(MinI0);
        Console.Write(MinI0 + "\t");
    }
    Console.WriteLine();
    for (int j=0; j < mylist.Count; j++)
    {
        double MaxJ0 = mylist[0][j];
    for (int i=0; i < mylist.Count-1; i++)
    {
        double MaxJ1 = Math.Max(mylist[i][j], mylist[i+1][j]);
        if(MaxJ1>MaxJ0) MaxJ0=MaxJ1; 
    }
    MaxCol.Add(MaxJ0);
    Console.Write(MaxJ0 + "\t");
    }
    Console.WriteLine();
    bool proverka = false;
    for (int i=0; i < mylist.Count; i++)
        {
            for (int j=0; j < mylist.Count; j++)
            {
                if (mylist[i][j] == MaxJ0 && mylist[i][j] == MinI0) 
                Console.WriteLine($"Точка {mylist[i][j]} является седловой.");
                proverka=true;
                else (!proverka) Console.WriteLine("Седловых точек нет.")
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
Sedl(numbers);
Console.WriteLine("Hello, World!");
