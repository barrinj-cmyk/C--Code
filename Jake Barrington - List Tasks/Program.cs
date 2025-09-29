// Question 1

using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices.Marshalling;

static int sum(List<int> n)
{
    int total = 0;
    foreach (int i in n)
    {
        total = total + i;
    }
    return total;
}

static int max(List<int> n)
{
    int max = 0;
    foreach (int i in n)
    {
        if (max < i)
        {
            max = i;
        }
    }
    return max;
}

static int min(List<int> n)
{
    int min = 1000000000;
    foreach (int i in n)
    {
        if (min > i)
        {
            min = i;
        }
    }
    return min;
}
/*
static int negative(List<int> n)
{
    List<int> negatives =
     n
    .Where(i => i < 0)
    .Select(i => double(i))
    .toList();
    return negatives;
}
*/
//Question 4
static bool isDuplicate(List<int> a, List<int> b)
{
    HashSet<int> set_a = a.ToHashSet();
    HashSet<int> set_b = b.ToHashSet();

    if (set_a == set_b)
    {
        return true;
    }
    return false;
}

//Question 5

static bool NaiveSearch(List<int> a, int num)
{
    foreach (int c in a)
    {
        if (c == num)
        {
            return true;
        }
    }
    return false;
}

static bool BinarySearch(List<int> a, int num)
{
    if (a[0] > num || a[a.Count - 1] < num)
    {
        return false;
    }
    bool found = false;
    while (a.Count > 0 && !found)
    {
        int mid = a.Count / 2;
        if (a[mid] == num)
        {
            found = true;
        }
        else if (a[mid] > num)
        {
            a = a.Take(mid).ToList();
        }
        else
        {
            a = a.Skip(mid + 1).ToList();
        }
    }
    return found;
}

// Question 6

static List<int> duplicates(List<int> a)
{
    List<int> non_duplicates = new List<int>();
    List<int> duplicates = new List<int>();
    foreach (int i in a)
    {
        if (non_duplicates.Contains(i) == false)
        {
            non_duplicates.Add(i);
        }
        else if (duplicates.Contains(i) == false && non_duplicates.Contains(i) == true) 
        {
            duplicates.Add(i);
        }
    }
    return duplicates;
}

List<int> test = new List<int>() { 2, 2, 2, 3, 3, 5, 4, 5, 6 };

Debug.Assert(duplicates(test).Count == 3);