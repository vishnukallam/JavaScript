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
            Console.Write("Enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {

                if (i == 10)
                {
                    Console.WriteLine("Hey 10, you don't have access");
                    break;
                }
                else
                {
                    continue;
                }

            }
            while (n > 0)
            {
                Console.WriteLine("This is an infinite loop");
            }

        }
    }
}
