// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100-999 --> {number}");

int KillsecondDigit(int num) // int nun = number
{
    int firstDigit = number / 100;
    int thirdDigit = number % 10;
    int result = firstDigit * 10 + thirdDigit;
    return result;
}
Console.WriteLine("Удаляем вторую цифру числа");
Console.WriteLine($"Результат = {KillsecondDigit(number)}");
