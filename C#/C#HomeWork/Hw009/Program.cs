﻿// Задача 8: Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите начальное число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите крайнее число: ");
        int b = Convert.ToInt32(Console.ReadLine());
        for (int count = a; count <= b; count++)
        {
            if (count % 2 == 0) 
            {
                Console.WriteLine($"Диапазон чисел: {count}");
            }

        }