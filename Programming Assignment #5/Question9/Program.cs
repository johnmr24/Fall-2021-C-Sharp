//John Reichenbach
//Programming Assignment 5, Question 9
//CS 285-001
//10-31-2021

using System;
using static System.Console;

namespace Question9
{
    class Question9
    {
        static void Main()
        {
            char c = '*'; //char to hold the user entered character
            int size = 3; //char to hold the size of the triangle

            getInput(ref c, ref size); //gets the input from the user
            makeTriangle(c, size); //makes and outputs the triangle
        }

        //makes and outputs the triangle
        static void makeTriangle(char c, int size)
        {
            //creates the top part of the triangle, including the middle
            for (int i=0; i<size+1; i++)
            {
                for (int o=0; o<i; o++)
                {
                    Write(c); //writes the character
                }
                Write("\n"); //goes to the next line after each step of the outer loop
            }

            //creates the bottom part of the triangle
            for (int i=size-1; i>0; i--)
            {
                for (int o=i; o>0; o--)
                {
                    Write(c); //writes the character
                }
                Write("\n"); //goes to the next line after each step of the outer loop
            }

        }

        //gets the input from the user
        static void getInput(ref char c, ref int size)
        {
            string input;

            Write("Enter a character to make the triangle with: ");
            input = ReadLine();

            //if the character input is invalid, default to *
            if (char.TryParse(input, out c) == false)
            {
                WriteLine("Invalid character entered. '*' has been recorded.");
                c = '*';
            }

            Write("Enter the size of the peak of the triangle (1-10): ");
            input = ReadLine();

            //if the size input is invalid, default to 3
            if (int.TryParse(input, out size) == false || int.Parse(input)>10
                                                       || int.Parse(input)<0)
            {
                WriteLine("Invalid size. 3 has been recorded");
                size = 3;
            }
        }
    }
}
