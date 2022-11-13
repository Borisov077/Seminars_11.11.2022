// 1. Напишите программу, которая на вход принимает два 
// числа и проверяет, является ли первое число квадратом 
// второго.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да

Console.WriteLine("Введите первое целое  число");
int number1 = Convert.ToInt32(Console.ReadLine());
int square1 = number1 * number1;

Console.WriteLine("Введите второе целое  число");
int number2 = Convert.ToInt32(Console.ReadLine());
int square2 = number2 * number2;

if (square1 == square2)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("нет");
}