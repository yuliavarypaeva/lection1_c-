﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void CheckPalindromNumber(int number)
{
    if(number >= 10000)
    {
        int division1 = number / 10000;
        int remainder1 = number % 10;
            if(division1 == remainder1)
            {
                number = number / 10;
                int division2 = (number / 100) % 10;
                int remainder2 = number % 10;
                if(division2 == remainder2)
                    Console.WriteLine("Число является палиндромом");
            }
            else 
            Console.WriteLine("Число не является палиндромом");
    }
    else
    Console.WriteLine("Некорректное число!");
}
 
Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine());
CheckPalindromNumber(number);