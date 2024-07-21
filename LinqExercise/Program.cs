using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             *
             * Complete every task using Method OR Query syntax.
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             *
             */

            //DONE: Print the Sum of numbers
            Console.WriteLine($"Sum of numbers: {numbers.Sum()}");

            //DONE: Print the Average of numbers
            Console.WriteLine($"Average of numbers: {numbers.Average()}");


            //DONE: Order numbers in ascending order and print to the console
            var ascNumbers = numbers.OrderBy(num => num);
            Console.WriteLine("Numbers in ascending order:");
            foreach (var num in ascNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("-----------------------------");

            //DONE: Order numbers in descending order and print to the console
            var descNumbers = numbers.OrderByDescending(num => num);
            Console.WriteLine("Numbers in descending order:");
            foreach (var num in descNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("-----------------------------");
            
            //DONE: Print to the console only the numbers greater than 6
            var greaterThan6 = numbers.Where(n => n > 6);
            Console.WriteLine("Numbers greater than 6:");
            foreach (var num in greaterThan6)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("-----------------------------");
            
            //DONE: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            var top4 = numbers.OrderBy(n => n).Take(4);
            Console.WriteLine("Four lowest numbers:");
            foreach (var num in top4)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("-----------------------------");
            
            //DONE: Change the value at index 4 to your age, then print the numbers in descending order
            //WISHFUL THINKING:
            numbers[4] = 29;
            var descendingList = numbers.OrderByDescending(n => n);
            Console.WriteLine("New descending list after [4] changed to 29:");
            foreach (var num in descendingList)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("-----------------------------");
            
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //DONE: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var filteredEmployeesByFirst = employees
                .Where(e => e.FirstName.StartsWith("C") || e.FirstName.StartsWith("S"))
                .OrderBy(e => e.FirstName);
            Console.WriteLine("Ascending order of employees whose first name starts with a 'C' or an 'S':");
            foreach (var e in filteredEmployeesByFirst)
            {
                Console.WriteLine(e.FullName);
            }
            Console.WriteLine("-----------------------------");
            
            //DONE: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var over26 = employees
                .Where(e => e.Age > 6)
                .OrderBy(e => e.Age)
                .ThenBy(e => e.FirstName);
            Console.WriteLine("Employees over 26 ordered by age and then first name:");
            foreach (var e in over26)
            {
                Console.WriteLine(e.FullName);
            }
            Console.WriteLine("-----------------------------");
            
            //DONE: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var employeesSumYoe = employees
                .Where(e => e.YearsOfExperience <= 10 && e.Age > 35)
                .Sum(e => e.YearsOfExperience);
            Console.WriteLine($"Sum of YOE of employees where YOE >= 10 and age > 35: {employeesSumYoe}");
            Console.WriteLine("-----------------------------");

            //DONE: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var employeesAvgYoe = employees
                .Where(e => e.YearsOfExperience <= 10 && e.Age < 35)
                .Average(e => e.YearsOfExperience);
            Console.WriteLine($"Average of employees YOE if YOE <= 10 and age > 35: {employeesAvgYoe}");
            Console.WriteLine("-----------------------------");
            
            //DONE: Add an employee to the end of the list without using employees.Add()
            employees = employees.Append(new Employee("Kelly", "Allen", 29, 2)).ToList();

            Console.WriteLine("Employees list with the new employee added:");
            foreach (var e in employees)
            {
                Console.WriteLine(e.FullName);
            }
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
