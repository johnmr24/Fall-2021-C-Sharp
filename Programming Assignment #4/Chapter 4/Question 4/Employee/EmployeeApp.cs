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
    class EmployeeApp
    {
        static void Main()
        {
            Employee e1 = new Employee(); //declares a new employee
            e1.EmployeeNumber = "1206456"; //sets the employee number
            e1.FirstName = "David"; //sets the first name
            e1.LastName = "Burton"; //sets the last name
            e1.DateOfHire = "1/20/19"; //sets the date of hire
            e1.JobDescription = "Science Teacher"; //sets the job description
            e1.Department = "Teching"; //sets the department
            e1.MonthlySalary = 5000; //sets the monthly salary

            WriteLine("Returning name with only a space...");
            WriteLine(e1.ReturnFullName()); //displays the name with a space

            WriteLine();

            WriteLine("Returning name with a comma in between...");
            WriteLine(e1.ReturnFullName(",")); //displays the name with a comma

            WriteLine();
            WriteLine(e1);

            
        }
    }
}
