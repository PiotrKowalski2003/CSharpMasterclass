using System;

namespace CSharpMasterclass.Section03_OperatorsAndOperations.BitwiseOperators
{
    public class BitwiseOperators
    {
        public static void Run()
        {
            Console.WriteLine("Bitwise Operators in C#");
            int x = 3;
            
            int xLeftShift = x << 2;
            Console.Write("xLeftShift is => ");
            Console.WriteLine(xLeftShift);
            
            int xRightShift = x >> 1;
            Console.Write("xRightShift is => ");
            Console.WriteLine(xRightShift);

            int y = 2;
            int xAndY = x & y;
            Console.Write("xAndY is => ");
            Console.WriteLine(xAndY);

            int xOrY = x | y;
            Console.Write("xOrY is => ");
            Console.WriteLine(xOrY);

            int xXorY = x ^ y;
            Console.Write("xXorY is => ");
            Console.WriteLine(xXorY);

            int xNot = ~x;
            Console.Write("xNot is => ");
            Console.WriteLine(xNot);

            int xAndNotY = x & ~y;
            Console.Write("xAndNotY is => ");
            Console.WriteLine(xAndNotY);
            
            byte byteNotX = (byte)~x;
            Console.WriteLine("byteNotX is => " + byteNotX);
        }
    }
}