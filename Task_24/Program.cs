// Дан список некоторых целых чисел, найдите значение 20 в нем и, если оно присутствует, замените его на 200. Обновите список
// только при первом вхождении числа 20.
// [21, 53,20, 56, 45,20] -> [21, 53,200, 56, 45,20]

void CreateList(List<int> numb)
{
    for (int i=0; i<10; i++)
    numb.Add(new Random().Next(19, 30));
    numb.Add(20);
}
void Print(List<int> numb)
{
    Console.WriteLine(String.Join(" ", numb));
    Console.Write("\n");
}
void PrintEnd(List<int> numb)
{
    for(int i=0; i<12; i++)
    {
    if (numb[i]==20) numb[i]=200;
    break;
    }
    Console.WriteLine(String.Join(" ", numb));
    Console.Write("\n");
}

List<int> numbers = new List<int> ();
numbers.Add(20);
CreateList(numbers);
Print (numbers);
PrintEnd(numbers);
