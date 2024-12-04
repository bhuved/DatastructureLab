// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("*****Data Structure Lab!");
Console.WriteLine("Enter a word to reverse");
string userInput = "";
do
{
    userInput = Console.ReadLine().Trim();
    if (Regex.IsMatch(userInput, @"^[a-zA-Z\s]+$"))
    {
        break;
    }
    else
    {
        Console.WriteLine("Do not enter numbers and symbols. Enter Valid input");
        continue;
    }
} while (true);


Console.WriteLine($"The user entered string is {userInput}");

Console.WriteLine("String after reversed " + ReverseString(userInput));

string ReverseString(string inputString)
{
    string reversedString = "";
    Stack<string> strStack = new Stack<string>();
    string[] sentenceArray = inputString.Split(" ");
    foreach (string sentence in sentenceArray)
    {
        foreach (char c in sentence)
        {
            strStack.Push(c.ToString());
        }
        while (strStack.Count > 0)
        {
            reversedString += strStack.Pop();
        }
        reversedString += " ";
    }   
    
    return reversedString.Trim();
}
