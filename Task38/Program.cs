// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {

        // arr[i] = Math.Round(3.45, 1, MidpointRounding.AwayFromZero);
        arr[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
    }
    return arr;
}


void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");

}

double DifMaxMinNumbers(double[] arr)
{
    double dif = 0;
    double max = 0;
    double min = 0;
    max = min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];

    }
    return dif = max - min;
}

double[] array = CreateArrayRndDouble(5, 1, 100);
PrintArray(array);

double difMaxMinNumbers = DifMaxMinNumbers(array);

Console.WriteLine($"Разница равна: {difMaxMinNumbers}");