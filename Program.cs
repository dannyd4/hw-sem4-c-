// test 27 sem4 c# на вход число, на выходе сумма чисел входящих в ведённое число.
/*
int sum (int n)
{
    int sum = 0;
    int x = n;
    while( x !=0)
    {
        sum = sum +(x % 10);
        x = x / 10;
    }
    return sum;
}

Console.WriteLine("Введите целое положительное число");
int y = Convert.ToInt32(Console.ReadLine());

if (y < 0) 

    {
    Console.WriteLine("Указанное число меньше нуля!");
    }

else Console.WriteLine(sum(y));
*/

// test 29 sem4 c# на вход массив, на выходе вывод массива
//variant 1 
/*
void RandArray ()
{
    int[] array = new int[8];

    Console.Write("Программа сгенерировала массив из 8 элементов: ");
        for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(0,10);
        Console.Write(array[i] +" ");
    }
   
}

RandArray ();
*/


//variant 2
/*
int[] RandArray ()
{
    int[] array = new int[8];

        for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(0,100);
    }
   return array;

}

int[] arrayout = RandArray ();

Console.Write("Программа сгенерировала массив из 8 элементов: ");
for(int i = 0; i < arrayout.Length; i++)//вывод массива методом перебора элементов
{
    Console.Write( arrayout[i] + " ");
}


Console.WriteLine();
Console.WriteLine("Программа сгенерировала массив из 8 элементов: " + String.Join(" ",RandArray ()));//альтернативный вывод массива
*/


