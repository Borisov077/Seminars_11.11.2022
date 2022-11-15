// Напишите программу, которая принимает на вход два числа
// и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write((Square(num1, num2)) ? "ДА" : "Нет");

bool Square(int firstNum, int secondNum)
{
    return (firstNum == secondNum * secondNum) || (secondNum == firstNum * firstNum);
}