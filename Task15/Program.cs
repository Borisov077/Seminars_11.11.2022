// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число и является этот день выходным: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Days(int num)
{
    return (number == 6 || number == 7);
}
Console.WriteLine(Days(number) ? "ДА" : "НЕТ");

