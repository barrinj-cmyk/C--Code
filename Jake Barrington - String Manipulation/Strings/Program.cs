//Question 1
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Text;

static List<string> MexicanWave(string str)
{
    List<string> result = new List<string>();
    for (int i = 0; i < str.Length; i++)
    {
        if (char.IsWhiteSpace(str[i]))
            continue;
        char[] temp = str.ToCharArray();
        temp[i] = char.ToUpper(temp[i]);
        result.Add(new string(temp));
    }
    return result;
}

var result = MexicanWave("hello world");
Debug.Assert(result.Count == 10);
Debug.Assert(result[0] == "Hello world");
Debug.Assert(result[5] == "hello World");

// Question 2
static List<int> charCodes(string str)
{
    List<int> output = new List<int>();
    char[] temp = str.ToCharArray();
    foreach (char i in temp)
    {
        output.Add((int)i);
    }
    return output;
}
Debug.Assert(charCodes("hello").SequenceEqual(new List<int> { 104, 101, 108, 108, 111 }));
Debug.Assert(charCodes("ABC").SequenceEqual(new List<int> { 65, 66, 67 }));
Debug.Assert(charCodes("123").SequenceEqual(new List<int> { 49, 50, 51 }));
Debug.Assert(charCodes("!@#").SequenceEqual(new List<int> { 33, 64, 35 }));

// Question 3

static List<int> Bytes(string str)
{
    List<int> output = new List<int>();
    byte[] bytes = Encoding.Default.GetBytes(str);
    foreach (byte i in bytes)
    {
        output.Add(i);
    }
    return output;

}

Debug.Assert(Bytes("hello").SequenceEqual(new List<int> { 104, 101, 108, 108, 111 }));

//Question 4

static string toString(int[] charCodes)
{
    return charCodes == null ? null : string.Concat(Array.ConvertAll(charCodes, code => (char)code));
}

Debug.Assert(toString([104, 101, 108, 108, 111]).SequenceEqual("hello"));

//Question 5

static string charCodes2(byte[] bytes)
{
    return Encoding.UTF8.GetString(bytes);
}
Console.WriteLine(charCodes2([206, 188, 206, 174, 206, 187, 206, 191]));