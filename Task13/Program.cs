// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ThirdDigit(number));

int ThirdDigit(int num)

{
    if (num < 100) Console.WriteLine("Третьей цифры нет");
    while (num > 999) num = num / 10;
    return num = num % 10;

}





