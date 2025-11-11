﻿using System.Diagnostics;
using System.IO.Pipes;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

/* Fix me */
List<string> listOfStrings = new List<string> { "13", "Candy", "Mike Myers", "True", "#FF5F1F", "1978" };


Debug.Assert(NextOnAThursday() == 2031);

int NextOnAThursday()
{
    int year = 2025; // Sets the year 2025 as a starting point.
    while (true)
    {
        year++; // Increments the year by 1.
        DateTime dt = new DateTime(year, 11, 06); //Creates a Date Time object for 6th november for each year.
        if ((int)dt.DayOfWeek == 4)
        {
            return year; //Returns the year if 6th November is on a Thursday.
        }
    }
}

List<int> pileSizes = new List<int> { 4, 9, 11, 17 };
int numHours = 8;

static int EatingSweets(List<int> pileSizes, int numHours)
{
    int sph = 0; //sweets per hour set to 0
    while (true) //iterates through for different values of sweets per hour
    {
        int timeTaken = 0;
        sph++; //Increases sweets per hour by 1 each time
        foreach (int pile in pileSizes)
        {
            timeTaken += (int)Math.Ceiling((double)pile / sph); //Calculates time taken to eat each pile at current sweets per hour rate
        }
        if (timeTaken <= numHours)
        {
            return sph; //Returns sweets per hour if total time taken is within the allowed hours
        }
    }
}
Debug.Assert(EatingSweets(pileSizes, numHours) == 6);

static int CuttingChocolate(int cuts)
{
    int horizontalCuts = (int)Math.Round(cuts / 2.0); //Rounds to nearest whole number
    int verticalCuts = cuts - horizontalCuts;//Calculates the remainder
    return ((horizontalCuts) * (verticalCuts)); //Outputs the number of pieces

}

Debug.Assert(CuttingChocolate(5) == 6);
Debug.Assert(CuttingChocolate(6) == 9);
Debug.Assert(CuttingChocolate(7) == 12);
Debug.Assert(CuttingChocolate(8) == 16);

// Note the exclamation marks showing not, so False 
Debug.Assert(!ValidatePassword("ABCdef")); // too short
Debug.Assert(!ValidatePassword("ABCABC12!")); // duplicates, doesn't divide by 11
Debug.Assert(!ValidatePassword("ABCabcde!")); // no digit 
Debug.Assert(!ValidatePassword("ABCdef12!")); // doesn't divide by 11 
Debug.Assert(ValidatePassword("ABCdef12&")); // should succeed 


bool ValidatePassword(string candidate)
{
    //Checks length
    if (candidate.Length <= 8 || candidate.Length >= 32)
    {
        return false; // Password length is invalid
    }
    // Check for duplicate characters
    HashSet<char> hash = new HashSet<char>(); //Turns into a hashset
    foreach (char c in candidate)
    {
        if (!hash.Add(c)) //Adds each character to the hashset if not already present
        {
            return false; // Repeat character found
        }
    }
    //Checks for divisibility by 11
    int sum = 0;
    foreach (char c in candidate)
    {
        sum += (int)c; //Adds the asccii values of each character
    }
    if (sum % 11 != 0) //Checks if is divisible by 11
    {
        return false; // Sum of vals is not divisible by 11
    }
    // Check for at least one digit 
    bool hasDigit = false;
    foreach (char c in candidate) //iterates through each character
    {
        if (char.IsDigit(c)) //if its a digit set hasDigit to true
        {
            hasDigit = true;
            break;
        }
    }
    if (!hasDigit) //checks if there is a digit 
    {
        return false; //Must have at least one digit
    }
    // Cheks for uppercase and lowercase 
    bool hasUpper = false;
    bool hasLower = false;
    foreach (char c in candidate)
    {
        if (char.IsUpper(c))
        {
            hasUpper = true;
        }
        else if (char.IsLower(c))
        {
            hasLower = true;
        }
        if (hasUpper && hasLower)
        {
            break;
        }
    }
    if (!hasUpper || !hasLower)
    {
        return false; // Must have upper and lower
    }
    return true; //Pass is valid
}
