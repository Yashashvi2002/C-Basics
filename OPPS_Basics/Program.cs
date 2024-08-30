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
