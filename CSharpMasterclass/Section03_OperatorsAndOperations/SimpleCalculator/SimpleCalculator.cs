using System;

namespace CSharpMasterclass.Section03_OperatorsAndOperations.SimpleCalculator
{
    public class SimpleCalculator
    {
        public static void Run()
        {
            Console.WriteLine("Enter the first number: ");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            var num2 = Convert.ToInt32(Console.ReadLine());
            
            var sum = num1 + num2;
            Console.WriteLine("The sum is: " + sum);

            var sub = num1 - num2;
            Console.WriteLine("The subtraction is: " + sub);

            var div = (float)num1 / num2;
            Console.WriteLine("The division is: " + div);

            var mod = num1 % num2;
            Console.WriteLine("The modulo is: " + mod);

            var mul = num1 * num2;
            Console.WriteLine("The multiplication is: " + mul);
        }
    }
}