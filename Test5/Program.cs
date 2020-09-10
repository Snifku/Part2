using System;

namespace Test5
{
    class Program
    {
        static void Main(string[] args)
        {
            string Userinput;
            Console.WriteLine("what is your favorite animal?");
            Userinput = Console.ReadLine();
            if(Userinput == "CAT")
            {
                Console.WriteLine("You are a homebird.");
            }            
            else if (Userinput == "DOG)")
             {
                    Console.WriteLine("You are a partygoer.");

            } else
                {
                    Console.WriteLine($"You are a {Userinput} friend.");


                }
            }
    }
}
