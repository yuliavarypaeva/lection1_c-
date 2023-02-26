// Задача 26: Напишите программу, которая принимает на вход число и 
// выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
int GetLenghtNumberToStr(int value) 
{
    string spamNumber = value.ToString();
    return spamNumber.Length;
}
int GetLenghtNumberMath(int value)
{
    if( value == 0)
    {
        return 1;
    }
    
    int count = 0;
    for(int i = 0; value >= 1; i++)
    {
        value /= 10;
        count++;
    }
    return count;
}
int[] arrNums = new int[] {456, 78, 89126, 100, 0, 11};
Console.WriteLine($"Метод строк");
foreach (int num in arrNums)
{
    Console.WriteLine($"Длина числа {num}, равна {GetLenghtNumberToStr(num)}.");
}
Console.WriteLine($"");
Console.WriteLine($"Метод математики");
foreach (int num in arrNums)
{
    Console.WriteLine($"Длина числа {num}, равна {GetLenghtNumberMath(num)}.");
}