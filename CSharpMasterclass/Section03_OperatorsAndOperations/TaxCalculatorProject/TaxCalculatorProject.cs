using System;

namespace CSharpMasterclass.Section03_OperatorsAndOperations.TaxCalculatorProject
{
    public class TaxCalculatorProject
    {
        public static void Run()
        {
            Console.WriteLine("Enter the tax rate: ");
            var taxRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the price: ");
            var price = Convert.ToDouble(Console.ReadLine());
            var totalPrice = price * taxRate + price;
            Console.WriteLine("The total price is: " + totalPrice);
        }
    }
}