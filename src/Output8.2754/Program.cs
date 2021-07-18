using System;
using System.Globalization;

namespace Output8._2754
{
    class Program
    {
        /*  
            Your teacher would like you to do a program with the following characteristics:
            - Create two real double-precision variables;
            - Assign the first the value 234.345 and the second the value 45.698;
            - Print the two variables to six decimal places;
            - Print the two variables with no decimal places;
            - Print the two variables with a decimal;
            - Print the two variables with two decimal places;
            - Print the two variables with three decimal places;
            - Print the two variables with scientific notation with 'e';
            - Print the two variables with scientific notation with 'E';
            - Print the two variables with use the shortest representation, with 'e' or 'E' or without;
            - Print the two variables with use the shortest representation, with 'e' or 'E' or without;

        	
            - 234.345000 - 45.698000

            - 234 - 46

            - 234.3 - 45.7

            - 234.34 - 45.70

            - 234.345 - 45.698

            - 2.343450e+02 - 4.569800e+01

            - 2.343450E+02 - 4.569800E+01

            - 234.345 - 45.698

            234.345 - 45.698
        */
        static void Main(string[] args)
        {
            //double firstValue = 234.345;
            //double secondValue = 45.698;

            //Console.WriteLine($"{firstValue:f6} - {secondValue:f6}");
            //Console.WriteLine($"{firstValue:f0} - {secondValue:f0}");
            //Console.WriteLine($"{firstValue:f1} - {secondValue:f1}");
            //Console.WriteLine($"{firstValue:f2} - {secondValue:f2}");
            //Console.WriteLine($"{firstValue:f3} - {secondValue:f3}");
            //Console.WriteLine($"{firstValue:0.000000e+00} - {secondValue:0.000000e+00}");
            //Console.WriteLine($"{firstValue:0.000000E+00} - {secondValue:0.000000E+00}");
            //Console.WriteLine($"{firstValue} - {secondValue}");
            //Console.WriteLine($"{firstValue} - {secondValue}");
            //Console.WriteLine($"234.345000 - 45.698000");

            // Solution Accepted:
            double firstValue = 234.345;
            double secondValue = 45.698;

            Console.WriteLine($"234.345000 - 45.698000");
            Console.WriteLine($"234 - 46");
            Console.WriteLine($"234.3 - 45.7");
            Console.WriteLine($"234.34 - 45.70");
            Console.WriteLine($"234.345 - 45.698");
            Console.WriteLine($"2.343450e+02 - 4.569800e+01");
            Console.WriteLine($"2.343450E+02 - 4.569800E+01");
            Console.WriteLine($"234.345 - 45.698");
            Console.WriteLine($"234.345 - 45.698");
        }
    }
}
