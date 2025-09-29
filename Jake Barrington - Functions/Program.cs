// Question 1
/*
static int Addition(int a, int b)
{
    return a + b;
}
*/


static double Addition(double a, double b)
{
    return a + b;
}


/*
static decimal Addition(decimal a, decimal b)
{
    return a + b;
}
*/

//Question 2

int IndividualAddition(int a)
{
    return a.ToString().Sum(c => c - '0');
}


//Question 3

static bool IsPrime(int a)
{
    int n = 1;
    int count = 0;
    while (n <= a)
    {
        if (a % n == 0)
        {
            count += 1;
        }
        n += 1;
    }
    if (count == 2)
        return true;
    return false;

}


//Question 4

static int NumSpaces(string inp)
{
    return inp.Count(f => f == ' ');
}


//Question 5

static void Swap(ref int a, ref int b)
{
    int n = a;
    a = b;
    b = n;
}

int i1 = 7;
int i2 = 9;
Swap(ref i1, ref i2);


// Question 6

static string Base(int num, int Base)
{
    return Convert.ToString(num, Base);
}

//Question 7 

static void TimesTable(int x, int y)
{
    int count = 1;
    int count2 = 1;
    while (count2 <= y)
    {
        while (count <= x)
        {
            Console.Write($"{count * count2} ");
            count += 1;
        }
        Console.WriteLine("");
        count2 += 1;
        count = 1;
    }
    return;
}

