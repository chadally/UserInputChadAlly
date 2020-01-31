using System;

namespace UserInputChadAlly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, this is Chad Ally");
            Console.WriteLine("Say hello world and hit enter.");
            string greeting;
            greeting = Console.ReadLine();
            Console.WriteLine("You typed: " + greeting);
        }
    }
}
