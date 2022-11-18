// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

string st = "";
Console.WriteLine("Введите число");
int num1 = int.Parse (Console.ReadLine());
for (int i = 2; i <= num1; i+=2)
{
    st = st + i + ", ";
}
st = st.Substring(0, st.Length - 2); //убираем запятую и пробел в конце
Console.WriteLine(st);