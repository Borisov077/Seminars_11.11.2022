// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка {number}");

int ShowDigitsSecond(int num)
{
    int firstDigit = number / 10;
    int secondDigit = number % 100 / 10;
    return secondDigit;
}
Console.WriteLine("Показывает вторую цифру");
Console.WriteLine($"Результат = {ShowDigitsSecond(number)}");