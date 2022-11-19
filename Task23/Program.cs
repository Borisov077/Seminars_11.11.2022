﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

int n = -1;
while (n < 1)
{
    Console.WriteLine("Введите число");
    n = Convert.ToInt32(Console.ReadLine());
    if (n < 1) Console.WriteLine("Введеные неверные данные");
}

string CubeTable(int n1)
{
    int count = 1;
    string table = "";
    while (count <= n1)
    {
        table = table + $"{count} | {count * count * count} \n";
        count++;
    }
    return table;
}

string cubeTable = CubeTable(n);
Console.WriteLine(cubeTable);