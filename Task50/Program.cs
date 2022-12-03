//  Напишите программу, 
//  1.которая на вход принимает позиции элемента в двумерном массиве, 
//  2. и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите номер элемента строки: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер элемента стобца: ");
int columns = Convert.ToInt32(Console.ReadLine());


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

void ChekingArray(int[,] matrix)
{
    if (rows < matrix.GetLength(0) || columns < matrix.GetLength(1))
    {
        Console.WriteLine($"Элемент есть и это:  {matrix[rows, columns]}");
    }
    else
    {
        Console.WriteLine("Такого элемента нет в массиве!");
    }

}

int[,] array = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array);
Console.WriteLine();
ChekingArray(array);
