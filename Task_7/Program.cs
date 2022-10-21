// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int num = new Random().Next();
Console.WriteLine(num);

if (num > 99) Console.WriteLine($"Третья цифра заданного числа {num.ToString()[2]}");
else  Console.WriteLine("Третьей цифры нет"); 
    
       


