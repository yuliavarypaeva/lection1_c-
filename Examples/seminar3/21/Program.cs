// // Напишите программу, которая принимает на вход число (N) 
// и выдает таблицу квадратов чисел от 1 до N

// 5-> 1, 4, 9, 16, 25
// 2-> 1, 4

void GetPowTableN (int value)
{
    for (int i = 1; i <= value; i++)
{
    Console.Write($"{Math.Pow(i, 2)}");
    if (i < value)
    {
        Console.Write($", ");
    }
}
  Console.WriteLine(".");
}

GetPowTableN(5);
GetPowTableN(2);