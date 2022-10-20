// // Задача 4: Напишите программу, которая принимает на вход три числа
//  и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Напишите три числа, чтобы узнать какое из них меньшее");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int min = number1;
if(number1 < min) min = number1;
if(number2 < min) min = number2;
if(number3 < min) min = number3;
Console.Write("Минимальное число = ");
Console.WriteLine(min);