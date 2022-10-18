/* Какая сумма элементов массива больше – с первого до элемента с номером К или от элемента с номером К+1 до последнего.
На вход подается массив чисел. Затем вводится переменная K. На выход программа должна вывести или "Первая часть" или "Вторая часть"
Например, при вводе массива [8 11 15 8 9 10] и числа 3. Программа должна вывести 1 часть, так как 42 больше, чем 19. */

int[] myArr = new int[6];

myArr[0] = 8; 
myArr[1] = 11;
myArr[2] = 15;
myArr[3] = 8;
myArr[4] = 9;
myArr[5] = 10;


int k = 3;
int sum1 =0;
int sum2 =0;
int max = 0;

for (int i = 0; i <= k; i++)
    
        sum1 = sum1 + myArr[i];
     
for (int i = k+1; i < myArr.Length; i++)
    
        sum2 = sum2 + myArr[i];
      
if (sum1 > sum2)

    for (int i = 0; i <= k; i++)
        Console.WriteLine(myArr[i]);

else
for (int i = k+1; i < myArr.Length; i++)
    Console.WriteLine(myArr[i]);