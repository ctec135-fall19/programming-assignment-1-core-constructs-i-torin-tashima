/*
Author: Torin Tashima
Date:   October 5, 2019
CTEC 135: Microsoft Software Development with C#

Module 2, Programming Assignment 1, Problem 1

    Variables and Printing

1. Region 1: declare 3 double variables, each using a different syntax.
2. Region 2: declare and initialize separate variables for each CLS compliant type
   - print value of each variable
3. Region 3: print the min/max values for different types

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    // Program class is where the assignment code is written and executed.
    class Program
    {
        #region Main(string[] args)
        // Main method
        // Inputs: Array of strings passed as command lines in the command
        //         line terminal.
        // Outputs: N/A (void doesn't return anything)
        // Behavior: This method acts as the command line terminal that is
        //           the heart of the program.
        #endregion
        static void Main(string[] args)
        {
            #region region 1 - variable declarations
            // three different ways to declare a double variable

            double myDouble;
            System.Double myDouble2;
            double myDouble3 = new double();
            #endregion

            #region region 2 - variable initialization
            // initializes numeric variables
            byte r2Byte = 17;
            short r2Short = 260;
            int r2Int = 40_000;
            long r2Long = 1_357_913_579l;
            float r2Float = 10.29f;
            double r2Double = 687.09;
            decimal r2Decimal = 3_640.70m;

            // prints values of numeric variables to the terminal
            Console.WriteLine("Byte: {0:x}", r2Byte);
            Console.WriteLine("Short: {0:c}", r2Short);
            Console.WriteLine("Int: {0:e}", r2Int);
            Console.WriteLine("Long: {0:n}", r2Long);
            Console.WriteLine("Float: {0}", r2Float);
            Console.WriteLine("Double: {0}", r2Double);
            Console.WriteLine("Decimal: {0}", r2Decimal);
            #endregion

            #region region 3 - max/min values
            // prints max and min values of the int16 type

            Console.WriteLine("Int16's Maximum Value: {0}", System.Int16.MaxValue);
            Console.WriteLine("Int16's Minimum Value: {0}", System.Int16.MinValue);
            #endregion
        }
    }
}
