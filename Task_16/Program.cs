// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

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
