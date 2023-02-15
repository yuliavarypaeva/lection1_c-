// Задача 8: Напишите программу,
//которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Convert.ToInt32(Console.ReadLine());
for(int i = -number; i <= number; i++)
{
    Console.Write(i + ", ");
}
Console.WriteLine();