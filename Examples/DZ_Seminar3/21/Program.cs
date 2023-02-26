﻿// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double GetRangeCord (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double xpow = Math.Pow(Convert.ToDouble(x1 - x2), 2);
    double ypow = Math.Pow(Convert.ToDouble(y1 - y2), 2);
    double zpow = Math.Pow(Convert.ToDouble(z1 - z2), 2);
    double xysqrt = Math.Sqrt(xpow + ypow + zpow);

    return Math.Round(xysqrt, 2, MidpointRounding.ToZero);
}

Console.WriteLine($"Расстояние между точками {GetRangeCord(3, 6, 8, 2, 1, -7)}");

Console.WriteLine($"Расстояние между точками {GetRangeCord(7, -5, 0, 1, -1,9)}");