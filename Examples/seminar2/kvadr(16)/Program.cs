// Напишите программу, которая принимает на вход два числа 
// и проверяет, является ли одно число квадратом другого
// 5,25 да
// -4,16 да
// 25,5 да
// 8,9 нет

Console.WriteLine("Введите число №1 ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число №2 ");
int number2 = int.Parse(Console.ReadLine());

//if (number1 * number1 == number2 || number2 * number2 == number1)
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");
// }


if (number1 * number1 == number2)
{
    Console.WriteLine($"{number2} квадрат {number1}");
    return;
}
if (Math.Pow(number2, 2) == number1)
{
    Console.WriteLine($"{number1} квадрат {number2}");
}
else
{
  Console.WriteLine("не является");
}