// Написать программу преобразования десятичного числа в двоичное

void PrintArray(int [] array)
{
   foreach(int element in array)
   {
    Console.Write($"{element}");
   }
   Console.WriteLine();
}

Console.WriteLine ("enter number:");
int number=int.Parse(Console.ReadLine() ?? "0");
int [] array=new int [number];
int i=0;

if (number%2==0)
{
   while (number>0)
   {
    int number2=number%2;
    number=number/2;
    i++;
   }
}
else
{
    while (number>0)
    {
      int number2=number%2;
      number=number/2;
      array [i]=number2;
      i++;
    }
}    
Console.Write ($" в двоичной =");
PrintArray(array);
