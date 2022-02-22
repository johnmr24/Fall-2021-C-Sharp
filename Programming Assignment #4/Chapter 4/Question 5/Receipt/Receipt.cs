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
    public class Receipt
    {
        private string receiptNumber; //holds the receipt number
        private string dateOfPurchase; //holds the date of purchase
        private string customerNumber; //holds the customer number
        private string customerName; //holds the customer name
        private string customerAddress; //holds the customer address
        private string customerPhoneNumber; //holds the customer phone number
        private string itemNumber; //holds the item number
        private string description; //holds the description
        private double unitPrice; //holds the unit price
        private int quantityPurchased; //holds the quantity purchased

        //default constructor that sets the data to blank
        public Receipt()
        {
            receiptNumber = "";
            dateOfPurchase = "";
            customerNumber = "";
            customerName = "";
            customerAddress = "";
            customerPhoneNumber = "";
            itemNumber = "";
            description = "";
            unitPrice = 0.0;
            quantityPurchased = 0;
        }

        //default constructor that sets the data based on the parameters
        public Receipt(string recNum, string date, string cusNum, string cusName,
                       string cusAdd, string cusPho, string item, string desc,
                       double price, int quantity)
        {
            receiptNumber = recNum;
            dateOfPurchase = date;
            customerNumber = cusNum;
            customerName = cusName;
            customerAddress = cusAdd;
            customerPhoneNumber = cusPho;
            itemNumber = item;
            description = desc;
            unitPrice = price;
            quantityPurchased = quantity;
        }

        //property for the receipt number
        public string ReceiptNumber
        {
            get
            {
                return receiptNumber;
            }
            set
            {
                receiptNumber = value;
            }
        }

        //property for the date of purchase
        public string DateOfPurchase
        {
            get
            {
                return dateOfPurchase;
            }
            set
            {
                dateOfPurchase = value;
            }
        }

        //property for the customer number
        public string CustomerNumber
        {
            get
            {
                return customerNumber;
            }
            set
            {
                customerNumber = value;
            }
        }

        //property for the customer name
        public string CustomerName
        {
            get
            {
                return customerName;
            }
            set
            {
                customerName = value;
            }
        }

        //property for the customer address
        public string CustomerAddress
        {
            get
            {
                return customerAddress;
            }
            set
            {
                customerAddress = value;
            }
        }

        //property for the customer phone number
        public string CustomerPhoneNumber
        {
            get
            {
                return customerPhoneNumber;
            }
            set
            {
                customerPhoneNumber = value;
            }
        }

        //property for the item number
        public string ItemNumber
        {
            get
            {
                return itemNumber;
            }
            set
            {
                itemNumber = value;
            }
        }

        //property for the description
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
            
        }

        //property for the unit price
        public double UnitPrice
        {
            get
            {
                return unitPrice;
            }
            set
            {
                unitPrice = value;
            }
        }

        //property for the quantity purchased
        public int QuantityPurchased
        {
            get
            {
                return quantityPurchased;
            }
            set
            {
                quantityPurchased = value;
            }
        }

        //calculates the total cost using the quantity and the price
        public double CalcTotalCost()
        {
            return quantityPurchased * unitPrice;
        }

        //overrides the ToString to print the customer details and the total price
        public override string ToString()
        {
            return "Customer Information: " + "\n"
                + "Name: " + customerName + "\n"
                + "Address: " + customerAddress + "\n"
                + "Total Cost: $" + CalcTotalCost() + "\n";
        }


    }
}
