﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Write("Введите числа через запятую: ");
int[] numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {sum}");





void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}


// // Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1 y = k2 * x + b2 значения b1, k1, b2 и k2 задаются пользователем.


// Console.WriteLine("Введите значение b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите значение b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число k2:");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double x = (-b2 + b1)/(-k1 + k2);
// double y = k2 * x + b2;

// Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}, Y: {y}");