// Задача 50. Напишите программу, которая на вход
// принимает индексы элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1,1 -> 9
// 1,7 -> элемента с данными индексами в массиве нет

Console.Write("Введите индекс строки: ");
int rowsPosition = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите индекс столбца: ");
int columnsPosition = Convert.ToInt32(Console.ReadLine()) - 1;
int n = 3; 
int m = 4; 
Random random = new Random();
int[,] arr = new int[n, m];
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
     {
      arr[i, j] = random.Next(1, 9);
      Console.Write("{0} ", arr[i, j]);
     }
       Console.WriteLine();
}
if (rowsPosition < 0 | rowsPosition > arr.GetLength(0) - 1 | columnsPosition < 0 | columnsPosition > arr.GetLength(1) - 1)
 {
 Console.WriteLine("Элемента с данными индексами в массиве нет");
}
else
 {
 Console.WriteLine("Значение элемента массива = {0}", arr[rowsPosition, columnsPosition]);
 }