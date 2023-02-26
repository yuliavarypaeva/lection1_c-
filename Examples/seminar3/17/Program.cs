// Напишите программу, которая принимает на вход 
// координаты точки (x и y), причем x не равно 0 и y не равно 0
// и выдает номер четверти плоскости, в которой находится эта точка

Console.WriteLine("Введите X:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y:");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0)
{
    ConsoleWriteLine("1 четверть");
}
else if (x < 0 && y > 0)
{
    ConsoleWriteLine("2 четверть");
}
else if (x < 0 && y < 0)
{
    ConsoleWriteLine("3 четверть");
}
else if (x > 0 && y < 0)
{
    ConsoleWriteLine("4 четверть");
}
else
    Console.WriteLine("Четверть не определена");