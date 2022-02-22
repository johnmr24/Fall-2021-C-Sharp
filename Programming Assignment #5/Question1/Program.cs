//John Reichenbach
//Programming Assignment 5, Question 1
//CS 285-001
//10-31-2021

using System;
using static System.Console;

namespace Question1
{
    class Question1
    {
        static int numValidEntries = 0; //holds the number of valid entries
        static int numOutsideRange = 0; //holds the number of entries outside the range
        static int numNonNumeric = 0; //holds the number of entries that are non-numeric
        static void Main()
        {
            getInput(); //gets the input from the user
            displayResults(); //displays the results to the user
        }

        //gets the input from the user
        static void getInput()
        {
            string input;
            int num;

            Write("Enter a positive integer (-999 to quit): ");
            input = ReadLine();
            
            //while the user enters a non-integer, or while they do not enter -999
            while (int.TryParse(input, out num) == false || int.Parse(input) != -999)
            {
                //if the user enters a non-integer
                if (int.TryParse(input, out num) == false)
                {
                    //asks for another input and adds to the numNonNumeric variable
                    Write("Invalid input. Input is not an integer. Enter a positive integer: ");
                    input = ReadLine();
                    addNumNonNumeric();
                }
                //else if the user enters a valid
                else if (int.Parse(input) < 100 && int.Parse(input) >= 0)
                {
                    //asks for another input and adds to the numValidEntries variable
                    Write("Entry recorded. Enter another integer: ");
                    input = ReadLine();
                    addNumValidEntries();
                }
                //else the user entered a integer outside the range
                else
                {
                    //asks for another input and adds to the numOutsideRange variable
                    Write("Input needs to be less than 100 and positive. Enter another integer: ");
                    input = ReadLine();
                    addNumOutsideRange();
                }
            }
        }

        //adds 1 to the numValidEntries variable
        static void addNumValidEntries()
        {
            numValidEntries++;
        }

        //adds 1 to the numOutsideRange variable
        static void addNumOutsideRange()
        {
            numOutsideRange++;
        }

        //adds 1 to the numNonNumeric variable
        static void addNumNonNumeric()
        {
            numNonNumeric++;
        }

        //displays the results
        static void displayResults()
        {
            Clear();
            WriteLine("Number of valid inputs: " + numValidEntries);
            WriteLine("Number of inputs outside range: " + numOutsideRange);
            WriteLine("Number of inputs non-numeric: " + numNonNumeric);
        }
    }
}
