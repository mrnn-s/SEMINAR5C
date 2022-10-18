// Показать числа Фибоначчи меньшие чем заданное число N

Console.Write("Введите число: ");
int chislo = int.Parse(Console.ReadLine() ?? "0");
int fib1=1;
int fib2=1;
int fib3=1;
while(fib3<chislo)
{
    Console.Write($"{fib3} ");
    fib3=fib1+fib2;
    fib1=fib2;
    fib2=fib3;
}
// Console.WriteLine($"Количество чисел Фибоначчи: ");
// int N = int.Parse(Console.ReadLine() ?? "0");

// int[] array(int N)
// {
// int fibNum1 = 1;
// int fibNum2 = 1;

// int[] fib = new int[N];
// fib[0] = 1;
// fib[1] = 1;
// for (int i = 2; i < N ; i++)
// {
// fib[i] = fibNum1 + fibNum2;
// fibNum2 = fibNum1;
// fibNum1 = fib[i];
// }
// return fib;
// }

// void PrintArray(int[] arr)
// {
// for (int i = 0; i < arr.Length; i++)
// {
// Console.Write(arr[i] + " ");
// }
// Console.WriteLine();
// }

// PrintArray(array(N));
// Console.WriteLine();