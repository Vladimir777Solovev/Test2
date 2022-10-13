// Задача 2: Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine("Напишите два числа чтобы узнать какое из них большее а какое меньшее");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
int min = number2;

if (number1 > max) max = number1;
else
{
    max = number2;
}
Console.WriteLine($"Максимальное число = {max}");

if (number2 < min) min = number2;
else
{
    min = number1;
}
Console.WriteLine($"Минимальное число = {min}");