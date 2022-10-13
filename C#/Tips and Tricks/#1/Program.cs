// View 1
void Method1()
{
    Console.WriteLine("Word...");
}

//Method1();








// View 2
void Method2(string msg)
{
Console.WriteLine(msg);
}
//Method2("Message Text");







//View 3
void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }

}
//Method21(msg: "Text", count: 4);
//Method21(count: 4, msg: "text");









//View 4

int Method3()
{
    return DateTime.Now.Month;
}

int Month = Method3();
//Console.WriteLine(Month);









