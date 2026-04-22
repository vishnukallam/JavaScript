using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("I like coding in C#!");
            // Console.Write("Press any key to continue...");
            // Console.ReadKey();
            // Console.WriteLine("\aGoodbye!");
            Random random = new Random();
            int num = random.Next(1, 101);
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(num);
            }

        }
    }
}
