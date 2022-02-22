//John Reichenbach
//CS 285-001
//Programming Assignment 6, #9
//11-22-2021

using System;
using static System.Console;

namespace DistributionChartApp
{
    class DistributionChart
    {
        static void Main()
        {
            //initialize list to have 0 at each index, indicating the number of numbers
            //in each spot. ex index 1 holds the number of 2's entered
            int[] list = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            GetInput(list); //gets the input from the user
            PrintChart(list); //prints the distribution chart
        }

        //gets the input from the user
        static void GetInput(int[] l)
        {
            string input;
            int result = 0;

            //asks for user input, stops at -999
            WriteLine("Enter a value between 0 and 10, or -999 to stop: ");
            input = ReadLine();

            //while the user enters an invalid input or a valid input not equal to -999
            while (int.TryParse(input, out int s) == false || int.Parse(input) != -999)
            {
                //if the user enters an invalid input
                if (int.TryParse(input, out int i) == false ||
                    int.Parse(input) <= 0 || int.Parse(input) >= 10)
                {
                    //ask for new input
                    WriteLine("Invalid Entry.");
                    WriteLine("Enter a value between 0 and 10, or -999 to stop: ");
                    input = ReadLine();
                }
                //else the user entered a valid input
                else
                {
                    //convert input to an integer and then add 1 to the number's index in the list
                    result = int.Parse(input);
                    l[result - 1]++;

                    //ask for more input
                    WriteLine("Enter a value between 0 and 10, or -999 to stop: ");
                    input = ReadLine();
                }
            }
        }

        //prints out the chart
        static void PrintChart(int[] l)
        {
            WriteLine();

            //count to hold the chart key
            int count = 1;

            //for every element of the array
            foreach (int s in l)
            {
                Write(count + "|"); //display the chart key
                for (int i = 0; i < s; i++) //display the correct number of astericks
                {
                    Write("*");
                }

                //goes to the next line and key
                WriteLine();
                count++;
            }
        }
    }
}
