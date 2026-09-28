using System;

namespace CSharpMasterclass.Section03_OperatorsAndOperations.AssignmentOperators
{
    public class AssignmentOperators
    {
        public static void Run()
        {
            Console.WriteLine("Assignment Operators in C#");
            int num1 = 5;
            int num2 = 8;
            
            num1 += num2;   // num1 = num1 + num2
            num1 -= num2;   // num1 = num1 - num2
            num1 /= num2;   // num1 = num1 / num2
            num1 *= num2;   // num1 = num1 * num2
            num1 %= num2;   // num1 = num1 % num2
            
            num1 &= num2;   // num1 = num1 & num2
            num1 |= num2;   // num1 = num1 | num2
            num1 ^= num2;   // num1 = num1 ^ num2
            
            Console.Write("num1 is => ");
            Console.WriteLine(num1);
            Console.WriteLine("num2 is => " + num2);
        }
    }
}