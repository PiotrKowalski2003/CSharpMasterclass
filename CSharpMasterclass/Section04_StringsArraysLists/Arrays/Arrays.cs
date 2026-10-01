using System;

namespace CSharpMasterclass.Section04_StringsArraysLists.Arrays
{
    public class Arrays
    {
        public static void Run()
        {
            Console.WriteLine("=== Arrays ===");
            int[] numbers;
            numbers = new int[10];

            string[] names = {"John", "David", "Sarah", "1"};

            string[] fruits = new string[4] {"Apple", "Orange", "Pear", "Banana" };

            float[] scores = new float[] { 15.5F, 12.3F, 16.7F };
            
            var colors = new string[]{"Red", "Green", "Blue"};
            
            var productNames = new string[8];
            
            Console.WriteLine("\n=== Array Elements ===");
            
            Console.WriteLine($"names[1] is:  {names[1]}");
            Console.WriteLine($"Array 'names' has {names.Length} elements.");
            Console.WriteLine($"The last item in 'names' is {names[names.Length - 1]}");
            
            Console.WriteLine("\n=== Multidimensional Arrays ===");
            int[,] matrix =
            {
                {5,6,2}, 
                {8,3,10}, 
                {0,0,0}
            };
            Console.WriteLine($"Length of the matrix is {matrix.GetLength(0)}x{matrix.GetLength(1)}");
            Console.WriteLine($"The number of rows is {matrix.GetLength(0)}");
            Console.WriteLine($"The number of columns is {matrix.GetLength(1)}");
            
            Console.WriteLine($"matrix[1,2] is :  {matrix[1,2]}");
            matrix[1,2] = 20;
            Console.WriteLine($"matrix[1,2] is :  {matrix[1,2]}");
        }
    }
}