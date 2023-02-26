//Напишите программу, которая будет принимать
//на вход два числа и выводить, является
//ли второе число кратным первому. Если число 2
//не кратно числу 1, то программа выводит остаток от деления
//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно
Console.WriteLine("Введите число №1 ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число №2 ");
int number2 = int.Parse(Console.ReadLine());

int num = number1 % number2;

if(num > 0)
{
    Console.WriteLine($"не кратно, остаток {num}");
}
else
{
    Console.WriteLine("кратно");  
}