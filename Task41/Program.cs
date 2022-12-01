// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();

Console.WriteLine("Введите числа (через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int NumberPositiv(int[] arr)
{
    int numb = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) numb++;
    }
    return numb;
}
int numb = NumberPositiv(arr);
Console.WriteLine($"Пользователь ввел цифр больше 0: {numb}");
