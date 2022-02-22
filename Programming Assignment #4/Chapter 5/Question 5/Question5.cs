//John Reichenbach
//CS 285-001
//Programming Assignment 4, Chapter 5, Question 5
//10-15-21

using System;
using static System.Console;

namespace Question_5
{
    class Question_5
    {
        static void Main()
        {
            const decimal FIRST_ITEM_CHARGE = 2.99M; //constant for the first item charge
            const decimal TWO_THROUGH_FIVE = 1.99M; //constant for the charge of items 2 thru 5
            const decimal SIX_THROUGH_FOURTEEN = 1.49M; //constant for the charge of items 6 thru 14
            const decimal REMAINING = 0.99M; //constant for the remaining item charges over 15
            string input; //string to hold the user input
            int numPurchased; //int to hold the number of items purchased
            int currentNum; //int to hold the current amount of items,
                            //will use this to subtract from the numPurchased
            decimal totalCost = 0.0M; //holds the total cost

            //input the numPurchased and convert input to integer
            //also sets currentNum equal to numPurchased
            Write("Enter the amount of items purchased: ");
            input = ReadLine(); 
            numPurchased = int.Parse(input);
            currentNum = numPurchased;

            if (numPurchased > 14) //if 15 or more items...
            {
                currentNum -= 14; //subtracts 14 from total, giving the remaining num

                //adds the first item charge, plus the 2 thru five charge multiplied
                //by 4, plus the 6 thru 9 multiplied by 9, plus the remaining charge 
                //multiplied by the current num
                totalCost += FIRST_ITEM_CHARGE + TWO_THROUGH_FIVE * (4)
                          + SIX_THROUGH_FOURTEEN * (9) + (REMAINING * currentNum);
            }
            else if (numPurchased > 5) //if 6 to 14 items...
            {
                currentNum -= 5; //subtracts 5 from total, giving the remaining num

                //adds the first item charge, plus the 2 thru five charge multiplied
                //by 4, plus the 6 thru 9 multiplied by the current num
                totalCost += FIRST_ITEM_CHARGE + TWO_THROUGH_FIVE * (4)
                          + (SIX_THROUGH_FOURTEEN * currentNum);
            }
            else if (numPurchased > 1) //if 2 to 5 items...
            {
                currentNum -= 1; //subtracts 1 from total, giving the remaining num

                //adds the first item charge, plus the 2 thru five charge multiplied
                //by the current num
                totalCost += FIRST_ITEM_CHARGE + TWO_THROUGH_FIVE * currentNum;
            }
            else if (numPurchased == 1) //if 1 item...
            {
                totalCost += FIRST_ITEM_CHARGE; //adds the cost of the first item
            }

            //outputs the total cost
            WriteLine();
            WriteLine("The total cost is: {0:C}", totalCost);

        }
    }
}
