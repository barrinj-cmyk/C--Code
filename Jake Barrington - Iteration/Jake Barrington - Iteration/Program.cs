// Question 1
using System.Configuration.Assemblies;
using System.Runtime.CompilerServices;

static void Countdown(int num){
    int count = 0;
    while (count <= num){
        Console.WriteLine($"{num - count}");
        ++count;
    }
    Console.WriteLine("Blastoff!");
}


//Question 2
static void triangle(int layers){
    int count = 1;
    while (count <= layers){
        for (int i = 1; i <= count; ++i){
        Console.Write("*");
        }
    ++count;
    Console.WriteLine("\n");
    }
}

// Question 3 & 4

static void Grid(int rows, int columns)
{
    for (int i = 1; i <= rows; ++i)
    {
        for (int x = 1; x <= columns; ++x)
        {
            Console.Write("╋━━━");
        }
        Console.Write("╋\n");

        for (int y = 1; y <= columns; ++y)
        {
            Console.Write("┃   ");
        }
        Console.Write("┃\n");
    }
    for (int i = 1; i <= columns; ++i)
    {
        Console.Write("╋━━━");
    }
    Console.Write("╋\n");
}

// Question 5

static void Menu()
{
    Console.WriteLine("┌────┬─────────────┐\n│ #  │ Question    │\n├────┼─────────────┤\n│ 1  │ Question 1  │\n│ 2  │ Question 2  │\n│ 3  │ Question 3  │\n│ 4  │ Question 4  │\n│ 5  │ Question 5  │\n│ 6  │ Question 6  │\n│ 7  │ Question 7  │\n│ 8  │ Question 8  │\n│ 9  │ Question 9  │\n│ 10 │ Question 10 │\n│ 11 │ Question 11 │\n│ 12 │ Question 12 │\n│ 13 │ Question 13 │\n└────┴─────────────┘\n\nSelect a question to run (1-13):");
    int question = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter term 1 (0 if non applicable.)");
    int term1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter term 1 (0 if non applicable.)");
    int term2 = Convert.ToInt32(Console.ReadLine());

    switch (question)
    {
        case 1:
            Countdown(term1);
            break;
        case 2:
            triangle(term1);
            break;
        case 3:
            Grid(term1, term2);
            break;
        case 4:
            Grid(term1, term2);
            break;
        case 6:
            Ask(term1);
            break;
        default:
            Console.WriteLine("This question hasn't been implemented yet.");
            break;
    }
}

// Question 6

static void Ask(double n)
{
    double total = 0;
    for (double i = 1; i <= n; ++i)
    {
        total = total + Convert.ToDouble(Console.ReadLine());
    }
    Console.WriteLine($"The total is {total} and the mean is {total / n}.");
}

// Question 7

static bool isPrime(int n)
{
    int a = 1;
    int count = 0;
    while (a <= n)
    {
        if (n % a == 0)
        {
            count += 1;
        }
        a += 1;
    }
    if (count == 2)
        return true;
    return false;
}
/*
static bool isPerfect(int n)
{
    
}

static bool isAbundant(int n)
{

}

static bool isFriendly(int n, int p)
{
    
}
*/

Menu();