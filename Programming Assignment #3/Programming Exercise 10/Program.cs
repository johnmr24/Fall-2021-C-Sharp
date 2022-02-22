//John Reichenbach
//CS 285-001
//9-22-2021
//Programming Assignment #10

using System;
using static System.Console;

namespace Programming_Exercise_10
{
    class Programming_Exercise_10
    {
        static void Main()
        {
            string address; //holds the address
            double priorYearValue; //holds the prior year value
            const double MILLAGE_RATE = 10.03; //holds the millage rate
            const double EXEMPTION = 25000; //holds the exemption amount
            const double NEW_VALUE_INCREASE = 0.027; //holds the new year increase amount

            address = inputAddress(); //inputs the address
            priorYearValue = inputValue(); //inputs the prior year value

            Clear(); //clears the console

            displayResults(priorYearValue, NEW_VALUE_INCREASE, MILLAGE_RATE, EXEMPTION, address); //displays the results
        }

        static string inputAddress() //inputs the address
        {
            string input;

            Write("Enter your address: ");
            input = ReadLine();

            return input;

        }

        static double inputValue() //inputs the previous years value
        {
            string input;
            double value;

            Write("Enter the prior years value for your home: $");
            input = ReadLine();
            value = double.Parse(input);

            return value;
        }

        static double calcNewValue(double prior_year_value, double new_value_increase) //calculates the current years value
        {
            double newValue = prior_year_value + (prior_year_value * new_value_increase); //adds the new year precentage increase to the previos year

            return newValue;
        }

        static double calcTaxes(double new_year_value, double millage_rate, double exemption) //calculates the taxes
        {
            double millageTax;
            new_year_value -= exemption; //subtracts the 25000 tax exemption
            millageTax = new_year_value / 1000 * millage_rate; //millage tax is equal to the new years value divided by
                                                               //$10.03 per $1000
            return millageTax;
        }

        static void displayResults(double prior_year_value, double new_value_increase, //displays the results
                                   double millage_rate, double exemption, string address)
        {

            WriteLine("{0,35}", address); //displays the address
            WriteLine();
            WriteLine("{0,-40}{1,15:c}", "Prior year's home value: ", prior_year_value); //displays the prior year's home value
            WriteLine("{0,-40}{1,15:c}", "Current year's home value: ", calcNewValue(prior_year_value, //displays the current home value
                                                                                     new_value_increase));
            WriteLine();
            WriteLine("{0,-40}{1,15:c}", "Proposed taxes for current year: ", calcTaxes( //displays the proposed taxes 
                 calcNewValue(prior_year_value, new_value_increase), millage_rate, exemption));
        }

    }
}
