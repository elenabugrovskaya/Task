// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


    Console.Write("Введите пятизначное число: ");
    int number = int.Parse(Console.ReadLine());
void palindrom()
{ 
        int num1 = number / 10000 % 10;
        int num2 = number / 1000 % 10;
        int rev1 = number / 10 % 10;
        int rev2 = number % 10;
        int nul = number / 10000;
        
            if (nul < 1 || nul > 9)
            Console.WriteLine($"{number} - это не пятизначное число");
            
            else if  (num1 == rev2 && num2 == rev1)
            Console.WriteLine($"{number} - это палиндром");
        
            else
            Console.WriteLine($"{number} - это не палиндром");
            
 }
    palindrom();
