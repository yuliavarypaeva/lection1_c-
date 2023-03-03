// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = FillArray(4,-99,99);


Console.WriteLine($"В массиве: [{string.Join(" ", array)}] сумма элементов, стоящих на нечётных позициях равна {GetSumOddElem(array)}");

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

int GetSumOddElem(int[] Array)
{
    int sum = 0;
    for (int i = 1; i < sizeof(int); i +=2)
    sum = sum + Array[i];
    return (sum);
}
