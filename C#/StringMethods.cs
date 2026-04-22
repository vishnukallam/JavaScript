using System;
namespace CSharp
{
    class StringMethods
    {
        static void Main(string[] args)
        {
            string myName = "Zoro";
            Console.WriteLine("Length of the String: " + myName.Length);
            Console.WriteLine("String in lower case: " + myName.ToLower());
            Console.WriteLine("String as character array: " + string.Join(", ", myName.ToArray()));
            Console.WriteLine("Substring (0, 3): " + myName.Substring(0, 3));
            Console.WriteLine("Contains 'or': " + myName.Contains("or"));
            Console.WriteLine("Starts with 'Zo': " + myName.StartsWith("Zo"));
            Console.WriteLine("Ends with 'ro': " + myName.EndsWith("ro"));
            Console.WriteLine(myName + " is a character in One Piece.");
            Console.WriteLine(myName[0]);
            Console.WriteLine(myName.IndexOf("o"));
            Console.WriteLine(myName.LastIndexOf("o"));
            Console.WriteLine(myName.Replace("o", "a"));
            Console.WriteLine(myName.TrimEnd('o'));

            string number = "9123-526-526";
            Console.WriteLine(number.Replace("-", " "));

            for (int i = 0; i < myName.Length; i++)
            {
                Console.Write(myName[i]);
            }
        }

    }
}