// // Написать программу преобразования десятичного числа в двоичное

// void PrintArray(int [] array)
// {
//    foreach(int element in array)
//    {
//     Console.Write($"{element}");
//    }
//    Console.WriteLine();
// }

// Console.WriteLine ("enter number:");
// int number=int.Parse(Console.ReadLine() ?? "0");
// int i=0;

// if (number>0)
// {
//    while (number>0)
//    {
//     int number2=number%2;
//     number=number/2;
//     i++;
//    }
//    int [] array=new int [i];
//   int count=i-1;

//     while (number>0)
//     {
//       int number3=number%2;
//       number=number/2;
//       array [count]=number3;
//       count--;
//     }
//  Console.Write ($" в двоичной =");
//  PrintArray(array);
// }
// else
// {
// Console.Write ($" в двоичной =0");
// }
// НЕ РАБОТАЕТ

Console.Write("Введите число: ");
int chislo = int.Parse(Console.ReadLine() ?? "0");
double result = 0;
int i = 0;
while (chislo != 0)
{
    result = result + (chislo % 2 * Math.Pow(10, i));
    chislo = chislo / 2;
    i++;
}
Console.WriteLine(result);

//2 решение не работает

// Console.Write("Введите число: ");
// int number= int.Parse(Console.ReadLine() ?? "0");
// string result=string.Empty;
// string.output=string.Empty;
// while (number !=0)
// {
//   result=result+number%2;
//   number=number/2;
// }

// for (int i=result.Lenght-1;i>=0;i--)
// {
//    output +=result[i];

// }
// Console.WriteLine(output);