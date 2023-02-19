// Напишите программу, которая принимает на вход
// трехзначное число и на выходе показывает вторую цифру этого числа
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());


int firstValue = num / 100;
int secondValue = num / 10;
int thirdValue = num % 10;


Console.WriteLine($"Вторая цифра: {(num -(firstValue * 100 + thirdValue))/10}");