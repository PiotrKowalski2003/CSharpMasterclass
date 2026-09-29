using System;

namespace CSharpMasterclass.Section03_OperatorsAndOperations.ComparisonOperators
{
    public class ComparisonOperators
    {
        public static void Run()
        {
            Console.WriteLine("Comparison Operators");

            var firstNumber = 10;
            var secondNumber = 25;
            
            var equal = firstNumber == secondNumber;
            Console.WriteLine("The numbers are equal: " + equal);
            
            var notEqual = firstNumber != secondNumber;
            Console.WriteLine("The numbers are not equal: " + notEqual);
            
            var greaterThan = firstNumber > secondNumber;
            Console.WriteLine("The first number is greater than the second number: " + greaterThan);
            
            var lessThan = firstNumber < secondNumber;
            Console.WriteLine("The first number is less than the second number: " + lessThan);
            
            var greaterThanOrEqual = firstNumber >= secondNumber;
            Console.WriteLine("The first number is greater than or equal to the second number: " + greaterThanOrEqual);
            
            var lessThanOrEqual = firstNumber <= secondNumber;
            Console.WriteLine("The first number is less than or equal to the second number: " + lessThanOrEqual);
            
            Console.WriteLine("Logical Operators");
            var firstNumberIsBetween10And50 = firstNumber >= 10 && firstNumber <= 50;
            Console.WriteLine("The first number is between 10 and 50: " + firstNumberIsBetween10And50);
            
            var secondNumberIsLessThan100OrGreaterThan20 = secondNumber < 100 || secondNumber > 20;
            Console.WriteLine("The second number is less than 100 or greater than 20: " + secondNumberIsLessThan100OrGreaterThan20);
            
            var notSecondNumberIsLessThan100OrGreaterThan20 = !(secondNumber < 100 || secondNumber > 20);
            Console.WriteLine("The second number is not less than 100 or not greater than 20: " + notSecondNumberIsLessThan100OrGreaterThan20);
            
            

        }
    }
}