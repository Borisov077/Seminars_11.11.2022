﻿// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

/ Инициализация массива с числами
int[] array = { 3, 2, 1 };

int temp;
// array.Length здесь из-за того, что последний элемент необходимо исключить из проверки, так как его не с чем сравнивать ;)
for (int i = 0; i < array.Length - 1; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        Console.WriteLine("================================================================================");
        Console.WriteLine($"Новая итерация; i = {i}, j = {j}");
        Console.WriteLine($"Текущее состояние массива: {String.Join(",", array)}");
        Console.WriteLine($"Операция - сравнение {i}-го ({array[i]}) и {j}-го ({array[j]}) элементов массива");
        if (array[i] > array[j])
        {
            Console.WriteLine($"{array[i]} больше {array[j]}, сохраняем большее значение во временную переменную temp");
            temp = array[i]; // переменная temp была объявлена до цикла, предназначена для сохранения большего значения
            array[i] = array[j]; // присваиваем большему значению меньшее
            Console.WriteLine($"{i}-й элемент массива теперь имеет значение {j}-го; array[{i}] ({array[i]}) теперь равно array[{j}] ({array[j]})");
            array[j] = temp; // присваиваем меньшему значению большее, которое было сохранено нами в переменной temp
            Console.WriteLine($"{j}-й элемент массива теперь имеет значение {i}-го; array[{j}] ({array[j]}) теперь равно array[{i}] ({array[i]})");
            Console.WriteLine($"Состояние массива после смены мест: {String.Join(",", array)}");
        }
        else
        {
            Console.WriteLine($"{array[i]} не больше {array[j]}, переходим к следующей итерации");
        }
    }
}

// Вывод отсортированного массива
Console.WriteLine("================================================================================");
Console.WriteLine("Итоговый вариант отсортированного массива");
foreach (int i in array)
{
    Console.WriteLine(i);
}