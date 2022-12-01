// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Clear();

Console.WriteLine("Введите значение для b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение для k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение для b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение для k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double FindX(double b1, double b2, double k1, double k2)
{
    double x = (b2 - b1) / (k1 - k2);

    return x;
}

double EduationY1(double k1, double b1)
{
    double x = FindX(b1, b2, k1, k2);
    double y = k1 * x + b1;
    return y;
}

double EduationY2(double k2, double b2)
{
    double x = FindX(b1, b2, k1, k2);
    double y1 = k2 * x + b2;
    return y1;
}

double eduationY1 = EduationY1(k1, b1);
double eduationY2 = EduationY2(k2, b2);
Console.Write($"Точка пересечений: ({eduationY1}; {eduationY2})");