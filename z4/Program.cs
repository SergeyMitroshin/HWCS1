// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("введите первое число");
int num1 = int.Parse (Console.ReadLine());
Console.WriteLine("введите второе число");
int num2 = int.Parse (Console.ReadLine());
Console.WriteLine("введите третье число");
int num3 = int.Parse (Console.ReadLine());
int maxv = 0;
if  (num1 > num2)  maxv = num1; else maxv = num2;
if  (num3 > maxv)  maxv = num3;
Console.WriteLine ("-> " + maxv);