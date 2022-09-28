Console.Clear();
int count = 10;
int [] array = new int [count];
int find = new Random().Next(1, 21);
int index = 0;
Console.Write("find = ");
Console.WriteLine(find);
Console.Write("Massive ");

while (index < count)
{
    array[index] = new Random().Next(1, 22);
    Console.Write(array[index] + " ");
    index = index + 1;
}

index = 0;
bool element = false;
while(index < count)
{
    if(array[index] == find)
    {
        element = true;
    }
index = index + 1;
}
if (element  == true)
{
    Console.WriteLine("\nExist");
}
else
{
Console.WriteLine("\nNot Exist");
}

Console.WriteLine("\nEnd");