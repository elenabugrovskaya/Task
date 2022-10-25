// Создать программу, которая из массива удаляется элемент с позиции, которую введет пользователь.

class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 14, 185, 12, 32, 34, 14, 82, 34, 15, 0, 92 };
            Console.WriteLine("Массив: ");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(" {0}", x[i]);
            }
            Console.WriteLine("\nВведите номер того элемента,который нужно удалить 0-10:");
            int c = int.Parse(Console.ReadLine());
            List<int> temp = x.ToList();
            temp.RemoveAt(c);
            x = temp.ToArray();
 
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(" {0}", x[i]);
            }
 
        }
    }
