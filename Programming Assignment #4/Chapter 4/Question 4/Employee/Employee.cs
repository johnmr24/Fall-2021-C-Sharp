//John Reichenbach
//Programming Assignment 4, Chapter 4, Question 4
//CS 285-001
//10-14-21

using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace EmployeeApp
{
    public class Employee
    {
        private string employeeNumber; //holds the employee number
        private string firstName; //holds the first name
        private string lastName; //holds the last name
        private string dateOfHire; //holds the date of hire
        private string jobDescription; //holds the job description
        private string department; //holds the department
        private double monthlySalary; //holds the monthly salary

        //default constructor with no parameters that sets the data to blank
        public Employee()
        {
            employeeNumber = "";
            firstName = "";
            lastName = "";
            dateOfHire = "";
            jobDescription = "";
            department = "";
            monthlySalary = 0.0;
        }

        //default constructor with all parameters that sets the data based on the parameters
        public Employee(string number, string first, string last, string date,
                 string desc, string dep, double salary)
        {
            employeeNumber = number;
            firstName = first;
            lastName = last;
            dateOfHire = date;
            jobDescription = desc;
            department = dep;
            monthlySalary = salary;
        }

        //property for the employee number
        public string EmployeeNumber
        {
            get
            {
                return employeeNumber;
            }
            set
            {
                employeeNumber = value;
            }
        }

        //property for the first name
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        //property for the last name
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        //property for the date of hire
        public string DateOfHire
        {
            get
            {
                return dateOfHire;
            }
            set
            {
                dateOfHire = value;
            }
        }

        //property for the job description
        public string JobDescription
        {
            get
            {
                return jobDescription;
            }
            set
            {
                jobDescription = value;
            }
        }

        //property for the department
        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }

        //property for the monthly salary
        public double MonthlySalary
        {
            get
            {
                return monthlySalary;
            }
            set
            {
                monthlySalary = value;
            }
        }

        //returns the full name with only a space in between
        public string ReturnFullName()
        {
            return firstName + " " + lastName;
        }

        //returns the full name with a comma in between first and last
        public string ReturnFullName(string format)
        {
            return firstName + format + " " + lastName;
        }

        //overrides the ToString method to print the data
        public override string ToString()
        {
            return "Employee Number: " + employeeNumber + "\n"
                + "First Name: " + firstName + "\n"
                + "Last Name: " + lastName + "\n"
                + "Date Of Hire: " + dateOfHire + "\n"
                + "Job Description: " + jobDescription + "\n"
                + "Department: " + department + "\n"
                + "Monthly Salary: " + monthlySalary + "\n";
        }

    }

}
