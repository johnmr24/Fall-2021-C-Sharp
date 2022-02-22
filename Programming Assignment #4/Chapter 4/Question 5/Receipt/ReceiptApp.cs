//John Reichenbach
//Programming Assignment 4, Chapter 4, Question 5
//CS 285-001
//10-14-21

using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ReceiptApp
{
    class ReceiptApp
    {
        static void Main()
        {
            //creates a variable of type receipt and initializes the data 
            Receipt r1 = new Receipt();
            r1.ReceiptNumber = "32087543098";
            r1.DateOfPurchase = "2/15/21";
            r1.CustomerNumber = "3127";
            r1.CustomerName = "David Burton";
            r1.CustomerAddress = "123 Pine Lane";
            r1.CustomerPhoneNumber = "(432) 654-6859";
            r1.ItemNumber = "9043244C";
            r1.Description = "Beans";
            r1.UnitPrice = 3.29;
            r1.QuantityPurchased = 5;

            //prints out r1 using the ToString method
            WriteLine(r1);

        }

    }
}


