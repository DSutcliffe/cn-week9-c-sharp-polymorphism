using System;
namespace cn_week9_c_sharp_polymorphism
{
    class Program
    {
        // ability to create the same function to replace 'if'. if integer/double/string...
        // capture all
        void polyPrint(int myInteger)
        {
            Console.WriteLine("Printing int: {0}", myInteger);
        }
        void polyPrint(double myDouble)
        {
            Console.WriteLine("Printing float: {0}", myDouble);
        }
        void polyPrint(string myString)
        {
            Console.WriteLine("Printing string: {0}", myString);
        }
        void withdrawal(int bankBalance, int withdrawalAmount)
        {
            bankBalance -= withdrawalAmount;
            Console.WriteLine("My new balance is: £{0}", bankBalance);
        }
        static void Main(string[] args)
        {
            // make it available...
            Program myPoly = new Program();

            // Call print to print integer
            myPoly.polyPrint(5);
            // Call print to print float
            myPoly.polyPrint(500.263);
            // Call print to print string
            myPoly.polyPrint("Hello C++");
            Console.ReadKey();

            myPoly.withdrawal(500, 30);
        }
    }
}

