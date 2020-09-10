using System;

namespace dusk4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your number?");
            String UserInput = Console.ReadLine();
            int Number = Int32.Parse(UserInput);
            if(Number >0)
            {
                Console.WriteLine("The number is positive.");

            }else if (Number < 0)
            {
                Console.WriteLine("the number is negative.");

            } else

            {
                Console.WriteLine("The number is 0.");

            }

        }
    }
}
