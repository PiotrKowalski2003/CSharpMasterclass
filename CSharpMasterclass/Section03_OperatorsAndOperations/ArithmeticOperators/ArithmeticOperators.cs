using System;

namespace CSharpMasterclass.Section03_OperatorsAndOperations.ArithmeticOperators
{
    public class ArithmeticOperators
    {
        public static void Run()
        {
            Console.WriteLine("Arithmetic Operators in C#");
            int a = 10;
            int b = 20;
            int sum = a + b;
            Console.Write("Sum is =>");
            Console.WriteLine(sum);
            
            int sub = a - b;
            Console.Write("Subtraction is =>");
            Console.WriteLine(sub);
            
            var div = a /(double) b;
            Console.Write("Division is =>");
            Console.WriteLine(div);
            
            int mul = a * b;
            Console.Write("Multiplication is =>");
            Console.WriteLine(mul);
            
            int mod = a % b;
            Console.Write("Modulus is =>");
            Console.WriteLine(mod);

            int result = ++a + b;
            Console.Write("Result is =>");
            Console.WriteLine(result);
        }
    }
}