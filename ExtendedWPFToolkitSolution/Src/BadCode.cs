/#

Issues Included in the Code
Unused Variables: unusedVar, unusedList.
Long Methods with Multiple Responsibilities: ProcessData, DoWork.
Magic Numbers: 1500, 5, 0.05.
Inefficient String Concatenation in a Loop: String concatenation inside a loop without using StringBuilder.
Non-Disposed Object: StreamReader is not disposed of correctly.
Empty Catch Block: Swallowing exceptions without handling them.
Hardcoded File Path: C:\Users\username\Documents\file.txt.
Non-Descriptive Variable Names: x, y.
Unnecessary LINQ Usage: Using LINQ for something that could be done with a simple loop.
Nested Loops: Nested loops that increase complexity unnecessarily.
Incorrect Discount Calculation: The discount calculation is incorrect and hardcoded.
Class with Multiple Responsibilities: DataProcessor handles too many different things.
Poorly Named Methods: DoWork, Process, GetData.
Unnecessary Object Creation: Creating objects that aren't needed, like temp in DoWork.
Evaluation Criteria
When reviewing the code, the candidate should identify the following:

Refactoring Opportunities: Suggest splitting methods into smaller, single-responsibility methods, removing unused variables, and renaming classes/methods to be more descriptive.
Improving Efficiency: Recommend using a StringBuilder for string concatenation inside loops.
Proper Resource Management: Dispose of unmanaged resources properly using using statements.
Error Handling: Handle exceptions appropriately, providing meaningful error messages or logging.
Avoiding Magic Numbers: Replace magic numbers with constants or configuration values.
Improving Readability: Use descriptive variable names, remove unnecessary code, and simplify complex logic.
Code Smells: Identify and address other common code smells, such as large classes or methods, improper exception handling, and poor naming conventions.
This code should give the candidate plenty of material to work with during the code review exercise.

#/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeReviewTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the application!");

            // Unused variable
            int unusedVar = 100;

            // Long method with multiple responsibilities
            ProcessData();

            // Magic numbers
            var result = CalculateDiscount(1500, 5);

            Console.WriteLine("Discounted price: " + result);

            // Inefficient string concatenation in a loop
            string concatenatedString = "";
            for (int i = 0; i < 100; i++)
            {
                concatenatedString += "Iteration: " + i.ToString() + "\n";
            }
            Console.WriteLine(concatenatedString);

            // Non-disposed object
            var reader = new System.IO.StreamReader("somefile.txt");
            var content = reader.ReadToEnd();
            Console.WriteLine(content);

            // Empty catch block
            try
            {
                int.Parse("NotAnInt");
            }
            catch (Exception ex)
            {
                // Do nothing
            }

            // Hardcoded file path
            var filePath = "C:\\Users\\username\\Documents\\file.txt";
            Console.WriteLine("File path: " + filePath);

            // Non-descriptive variable names
            var x = new DataProcessor();
            var y = x.DoWork();

            Console.WriteLine("Processed data: " + y);
        }

        // Method doing too many things
        static void ProcessData()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Unnecessary LINQ usage
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

            // Unused list
            var unusedList = new List<int>();

            // Nested loops
            foreach (var number in evenNumbers)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Number: " + number + ", Iteration: " + i);
                }
            }
        }

        // Method with hardcoded values
        static double CalculateDiscount(double price, int percentage)
        {
            // Unnecessary if statement
            if (percentage > 0)
            {
                // Magic numbers and incorrect calculation
                return price - (price * 0.05);
            }
            else
            {
                return price;
            }
        }
    }

    // Class with multiple responsibilities and poor naming
    class DataProcessor
    {
        public string DoWork()
        {
            // Unnecessary object creation
            var temp = new List<string>();

            // Poorly named method
            return GetData() + Process();
        }

        // Method does not describe its purpose
        private string GetData()
        {
            return "Data";
        }

        // Method with too many side effects
        private string Process()
        {
            var now = DateTime.Now;

            if (now.Hour > 12)
            {
                return "Afternoon Processing";
            }
            else
            {
                return "Morning Processing";
            }
        }
    }
}
