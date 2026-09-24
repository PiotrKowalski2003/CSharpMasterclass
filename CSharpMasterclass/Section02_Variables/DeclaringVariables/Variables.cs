using System;

namespace CSharpMasterclass.Section02_Variables.DeclaringVariables
{
    public class Variables
    {
        public static void Run()
        {
            string message = "Hello World!";
            Console.WriteLine(message);
            
            message = "Goodbye World!";
            Console.WriteLine(message);

            //message = 10;      // syntax error 
            
            //byte, short, int, long
            byte score = 15;
            //byte point = 256;     // error
            
            string firstName, lastName, middleName;
            firstName = "John";
            lastName = "Doe";
            middleName = "Smith";
            
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(middleName);
            
            float points = 10.5f;
            Console.WriteLine(points);

            double grade = 15.682315;
            Console.WriteLine(grade);
            
            char key = 'A';
            Console.WriteLine(key);
            
            bool isRegistered = true;
            Console.WriteLine(isRegistered);
            
            int age = 25;
            Console.WriteLine(age);
            
            long population = 1000000000;
            Console.WriteLine(population);
            
            var name = "John";
            Console.WriteLine(name);
            name = "Jane";
            name = "Dorothy";
            //name = 5; // error
            Console.WriteLine(name);
            
            Console.WriteLine(name.GetType());
            
            const string name2 = "John";
            //name2 = "Joe";  // error

            const double PI = 3.1415;
            Console.WriteLine(PI);

        }
    }
}