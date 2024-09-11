namespace Delegate
{
    //Delegate should have same return type and parameters as the method
    //Single Delegate can be used to call multiple methods
    //Delegate is a reference type variable that holds the reference to a method
    //Delegate is a type safe function pointer
    //Delegate is used to invoke the methods at runtime
    //Delegate is used to create callback methods
    //Delegate is used to pass methods as arguments to other methods
    //Delegate is used to define the signature of the method

    public delegate void Calculation(int a, int b);
    class Program
    {
        static void Addition(int a, int b)
        {
            Console.WriteLine("Addition is: " + (a + b));
        }
        static void Subtraction(int a, int b)
        {
            Console.WriteLine("Subtraction is: " + (a - b));
        }
        static void Multiplication(int a, int b)
        {
            Console.WriteLine("Multiplication is: " + (a * b));
        }
        static void Divisiion(int a, int b)
        {
            Console.WriteLine("Division is: " + (a / b));
        }

        static void Main()
        {
            //Same Object can be used to call different methods
            Calculation obj = new Calculation(Addition);
            obj.Invoke(10, 20); //invoke method is used to call the delegate
            obj = Subtraction;
            obj(20, 10);
            obj = Multiplication;
            obj(10, 20);
            obj = Divisiion;
            obj(20, 10);

            //Different object can be use to call different methods
            Calculation obj1 = new Calculation(Addition);
            obj1(10, 20);
            Calculation obj2 = new Calculation(Subtraction);
            obj2(20, 10);
            Calculation obj3 = new Calculation(Multiplication);
            obj3(10, 20);
            obj = Divisiion;
            obj(20, 10);


        }
    }
}
