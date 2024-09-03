using System;

namespace DataTypes
{
    class Program
    {
        static void Main()
        {
            // Value Types
            int intVar = 42;              // Integer (32-bit)
            float floatVar = 3.14F;        // Floating-point (32-bit)
            double doubleVar = 3.14159;    // Double precision floating-point (64-bit)
            char charVar = 'A';            // Character (16-bit Unicode)
            bool boolVar = true;           // Boolean (true or false)
            decimal decimalVar = 19.99M;   // Decimal (128-bit)

            // Reference Types
            string stringVar = "Hello, C#"; // String 
            object objectVar = 123;         // Object 
            dynamic dynamicVar = "Dynamic"; // Dynamic 

            // Output
            Console.WriteLine("Value Types:");
            Console.WriteLine("int: " + intVar);
            Console.WriteLine("float: " + floatVar);
            Console.WriteLine("double: " + doubleVar);
            Console.WriteLine("char: " + charVar);
            Console.WriteLine("bool: " + boolVar);
            Console.WriteLine("decimal: " + decimalVar);

            Console.WriteLine("\nReference Types:");
            Console.WriteLine("string: " + stringVar);
            Console.WriteLine("object: " + objectVar);
            Console.WriteLine("dynamic: " + dynamicVar);
        }
    }
}
