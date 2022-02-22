//John Reichenbach
//Programming Assignment 5, Question 5
//CS 285-001
//10-31-2021

using System;
using static System.Console;

namespace Question5
{
    class Question5
    {
        static void Main()
        {
            double totalPurchasePrice = 0.0; //double to hold the total purchase price
            double salesTaxAmount = 0.0; //double to hold the sales tax amount
            double shippingCharge = 0.0; //double to hold the shipping amount
            double grandTotal = 0.0; //double to hold the grand total charge
            int numItems = 0; //int to hold the number of items purchased

            //gets the input from the user
            getInput(ref numItems, ref totalPurchasePrice); 

            //calculates the total amount due
            calcAmountDue(numItems, totalPurchasePrice, ref salesTaxAmount,
                          ref shippingCharge, ref grandTotal);

            //displays the results
            displayResults(numItems, totalPurchasePrice, salesTaxAmount,
                           shippingCharge, grandTotal);
        }

        //gets the input from the user
        static void getInput(ref int num, ref double price)
        {
            string input;
            double p;
            Write("Enter the item price (-999 to quit): ");
            input = ReadLine();
            
            //while the user enters a number that is not a double or that is not -999
            while (double.TryParse(input, out p) == false || double.Parse(input) != -999)
            {
                //if the user enters a non-double, or a double less than 0
                if (double.TryParse(input, out p) == false || double.Parse(input) < 0)
                {
                    //ask for a new input
                    Write("Invalid Entry. Enter a positive real number (-999 to quit): ");
                    input = ReadLine();
                }
                //else, the user entered a valid double
                else
                {
                    price += double.Parse(input); //add the double to the price
                    num++; //increase the number of items by 1

                    //ask for more input
                    Write("Enter another price (-999 to quit): ");
                    input = ReadLine();
                }
            }
        }

        //calculates the total amount due
        static void calcAmountDue(int num, double price, ref double salesTax,
                                  ref double shipping, ref double total)
        {
            salesTax = price * 0.0775; //calculates the sales tax
            
            switch (num)
            {
                case int n when (n > 15): //more than 15 items
                    shipping = 10;
                    break;
                case int n when (n >= 11): //11 to 15 items
                    shipping = 9;
                    break;
                case int n when (n >= 7): //7 to 10 items
                    shipping = 7;
                    break;
                case int n when (n >= 3): //3 to 6 items
                    shipping = 5;
                    break;
                case int n when (n < 3): //less than 3 items
                    shipping = 3.50;
                    break;
            }

            //calculates the total price
            total = price + salesTax + shipping;
        }

        //displays the results to the user
        static void displayResults(int num, double price, double salesTax,
                                   double shipping, double total)
        {
            //displays the results in a column
            Clear();
            WriteLine("{0, 30}{1, 10}", "The number of items bought: ", num);
            WriteLine("{0, 30}{1, 10:c}", "The total purchase price: ", price);
            WriteLine("{0, 30}{1, 10:c}", "The sales tax amount: ", salesTax);
            WriteLine("{0, 30}{1, 10:c}", "The shippping charge: ", shipping);
            WriteLine("{0, 30}{1, 10:c}", "The grand total: ", total);
        }
    }
}
