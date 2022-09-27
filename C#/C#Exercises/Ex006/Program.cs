Console.Write("Enter your name ");
string username = Console.ReadLine();

if(username.ToLower() == "vladimir")
{
    Console.WriteLine("Ave Caesar, Morituri te salutante");
}
else
{
    Console.Write("Kneel before your Emperor, ");
    Console.Write(username);
}