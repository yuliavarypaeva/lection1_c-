// Задача 28: Напишите программу, которая принимает на 
//вход число M и N и выдаёт произведение чисел от M до N.
// 2,4 -> 24
// 1,5 -> 120

int GetMultNum(int value, int mult)
{
    // if(mult ==0 || value == 0) если = 0
    // {
    //     return 0;
    // }

    int spamValue = 1;
    for(int i = value; i <= mult; i++)
    {
        spamValue *=i;
    
    }
    return spamValue;
}

Console.WriteLine($"Произведение чисел равно {GetMultNum(2, 4)}");
Console.WriteLine($"Произведение чисел равно {GetMultNum(1, 5)}");