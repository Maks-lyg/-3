Console.WriteLine("Введите 1 числа");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 3 число");
int a = int.Parse(Console.ReadLine());
int max = x;
if (max < y);
{
     max = y;
}
if (max < a);
{
    max = a;
}
Console.WriteLine("Большее число:  " +max);