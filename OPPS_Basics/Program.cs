using System;

namespace EncapsulationExample
{
    //Encapsulation Example
    //Example 1
    

    public class Employee
    {
        // Private fields
        private string name;
        private int empId;
        private int salary;

        // Constructor with different parameter names
        public Employee(string empName, int employeeId, int empSalary)
        {
            // Assigning parameter values to fields without using 'this'
            name = empName;
            empId = employeeId;
            salary = empSalary;
        }

        // Method to display employee details
        public void Display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("EmpId: " + empId);
            Console.WriteLine("Salary: " + salary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Employee class
            Employee emp = new Employee("John", 101, 50000);

            // Display employee details
            emp.Display();
        }
    }

}

//Abstraction Example
namespace AbstractionExample
{
    //Abstraction Example
    //Example 2
    public abstract class Shape
    {
        public abstract void Draw();
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Circle is drawn");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle is drawn");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Circle();
            s.Draw();
            s = new Rectangle();
            s.Draw();
        }
    }
}

//Inheritance Example
namespace InheritanceExample
{
    //Inheritance Example
    //Example 3
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.Eat();
            d.Bark();
        }
    }
}

//Polymorphism Example
namespace PolymorphismExample
{
    //Polymorphism Example Runtime Polymorphism (Method Overriding)
    //Example 4
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing Shape");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Circle();
            s.Draw();
            s = new Rectangle();
            s.Draw();
        }
    }
}

//Polymorphism Example Compile Time Polymorphism (Method Overloading)
namespace PolymorphismExample
{
    //Polymorphism Example Compile Time Polymorphism (Method Overloading)
    //Example 5
    public class Add
    {
       public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Add a = new Add();
            Console.WriteLine(a.Sum(10, 20));
            Console.WriteLine(a.Sum(10, 20, 30));
            
        }
    }
}