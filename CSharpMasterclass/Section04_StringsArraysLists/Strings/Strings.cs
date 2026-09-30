using System;

namespace CSharpMasterclass.Section04_StringsArraysLists.Strings
{
    public class Strings
    {
        public static void Run()
        {
            var hello = "Hello";
            Console.WriteLine(hello);

            var letterE = hello[1];
            Console.WriteLine(letterE);

            var length = hello.Length;
            Console.WriteLine(length);
            
            var lengthOfWorld = "World".Length;
            Console.WriteLine(lengthOfWorld);
            
            Console.WriteLine("Enter your first name: ");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            var lastName = Console.ReadLine();
            // Hello Jane Doe
            Console.Write("Hello ");
            Console.WriteLine(firstName);
            Console.Write(" ");
            Console.WriteLine(lastName);
            
            // Hello using + operator
            Console.WriteLine("Hello " + firstName + " " + lastName);
            
            // Hello using string.Concat method
            Console.WriteLine(string.Concat("Hello ",firstName," ",lastName));
            
            // Hello using interpolation
            Console.WriteLine($"Hello {firstName} {lastName}!");
            
            Console.WriteLine("==============================================");
            
            Console.WriteLine("--- String Methods ---");
            var helloWorld = "  Hello     World";
            Console.WriteLine(helloWorld.ToUpper());
            Console.WriteLine(helloWorld.ToLower());
            Console.WriteLine(helloWorld.Trim());
            Console.WriteLine(helloWorld.TrimStart());
            Console.WriteLine(helloWorld.TrimEnd());

            Console.WriteLine($"The index of World is {helloWorld.IndexOf("World")}");
            Console.WriteLine($"The last index of world is {helloWorld.LastIndexOf("World")}");

            Console.WriteLine($"Use Substring Method with startIndex:  {helloWorld.Substring(-1)}");
            Console.WriteLine($"Use Substring Method with startIndex and length: {helloWorld.Substring(10,6)}");
            
            Console.WriteLine($"Replace all World with Universe: {helloWorld.Replace("World", "Universe")}");
            //helloWorld = helloWorld.Trim();
            
            Console.WriteLine("==============================");
            Console.WriteLine("--- Escape Characters ---");
            var message = "This is message from \"Me\"";
            Console.WriteLine(message);

            message = "This is message from \n\n\n Me";
            Console.WriteLine(message);

            message = "This is message from \t Me";
            Console.WriteLine(message);

            message = "This is message from \b Me";
            Console.WriteLine(message);

            message = "This is message from \\ Me";
            Console.WriteLine(message);
        }
    }
}