using System.Diagnostics;
using System.IO;
using System.Xml;
using Microsoft.Win32.SafeHandles;
using System;

// Question 1

static void sent(string fileName)
{
    StreamWriter fileStr;
    string input = Console.ReadLine();
    if (File.Exists(input) == true)
    {
        Console.WriteLine("The file already exists.");
        fileStr = File.AppendText(fileName);
    }
    else
    {
        fileStr = File.CreateText(fileName);
    }
    while (input != "")
    {
        fileStr.WriteLine(input);
        input = Console.ReadLine();
    }
    fileStr.Close();
}

// Question 2

static string search()
{
    StreamReader fileStr = new StreamReader("stations.txt");
    string line;
    while ((line = fileStr.ReadLine()) != null)
    {
        if (line.Contains("Station") == true)
        {
            return line;
        }
    }
    fileStr.Close();
    return ("Not contained");
}

Debug.Assert(search() == "Battersea Power Station, Northern");

// Question 3

static List<string> Mackerel()
{
    List<string> output = new List<string>();
    StreamReader fileStr = new StreamReader("stations.txt");
    string line;
    while ((line = fileStr.ReadLine().ToLower()) != null)
    {
        string[] str = line.Split(",");
        if ((str[0].Contains("m") || str[0].Contains("a") || str[0].Contains("c") || str[0].Contains("k") || str[0].Contains("e") || str[0].Contains("r") || str[0].Contains("l")) == false)

        {
            output.Add(line);
        }
    }
    fileStr.Close();
    return output;
}

static List<string> Piranha()
{
    List<string> output = new List<string>();
    StreamReader fileStr = new StreamReader("stations.txt");
    string line;
    while ((line = fileStr.ReadLine().ToLower()) != null)
    {
        string[] str = line.Split(",");
        if ((str[0].Contains("p") || str[0].Contains("i") || str[0].Contains("r") || str[0].Contains("a") || str[0].Contains("n") || str[0].Contains("h") || str[0].Contains("a")) == false)
        {
            output.Append(line);
        }
    }
    fileStr.Close();
    return output;
}

static List<string> Sturgeon()
{
    List<string> output = new List<string>();
    StreamReader fileStr = new StreamReader("stations.txt");
    string line;
    while ((line = fileStr.ReadLine().ToLower()) != null)
    {
        string[] str = line.Split(",");
        if ((str[0].Contains("s") || str[0].Contains("t") || str[0].Contains("u") || str[0].Contains("r") || str[0].Contains("g") || str[0].Contains("e") || str[0].Contains("o") || str[0].Contains("n")) == false)
        {
            output.Append(line);
        }
    }
    fileStr.Close();
    return output;
}

static List<string> Bacteria()
{
    List<string> output = new List<string>();
    StreamReader fileStr = new StreamReader("stations.txt");
    string line;
    while ((line = fileStr.ReadLine().ToLower()) != null)
    {
        string[] str = line.Split(",");
        if ((str[0].Contains("b") || str[0].Contains("a") || str[0].Contains("c") || str[0].Contains("t") || str[0].Contains("e") || str[0].Contains("r") || str[0].Contains("i")) == false)
        {
            output.Append(line);
        }
    }
    fileStr.Close();
    return output;
}
/*
Debug.Assert(Mackerel() == new List<string>() { "st. john's wood, jubilee" });
Debug.Assert(Piranha() == new List<string>() { "stockwell, victoria, northern" });
Debug.Assert(Mackerel() == new List<string>() { "balham, northern", "blackwall, docklands light railway" });
Debug.Assert(Bacteria() == new List<string>());
*/
// Question 4

static List<string> AlliterationStation()
{
    List<string> output = new List<string>();
    StreamReader fileStr = new StreamReader("stations.txt");
    string line;
    while ((line = fileStr.ReadLine()) != null)
    {
        string[] comma = line.Split(",");
        string[] words = comma[0].Split(" ");
        if ((words.Count() == 2) && words[0][0] == words[1][0])
        {
  //          output.Add(words.ToString());
        }
    }
    fileStr.Close();
    return output;
}

// Question 5

