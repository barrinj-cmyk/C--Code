// Question 1
/*
int one = Convert.ToInt32(Console.ReadLine());
int two = Convert.ToInt32(Console.ReadLine());
if (one == two)
{
    Console.WriteLine("The strings are equal");
}
else
{
    Console.WriteLine("The strings are not equal");
}
*/

//Question 2
/*
int even = Convert.ToInt32(Console.ReadLine());
if (even % 2 == 0)
{
    Console.WriteLine("The number is even");
}
else
{
    Console.WriteLine("The number is odd.");
} 
*/

//Question 3
/*
int year = Convert.ToInt32(Console.ReadLine());
if (year % 400 == 0)
{
    Console.WriteLine("Leap year");
}
else if (year % 4 == 0 && year % 100 != 0)
{
    Console.WriteLine("Leap year");
}
else
{
    Console.WriteLine("Not a leap year.");
}
*/

//Question 4
/*
Console.WriteLine("Enter an integer:");
int fizzbuzz = Convert.ToInt32(Console.ReadLine());
if (fizzbuzz % 3 == 0)
{
    Console.Write("Fizz");
}
if (fizzbuzz % 5 == 0)
{
    Console.Write("Buzz");
}
else
{
    Console.WriteLine($"{fizzbuzz}");
}
*/

//Question 5
/*
Console.WriteLine("Enter an integer:");
int interger = int.Parse(Console.ReadLine());

static int Factors(int factor)
{
    int n = 1;
    int count = 0;
    while (n <= factor)
    {
        if (factor % n == 0)
        {
            count += 1;
        }
        n += 1;
    }
    return (count);

}
Console.WriteLine($"The interger {interger} has {Factors(interger)} factors.");
*/


//Question 6
/*
Console.WriteLine("Enter a letter:");
string letter = Console.ReadLine();
switch (letter)
{
    case("a"):
        Console.WriteLine("True");
        break;
    case ("e"):
        Console.WriteLine("True");
        break;
    case ("i"):
        Console.WriteLine("True");
        break;
    case ("o"):
        Console.WriteLine("True");
        break;
    case ("u"):
        Console.WriteLine("True");
        break;
    default:
        Console.WriteLine("False");
        break;
}
*/

//Question 7
/*
Console.WriteLine("Enter the file size in KiB:");
double size = double.Parse(Console.ReadLine());
double BLOCK = 0.5;

Console.WriteLine($"You need to use {Math.Ceiling((size / BLOCK))} blocks.");
*/

//Question 8