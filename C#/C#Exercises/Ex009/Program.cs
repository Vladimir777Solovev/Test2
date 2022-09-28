Console.Clear();
int n = new Random().Next(10, 100);
Console.WriteLine("Hello!");
Console.WriteLine("We have a multiple numbers between 10 to 99. Need to find the biggest one of the one of qantity that we will receive");
Console.Write("The biggest number is ");
int a = n / 10;
int b = n % 10;

if (a < b)
{
    Console.Write(b);
}
else
{
    Console.Write(a);
}