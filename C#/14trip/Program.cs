int MaxDigit(int num)
{
    int firstDigit = num / 10; // 78 / 10 = 7
    int secondDigit = num % 10; // 78 % 10 = 8
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа равна {maxDigit}");
