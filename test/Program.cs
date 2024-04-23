//Console.WriteLine("Enter your comment:");
//string userInput = Console.ReadLine();

//CountSpaces(userInput);

//static void CountSpaces(string someString)
//{
//    someString = someString.Trim();
//    int wordCounter = 1;

//    foreach (char symbol in someString)
//    {
//        if (char.IsWhiteSpace(symbol))
//        {
//            wordCounter++;
//        }
//    }

//    string word = "word";
//    if (wordCounter > 1)
//    {
//        word = "words";
//    }

//    Console.WriteLine($"Your comment contains {wordCounter} {word}.");
//}




//  HelloWorld();

//static void HelloWorld()
//{
//    Console.WriteLine("Hello, World!");
//}






//Console.WriteLine("Enter your name:");
//string userName = Console.ReadLine();

//GreetUser(userName);

//static void GreetUser(string someName)
//{
//    Console.WriteLine($"Hello, {someName}");
//}



Console.WriteLine("How many steps have you walked today?");
int usersSteps = Int32.Parse(Console.ReadLine());

string result = HealthMonitor(usersSteps);

Console.WriteLine(result);

static string HealthMonitor(int steps)
{
    if (steps < 4000)
    {

        return "You need to move more.";
    }
    else if (steps >= 4000 && steps < 8000)
    {

        return "Health goal achieved,";
    }
    else
    {

        return "Well done!";
    }
}