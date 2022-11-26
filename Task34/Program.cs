// 1.Задайте массив заполненный случайными 
// положительными трёхзначными числами. 
// 2.Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");

}

int EvenNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;

    }
    return count;
}

int[] array = CreateArrayRndInt(10, 100, 1000);
PrintArray(array);

int evenNumber = EvenNumber(array);
if (evenNumber > 0) Console.WriteLine($"Количество четных чисел в массиве равна: {evenNumber}");
else Console.WriteLine("Четных чисел в массиве нет");