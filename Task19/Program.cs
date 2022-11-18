// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Palindrome(number);

int Palindrome(int num)
{
    int firstDigit = number / 1000;
    int secondDigit = number / 1000 % 10;
    int forsDigit = number / 10 % 10;
    int fiveDigit = number / 1 % 10;

    if (firstDigit == fiveDigit) ;
    else if (secondDigit == forsDigit)
    {
        Console.Write("ДА");
    }
    else
    {
        Console.Write("НЕТ");
    }
    return num;
}




