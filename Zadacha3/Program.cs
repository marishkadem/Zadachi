﻿Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else if (a % 2 == 1 )
{
    Console.WriteLine("Число нечетное");
}