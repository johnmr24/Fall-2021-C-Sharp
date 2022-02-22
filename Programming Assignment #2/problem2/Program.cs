//John Reichenbach
//9-11-2021
//CS 285-001
//problem 2
using System;
using static System.Console;

namespace problem2
{
    class problem2
    {
        static void Main()
        {

            const int FEET_PER_MILE = 5280; //variable to hold the number of feet in a mile
            const double KILOMETERS_PER_MILE = 1.609344; //variable to hold the number of kilometers in a mile
            double MILES = 4.5; //variable to test the program, initially set to 4.5

            int feet = (int)(FEET_PER_MILE * MILES); //converts miles to feet
            double kilometers = MILES * KILOMETERS_PER_MILE; // converts miles to kilometers

            WriteLine("{0,25}{1,10:N}", "Number of miles: ", MILES); //prints the number of miles
            WriteLine("{0,25}{1,10:N0}", "Number of feet: ", feet); //prints the number of feet
            WriteLine("{0,25}{1,10:N}","Number of kilometers: ", kilometers); //prints the number of kilometers


        }
    }
}
