Console.Title = "26/05/22";
Console.WriteLine("Codewars questions");
Console.WriteLine("\n");

//1
//Create a function that gives a personalized greeting. This function takes two parameters: name and owner.

//Use conditionals to return the proper message:

//case	return
//name equals owner	'Hello boss'
//otherwise	'Hello guest'


//static string Greet(string name, string owner)
//{
//    string ownerGreeting = "Hello boss";
//    string guestGreeting = "Hello guest";
//    if (name == owner)
//    {
//        Console.WriteLine(ownerGreeting);
//        return ownerGreeting;
//    }
//    else Console.WriteLine(guestGreeting);
//        return guestGreeting;
//}


static string Greet(string name, string owner)
{
    return (name == owner) ? "Hello boss" : "Hello guest";
}


//2

//There was a test in your class and you passed it. Congratulations!
//But you're an ambitious person. You want to know if you're better than the average student in your class.

//You receive an array with your peers' test scores. Now calculate the average and compare your score!

//Return True if you're better, else False!

//my code

//Console.WriteLine(BetterThanAverage(new double[] { 12, 32, 32, 43, 23, 132, }, 100));

//static bool BetterThanAverage(double[] ClassPoints, int YourPoints)
//{
//    double average = ClassPoints.Average();
//    return (average < YourPoints) ? true : false;
//}

//short hand

static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
{
    //.Average()
    return YourPoints > ClassPoints.Average();
}

//3
//Given a non-negative integer, 3 for example, 
//return a string with a murmur: "1 sheep...2 sheep...3 sheep...".
//Input will always be valid, i.e. no negative integers.

static string CountSheep(int n)
{
    string result = "";
    for (int i = 1; i <= n; i++)
    {
        result += $"{i} sheep...";
    }
    return result;
}

Console.WriteLine(CountSheep(10));