// Выяснить являются ли три числа сторонами треугольника

Console.Write("enter storony 1: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("enter  storony 2: ");
int b = int.Parse(Console.ReadLine() ?? "0");
Console.Write("enter  storony 3 : ");
int c = int.Parse(Console.ReadLine() ?? "0");

if (a+b>c && b+c>a && c+a>b)
{
Console.Write(" it is triangle: ");
}
else
Console.Write("no triangle: ");