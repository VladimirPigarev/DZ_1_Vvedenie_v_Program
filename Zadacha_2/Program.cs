// Задача № 2 Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

using static System.Console;
Clear();

WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(ReadLine());
WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(ReadLine());

if(number1 > number2)
{
    WriteLine("Большее число " + (number1) + " Меньшее число " + (number2));
}
if(number2 > number1)
{
    WriteLine("Большее число " + (number2) + " Меньшее число " + (number1));
}
if(number1 == number2)
{
    WriteLine("Числа равны");
}