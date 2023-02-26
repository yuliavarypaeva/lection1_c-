// Задача 29: Напишите программу, которая задаёт 
//массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] arr = {1, 5, 4, 3, 2, 6, 7, 1};
void PrintArray(int[] array)
{
    Console.Write("[");
    int count = 0;
    int arrLenght = arr.Length;
    foreach(int num in arr)
    {
        count++;
        Console.Write($"{num}");

        if (count == arrLenght)
        {
            Console.Write("]");
        }
        else
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine();
}

PrintArray(arr);