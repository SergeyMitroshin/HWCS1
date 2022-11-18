// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("введите первое число");
int num1 = int.Parse (Console.ReadLine());
Console.WriteLine("введите второе число");
//int num2 = int.Parse(Console.ReadLine());
int num2 = 3;
if  (num1 > num2)
{
    Console.WriteLine("max = " + num1);
}
else
{
    Console.WriteLine ("max = " + num2);
}




// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
