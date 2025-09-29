// question 1
/* Console.WriteLine("Enter minutes");
string minutes = Console.ReadLine();
int mins = Convert.ToInt32(minutes);
Console.WriteLine("Enter seconds");
string seconds = Console.ReadLine();
int secs = Convert.ToInt32(seconds);
int meterspersecond = 10000 / ((mins * 60) + secs);
double milesperhour = (float)meterspersecond * 2.23694;
Console.WriteLine($"Speed is {meterspersecond} m/s or");
Console.Write($" {milesperhour} mph"); */

// question 2
/* Console.WriteLine("Enter number");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
int count2 = 1;
while (count2 <= n)
{
    while (count <= n)
    {
        Console.Write($"{count * count2} ");
        count += 1;
    }
    Console.WriteLine("");
    count2 += 1;
    count = 0;
}*/

// Question 3

Console.WriteLine("Radius:");
int radius = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The circumrence is {2 * Math.PI * radius} and the area is {Math.PI * radius * radius}");

