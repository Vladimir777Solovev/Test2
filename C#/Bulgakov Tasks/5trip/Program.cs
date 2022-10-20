// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int count = -number;
while (count <= number)
{
    Console.Write($"{count} ");
    count++;
    // count = count +1;
}
