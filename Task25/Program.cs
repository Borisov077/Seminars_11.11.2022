// 1. Напишите цикл, который принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите число A:");
int nA = Convert.ToInt32(Console.ReadLine());
int nB = -1;
while (nB < 1)
{
    Console.WriteLine("Введите натуральное число B:");
    nB = Convert.ToInt32(Console.ReadLine());
    if (nB < 1) Console.WriteLine("Введеные неверные данные");
}
int ErectDigits(int A, int B)
{
    int res = 1;
    for (int i = 1; i <= nB; i++)
    {
        res = res * nA;
    }
    return res;
}
int erectDigits = ErectDigits(nA, nB);
Console.WriteLine($"Возводит число {nA} в степень {nB} = {ErectDigits(nA, nB)}");

