using System;
namespace CSharp
{
    class StringMethods
    {
        static void Main(string[] args)
        {
            string myName = "Zoro";
            Console.WriteLine(myName.Length);
            Console.WriteLine(myName.ToLower());
            Console.WriteLine(myName.ToArray());
            Console.WriteLine(myName.Substring(0, 3));
            Console.WriteLine(myName.Contains("or"));
            Console.WriteLine(myName.StartsWith("Zo"));
            Console.WriteLine(myName.EndsWith("ro"));
            Console.WriteLine(myName + " is a character in One Piece.");
            Console.WriteLine(myName[0]);
            Console.WriteLine(myName.IndexOf("o"));
            Console.WriteLine(myName.LastIndexOf("o"));
            Console.WriteLine(myName.Replace("o", "a"));
            Console.WriteLine(myName.TrimEnd('o'));

        }
    }
}