Console.WriteLine("Enter the num: ");
int num = Convert.ToInt32(Console.ReadLine());

int firstNum = num / 100;
int lastNum = num % 10;

int res = firstNum * 10 + lastNum;

Console.WriteLine(res);
