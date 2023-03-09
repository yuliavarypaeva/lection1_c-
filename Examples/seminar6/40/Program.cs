﻿// Задача 40: Напишите программу, которая принимает на вход три
//  числа и проверяет, может ли существовать треугольник с сторонами
//   такой длины.
// 	Теорема о неравенстве треугольника: каждая сторона 
//     треугольника меньше суммы двух других сторон.

Console.Clear();

Console.WriteLine("Введите размер первой стороны треугольника");
int oneNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер второй стороны треугольника");
int twoNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер третьей стороны треугольника");
int treeNum = Convert.ToInt32(Console.ReadLine());

bool GetTriangle (int one, int two, int tree)
{
    if  (one + two > tree && two + tree > one && one + tree > two)
    {
        return true;
    }
    else return false;

}

Console.WriteLine(GetTriangle(oneNum, twoNum, treeNum) ? "Такой треугольник может существовать" : "Такой треугольник не может существовать");