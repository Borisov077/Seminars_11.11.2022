// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-00 --> {number}");
// int firstDigit = number / 10;
// int seconDigit = number % 10;

// if (firstDigit > seconDigit) Console.WriteLine($"Наибольшая цифра числа --> {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа --> {seconDigit}");

int MaxDigit(int num) // int nun = number
{
    int firstDigit = number / 10;
    int seconDigit = number % 10;
    // if (firstDigit > seconDigit) return firstDigit;
    // return seconDigit;

    // int max = firstDigit > seconDigit ? firstDigit : seconDigit;
    // return max;
    return firstDigit > seconDigit ? firstDigit : seconDigit;
}

int maxDigit = MaxDigit(number); // методы с большой буквы пишутся, ПЕРЕМЕННЫЫЕ С МАЛЕНЬКОЙ
Console.WriteLine($"Наибольшая цифра числа --> {maxDigit}");


