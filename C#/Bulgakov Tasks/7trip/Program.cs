Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());


int lastDigit = number % 10; // 456 % 10 = 6    456 / 10 = 45 / 10 = 4 / 10 = 0
Console.WriteLine($"Последняя цифра числа = {lastDigit}");
