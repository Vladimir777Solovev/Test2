int a = 5;
int b = 7;

int max = a;
int min = b;
if(a > max) max = a;
else max = b;
if(a < min) min = a;
else min = b;

Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);