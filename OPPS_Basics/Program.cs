using System;

namespace OPPS_Basics
{
  //Encapsulation Example
  //Example 1
   public class Employee
    {
        private string name;
        private int empId;
        private int salary;
        public Employee(string name, int empId, int salary)
        {
            this.name = name;
            this.empId = empId;
            this.salary = salary;
        }

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
            Employee emp = new Employee("John", 101, 50000);
            emp.Display();
        }
        
    }
}


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