﻿// Напишите программу, которая принимает на вход число
// и проверяет, кратно ли оно одновременно 7 и 23
// 14 Нет 
// 46 нет 
// 161 да

Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());


if ((number % 7 == 0) && (number % 23 == 0 ))

{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");  
}