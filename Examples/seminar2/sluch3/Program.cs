﻿//Напишите программу, которая выводит случайное 
//трехзначное число и удаляет вторую цифру этого числа
Console.Clear();

int num = new Random().Next(100,1000);
Console.WriteLine($"Число: {num}");

int firstValue = num / 100;
int secondValue = num / 10;
int thirdValue = num % 10;


Console.WriteLine($"Минус вторая цифра: {firstValue}{thirdValue}");