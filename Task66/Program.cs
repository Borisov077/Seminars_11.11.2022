// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое натуральное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNaturalNumbers(int num1, int num2)
{
    if (num1 == num2) return num1;
    else if (num1 < num2) return num2 + SumNaturalNumbers(num1, num2 - 1);
    else return num2 + SumNaturalNumbers(num1, num2 + 1);
}

SumNaturalNumbers(numberM, numberN);
Console.WriteLine(SumNaturalNumbers(numberM, numberN));