// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.Write("Введите число от 1 до 9999: ");
int num = int.Parse(Console.ReadLine());
void summa()
{
int sum = 0;
if (num < 100)
   sum = num/10 + num%10;
else if (num<1000)
   sum = num/100%10 + num/10%10 + num%10;
else if (num<=9999)
   sum = num/1000%10 + num/100%10 + num/10%10 + num%10;
Console.WriteLine($"Сумма цифр в числе: {sum}");
}
summa();
