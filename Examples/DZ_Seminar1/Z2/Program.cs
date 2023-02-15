//Задача 2: Напишите программу,
// которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

Console.WriteLine("Введите число №1 ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число №2 ");
int number2 = int.Parse(Console.ReadLine());

if(number1 > number2)
{
    Console.WriteLine("Max = " + number1);
    Console.WriteLine("Min = " + number2);

}
else
{
    Console.WriteLine("Max = " + number2);
    Console.WriteLine("Min = " + number1);
    
}