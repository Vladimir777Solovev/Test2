Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = num1%num2;
if (result>0)
{
    Console.WriteLine($"Не кратное. Остаток от деления: {result}");
} 
else
{
    Console.WriteLine($"Числа кратны.");
}
