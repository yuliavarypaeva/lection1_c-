//Напишите программу, которая принимает на вход число M и N 
//и выдаёт произведение чисел от M до N.

int MultNum(int a, int b)
{
int result;
int i;
result = 1;
for (i = a; i <= b; i++)
{
result = i * result;
}

return result;
}

int n;
int m;
Console.Clear();
Console.Write("введите число n ");
n = int.Parse(Console.ReadLine());
Console.Write("введите число m ");
m = int.Parse(Console.ReadLine());
Console.WriteLine($"произведение чисел от {Math.Min(n, m)} до {Math.Max(n, m)} = {MultNum(Math.Min(n, m), Math.Max(n, m))}");