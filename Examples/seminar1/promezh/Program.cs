﻿//Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number % 10);

Console.Write("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());
for (int i = -number; i <=number; i++)
{
    Console.Write(i + ", ");
}
Console.WriteLine();