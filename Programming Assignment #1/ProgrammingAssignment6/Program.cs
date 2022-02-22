// John Reichenbach
// Programming Assignment 6
// CS 285
// August 31

using System;

namespace ProgrammingAssignment6
{
    class Program
    {
        static void Main()
        {
            //prints the phrase all on one line
            Console.Write("Output #1\n\t");
            Console.Write("It is better to ");
            Console.Write("make a mistake than ");
            Console.Write("to do nothing.\n\n");

            //prints the phrase on 3 lines
            Console.Write("Output #2\n\t");
            Console.Write("It is better to \n\t");
            Console.Write("make a mistake than \n\t");
            Console.Write("to do nothing.\n\n");

            //prints the phrase all on different lines
            Console.Write("Output #3\n\t");
            Console.Write("It\n\tis\n\tbetter\n\tto\n\t" +
                          "make\n\ta\n\tmistake\n\tthan\n\t" +
                          "to\n\tdo\n\tnothing\n");
        }
    }
}
