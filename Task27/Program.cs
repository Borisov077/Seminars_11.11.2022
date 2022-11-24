// Напишите программу, которая принимает 
// 1.на вход число и 
// 2.выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int number = -1;
while (number < 1)
{
    Console.WriteLine("Введите число: ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number < 1) Console.WriteLine("Введеные неверные данные");
}

int SumDigit(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;

}

int sumDigit = SumDigit(number);
Console.WriteLine($"Сумма  числа {number} = {sumDigit}");

