// Известно, что на доске 8×8 можно расставить 8 ферзей так, чтобы они не били друг друга. Вам дана расстановка 8 ферзей 
// на доске, определите, есть ли среди них пара бьющих друг друга. Программа получает на вход восемь пар чисел, каждое число
// от 1 до 8 — координаты 8 ферзей. Если ферзи не бьют друг друга, выведите слово NO, иначе выведите YES.

/*
int n = 2;
int[] CreateMas (int n)
{
    int[] arr = new int[n];
    for (int i=0; i<n; i++)
    arr[i] = int.Parse(Console.ReadLine());
    return arr; 
} 
void Print(int[] arr)
{
    Console.WriteLine(String.Join(" ", arr));
    Console.Write("\n");
}

int[] Ferzi (int n)
{
int[] array = new int[2];
for (int i=1; i<=8; i++)
{
array =CreateMas(2);
Print(array);
}
return array;
}

void CreateList(List<int> numb, int[] arr)
{

    for (int i=0; i<8; i++)
    {
    numb.Add(arr[0]);
    numb.Add(arr[1]);
    }
}
*/

int n = 8;
int[] x = {7, 2, 8, 4, 5, 1, 6, 3};
int[] y = {8, 2, 5, 3, 7, 4, 1, 6};
bool correct = true;
for (int i=0; i<n; i++)
    {
        for (int j=i+1; j<n; j++)
       { 
        if (x[i] == x[j] || y[i] == y[j] || Math.Abs(x[i] - x[j]) == Math.Abs(y[i] - y[j]))
            correct = false;
        } 
    }

    if (correct)
    Console.WriteLine("NO");
    else Console.WriteLine("YES");

