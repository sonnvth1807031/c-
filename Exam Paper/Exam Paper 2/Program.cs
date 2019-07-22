using System;
using System.Text.RegularExpressions;

class Programaa
{
    static void Main(string[] args)
    {
        string str = "Enter a String";
        string str1 = "Aptech Computer Center";
        Console.WriteLine(str1);
        Console.WriteLine("Enter a word to search ");
        string st = Console.ReadLine();
        var count = Regex.Matches(str1, st).Count;
        Console.WriteLine("Word found " + count + " times in the string.");
    }
}