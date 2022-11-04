// Заполните двумерный массив. Вводится число n.

int n = int.Parse(Console.ReadLine());
int[,] m = new int [n,n];
int cc = 1;

for (int i=0; i<m.GetLength(0); i++)
{
    for(int j=0; j<m.GetLength(1); j++)
    {
        if (i==j) m[i,j]=i+1; 
        //if (i!=j) m[i,j]=i+1;
        //if (j==0 || i!=j) m[i,j]=i+1;
         if (j<i)
         {
             cc=j+1;
             m[i,j]=cc;
         }
         m[j,i]=m[i,j];
          if (i<j)
         {
             cc=i+1;
             m[i,j]=cc;
         }
         m[j,i]=m[i,j];
        Console.Write(m[i,j] + " ");
    }
Console.WriteLine();
}

