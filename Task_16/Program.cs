// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());
int sum = 0;
//while (n > 0)
 int s1 = n/10;
    if (s1>0 && s1<10)
    sum = sum + s1;
   // else break;
Console.WriteLine($"Сумма цифр в числе равна: {sum}");
*/
//Console.WriteLine("Hello, World!");
int num = new Random().Next(10, 9999);
Console.WriteLine(num);
int sum = 0;
if (num < 100)
   sum = num/10 + num%10;
else if (num<1000)
   sum = num/100%10 + num/10%10 + num%10;
else if (num<=9999)
   sum = num/1000%10 + num/100%10 + num/10%10 + num%10;

Console.WriteLine($"Сумма цифр в числе: {sum}");

// if (num < 1000)
//{
//   sum = num.ToString()[0] + num.ToString()[1];
//Console.WriteLine($"Сумма цифр в числе {sum}");
//}
//else if (num <= 9999)
//{
//   sum = num.ToString()[0] + num.ToString()[1] + num.ToString()[3] + num.ToString()[4];
//Console.WriteLine($"Сумма цифр в числе {sum}");
//}

// + {num.ToString()[2]}");
// + {num.ToString()[1]}");
//if (num > 99) Console.WriteLine($"Третья цифра заданного числа {num.ToString()[2]}");
//if (num > 99) Console.WriteLine($"Третья цифра заданного числа {num.ToString()[2]}");

//else  Console.WriteLine("Третьей цифры нет"); 