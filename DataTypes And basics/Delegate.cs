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



            //Multicast Delegate 
            Console.WriteLine("\nMulticast Delegate");
            obj = Multiplication;
            obj += Addition;
            obj(10, 20);

        }
    }
}



//Delegate to access Private Method of a class from another class
namespace Delegate
{
    public delegate void Delegate(string str);
    class Program
    {
        static void Main()
        {
            Delegate del = Print;
            Test.TestMethod(del);
        }

        private static void Print(string str)
        {
            Console.WriteLine(str);
        }
    }


    class Test
    {
        public static void TestMethod(Delegate del)
        {
            del("Hello World");
        }
    }
}

//Delegate basically used for communication and to call a method from another class(callback)
namespace Delegates
{
    public delegate void CallBack(int num);
    class Program
    {
        static void Main()
        {
            CallBack callback = Print;
            Iteration.PrintNumbers(callback);
        }
        static void Print(int num)
        {
            Console.WriteLine(num);
        }
    }

    class Iteration
    {
        public static void PrintNumbers(CallBack callback)
        {
            for (int i = 0; i < 10; i++)
            {
                callback(i);
            }
        }
    }
}


//Delegate Types : Func , Action, Predicate
namespace DelegateType
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fuc: Function that takes input and returns output
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine("Addition is: " + add(10, 20));

            Func<int, string> value = GetMessage;
            Console.WriteLine(value(100));

            //Action: Function that takes input but does not return output
            Action<int, int> sum = (a, b) => Console.WriteLine("Sum is: " + (a + b));
            sum(10, 20);

            Action<string> print = PrintMessage;
            print("Hello World");

            //Predicate: Function that takes input and returns boolean output
            Predicate<int> isEven = (a) => a % 2 == 0;
            Console.WriteLine(isEven(10));

            Predicate<int> isPositive = CheckNum;
            Console.WriteLine(isPositive(10));
            Console.WriteLine(isPositive(-20));
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static string GetMessage(int value)
        {
            return "Value is: " + value;
        }
        public static void PrintMessage(string msg)
        {
            Console.WriteLine(msg);
        }

        public static bool CheckNum(int num)
        {
            return num > 0;
        }
    }
}


