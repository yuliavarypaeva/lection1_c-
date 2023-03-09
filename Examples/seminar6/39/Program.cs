﻿// Задача 39: Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

Console.Clear();

int[] array = FillArray(5,1,10);

Console.WriteLine($"Исходный массив:     [{string.Join(",",array)}]");
Console.WriteLine($"Перевёрнутый массив: [{string.Join(",",ReverseArray(array))}]");

int[] FillArray(int size,int min,int max){
    int [] result = new int[size];
    Random rnd = new Random();
    for(int i = 0; i< result.Length ; i++){
        result[i] = rnd.Next(min,max+1);
    } 
    return result;
}

int[] ReverseArray(int[] array){
    int[] result = new int[array.Length];
    for(int i = 0;i<array.Length;i++){
        result[i] = array[array.Length - 1 - i];
    }
    return result;
}