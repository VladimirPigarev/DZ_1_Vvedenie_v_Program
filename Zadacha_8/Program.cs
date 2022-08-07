// Задача № 8. Напишите программу, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N.

using static System.Console;
Clear();
WriteLine("Введите число");
int n = Convert.ToInt32(ReadLine());
int i = 1;
while(i <= n)
{
    if (i % 2 == 0)
    {
        WriteLine(i);
    }
i++;
}
