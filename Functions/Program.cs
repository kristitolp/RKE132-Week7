Console.WriteLine("Are you coming or leaving? (in/out )");
string userChoice = Console.ReadLine();

if (userChoice == "in")
{
    PrintHello();
}
else
{
    PrintBye();
}




static void PrintHello() //funktsioon/meetod
{
    Console.WriteLine("Hello, world!");
}

static void PrintBye()
{
    Console.WriteLine("See you later, aligator!");
}