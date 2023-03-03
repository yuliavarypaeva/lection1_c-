// Задача 34: Задайте массив заполненный случайными положительными
//  трёхзначными числами. Напишите программу, которая покажет
//   количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = FillArray(4,100,999);
Console.WriteLine($"В массиве: [{string.Join(" ", array)}] количество четных чисел равно {GetEvenNumbersByArray(array)}");

int[] FillArray(int size, int min, int max)
{
    int[] result = new int[size];

    Random rnd = new Random();
    
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(min,max + 1);
    }
    return result;
}

int GetEvenNumbersByArray(int[] inputArray)
{
    int result = 0;
    foreach(int element in inputArray)
    {
        if(element % 2 == 0) 
             result += 1;
    }
    return result;
}