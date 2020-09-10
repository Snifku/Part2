using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your First number?");
            String userinput = Console.ReadLine();
            int Num1 = Int32.Parse(userinput);
            Console.WriteLine("What is your Second number?");
            userinput = Console.ReadLine();
            int Num2 = Int32.Parse(userinput);

            if (Num1 == Num2)
            {
                Console.WriteLine("the numbers you provided are equal");
            } else
            {
                Console.WriteLine("numbers you provided are NOT equal");
            }

        }
    }
}
