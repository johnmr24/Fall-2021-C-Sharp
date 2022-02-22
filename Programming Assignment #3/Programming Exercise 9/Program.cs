//John Reichenbach
//CS 285-001
//9-22-2021
//Programming Exercise #9

using System;
using static System.Console;

namespace Programming_Exercise_9
{
    class Programming_Exercise_9
    {

        static void Main()
        {
            string employeeName;                 //holds the employee name
            double sales;                        //holds the total sales amount
            double commission;                   //holds the commission amount
            const double COMMISSION_RATE = 0.07; //holds the commission rate
            const double FED_TAX_RATE = 0.18;    //holds the federal tax rate
            const double RETIREMENT_RATE = 0.15; //holds the retirement rate
            const double SOC_SEC_RATE = 0.09;    //holds the social security rate

            employeeName = inputName();                          //inputs the employee name
            sales = inputSales();                                //inputs the total sales
            commission = calcCommission(sales, COMMISSION_RATE); // calculates the commission
            Clear();                                             //clear console

            displayResults(employeeName, sales, commission, COMMISSION_RATE, FED_TAX_RATE,
                           RETIREMENT_RATE, SOC_SEC_RATE); //displays results

        }

        static string inputName() //inputs the employee name
        {
            string input;

            Write("Enter your name: ");
            input = ReadLine();

            return input;

        }

        static double inputSales() //inputs the total sales
        {
            string input;
            double sales;

            Write("Enter the sales amount: $");
            input = ReadLine();
            sales = double.Parse(input);

            return sales;
        }

        static double calcCommission(double sales, double commission_rate) //calculates the commission earned
        {
            sales *= commission_rate;
            return sales;
        }

        static double calcFedTax(double commission, double federal_rate) //calculates the total federal tax
        {
            commission *= federal_rate;
            return commission;
        }

        static double calcRetirement(double commission, double retirement_rate) //calculates the retirement rate
        {
            commission *= retirement_rate;
            return commission;
        }

        static double calcSocSec(double commission, double social_security_rate) //calculates the social security rate
        {
            commission *= social_security_rate;
            return commission;
        }

        static double calcMoneyMade(double sales, double commission, double commission_rate, //calculates the total money made with deductions
                                   double federal, double retirement, double social)
        {
            double moneyMade = (calcCommission(sales, commission_rate))         //adds the commission 
                              - (calcFedTax(commission, federal))               //subtracts the federal tax
                              - (calcRetirement(commission, retirement))        //subtracts the retirement
                              - (calcSocSec(commission, social));               //subtracts the social security
            return moneyMade;
        }

        static void displayResults(string name, double sale, double commission, double commission_rate, //displays results
                                   double federal, double retirement, double social)
        {
            WriteLine("{0,35}", name); //displays name
            WriteLine();
            WriteLine("{0,-35}{1,15:c}", "Total Sales: ", sale); //displays total sales
            WriteLine();
            WriteLine("{0,-35}{1,15:c}", "Commission Recieved: ", commission); //displays commission
            WriteLine("{0,-35}{1,15:c}", "Federal Tax Deducted: ", calcFedTax(commission, federal)); //displays federal tax
            WriteLine("{0,-35}{1,15:c}", "Retirement Contribution Deducted: ", calcRetirement(commission, retirement)); //displays retirement
            WriteLine("{0,-35}{1,15:c}", "Social Security Deduction: ", calcSocSec(commission, social)); //displays social security
            WriteLine();
            WriteLine("{0,-35}{1,15:c}", "Total Money Earned: ", calcMoneyMade(sale, commission, commission_rate, //displays total money made
                                                                  federal, retirement, social));


        }
    }
}
