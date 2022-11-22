﻿// Напишите программу, которая
// принимает на вход число (А) и 
// выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigit(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }

    return sum;
}
if (number > 0)
{
    int sumDigit = SumDigit(number);
    Console.WriteLine($"Сумма чисел от 1 до {number} = {sumDigit}");
}
else Console.WriteLine("Требуется ввести натуральное число");
