// Задача 64: Задайте значения M и N.
//  Напишите программу, которая выведет все чётные натуральные 
//  числа в промежутке от M до N с помощью рекурсии.

// M = 1; N = 5 -> 2, 4
// M = 4; N = 8 -> 4, 6, 8

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
void NaturalEvenToLow(int m, int n)
{
 if (m > n)
 return;
 if (m % 2 == 0)
 {
  Console.Write($"{m}");
  Console.Write(m >= n - 1 ? "." : ", ");
 }
NaturalEvenToLow(m + 1,n);

}
NaturalEvenToLow(m,n);