// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.

Console.Write("Введите первое натуральное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int direction = 0;
if (numberM < numberN)
    direction = 0;
else
    direction = 1;

void NumbersNToM(int numb1, int numb2)
{
    if (direction == 1)
    {
        if (numb1 >= numb2)
        {
            Console.Write($"{numb1} ");
            NumbersNToM(numb1 - 1, numb2);
        }
    }
    else
    {
        if (numb1 <= numb2)
        {
            Console.Write($"{numb1} ");
            NumbersMtoN(numb1 + 1, numb2);
        }
    }
}

void NumbersMtoN(int numb1, int numb2)
{
    if (numb1 <= numb2)
    {
        Console.Write($"{numb1} ");
        NumbersMtoN(numb1 + 1, numb2);
    }
}

NumbersNToM(numberM, numberN);

// if (numberM > numberN)
// NumbersNToM(numberM, numberN);
// else
// NumbersMtoN(numberM, numberN);