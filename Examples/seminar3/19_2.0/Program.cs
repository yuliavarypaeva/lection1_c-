Console.Clear();

Console.WriteLine("Введите координаты точки А:");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки В:");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());

double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine(length);