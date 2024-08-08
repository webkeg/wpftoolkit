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
