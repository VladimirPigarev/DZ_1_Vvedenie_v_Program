// Задача № 6. Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли она на 2 без остатка)

using static System.Console;
Clear();

WriteLine("Введите число");
int n = Convert.ToInt32(ReadLine());
if (n % 2 == 0)
{
    WriteLine("Число делится на два без остатка");
}
else
{
    WriteLine ("Число является нечетным");
}