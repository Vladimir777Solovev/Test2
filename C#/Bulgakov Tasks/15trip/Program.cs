﻿// 1. вход случайное трехзначное число
// 2. удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
int number = new Random().Next(100,1000);
Console.WriteLine($"Случайное число от 100 до 999: {number}");
int firstDigit = number / 100;
Console.WriteLine($"1 цифра: {firstDigit}");
//int secondDigit = number / 10;

int fithDigit = number % 10;
Console.WriteLine($"3 цифра: {fithDigit}");

int result = firstDigit*10 + fithDigit;
Console.WriteLine($"вывод: {result}");
