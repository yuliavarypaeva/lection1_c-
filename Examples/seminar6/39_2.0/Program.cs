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
    int temp = 0;
    for(int i = 0;i<array.Length / 2;i++){
        temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return array;
}