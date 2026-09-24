using System;

namespace CSharpMasterclass.Section01_Introduction.GettingInput
{
    public static class Input
    {
        public static void Run()
        {
            Console.WriteLine("What is your name?");
            Console.ReadLine();
            
            Console.Write("What's your name?");
            Console.Write("Hello, " + Console.ReadLine() + "!");
        }
    }
}