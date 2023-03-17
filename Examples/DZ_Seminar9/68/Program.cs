// Задача 68: Задайте значения M и N. Напишите программу,
//  которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
// M = 28; N = 7 -> 7


Console.Write("Введите значение M: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int b = Convert.ToInt32(Console.ReadLine());

int gcd(int a, int b)
{
    while (b != 0)
        b = a % (a = b);
    return a;
}
Console.Write($"{}");