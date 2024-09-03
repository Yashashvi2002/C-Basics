using System;

namespace BasicOperations
{
    class Program
    {
        static void Main()
        {
            // Variables and Data Types
            int num1 = 10;
            int num2 = 20;
            double num3 = 3.5;
            string text = "Hello, C#";
            bool isTrue = true;

            // Arithmetic Operations
            int sum = num1 + num2;      // Addition
            int diff = num2 - num1;     // Subtraction
            int product = num1 * num2;  // Multiplication
            double quotient = num2 / num3; // Division
            int remainder = num2 % num1;  // Modulus

            // Assignment Operations
            num1 += 5;  // Equivalent to num1 = num1 + 5
            num2 *= 2;  // Equivalent to num2 = num2 * 2

            // Comparison Operations (returns bool)
            bool isEqual = num1 == num2; // Equals
            bool isNotEqual = num1 != num2; // Not Equals
            bool isGreater = num2 > num1; // Greater than
            bool isLessOrEqual = num1 <= num2; // Less than or equal

            // Logical Operations (returns bool)
            bool andOperation = isTrue && (num1 > 5); // AND
            bool orOperation = isTrue || (num1 < 5);  // OR
            bool notOperation = !isTrue;  // NOT

            // Increment and Decrement
            num1++;  // Increment by 1
            num2--;  // Decrement by 1

            // String Operations
            string greeting = text + " World"; // Concatenation
            int length = text.Length;  // String Length
            string upper = text.ToUpper(); // Convert to Uppercase
            string lower = text.ToLower(); // Convert to Lowercase

            // Conditional Statements
            if (num1 > num2)
            {
                Console.WriteLine("num1 is greater than num2");
            }
            else
            {
                Console.WriteLine("num1 is not greater than num2");
            }

            // For Loop and while loop Implementation
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("For Loop: " + i);
            }

            int j = 0;
            while (j < 5)
            {
                Console.WriteLine("While Loop: " + j);
                j++;
            }

            // Arrays 
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("First Element: " + numbers[0]);

            // Output for all the above operations
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + diff);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);
            Console.WriteLine("Remainder: " + remainder);
            Console.WriteLine("Greeting: " + greeting);
            Console.WriteLine("Is Equal: " + isEqual);
        }
    }
}
