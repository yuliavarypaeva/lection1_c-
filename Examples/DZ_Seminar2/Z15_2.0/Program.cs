Console.WriteLine("Введите номер дня недели ");
int numberDayOfWeek = int.Parse(Console.ReadLine());

Console.WriteLine(numberDayOfWeek == 6 || numberDayOfWeek == 7 
? "да, это выходной" 
: "Нет");