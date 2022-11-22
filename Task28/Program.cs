// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int MultDigit(int num)
{
    int mult = 1;
    for (int i = 1; i <= num; i++)
    {
        mult = mult * i;
    }

    return mult;
}
if (number > 0)
{
    int multDigit = MultDigit(number);
    Console.WriteLine($"Сумма чисел от 1 до {number} = {multDigit}");
}
else Console.WriteLine("Требуется ввести натуральное число");