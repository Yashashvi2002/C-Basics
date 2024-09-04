using System;

namespace ExceptionHandlingExample
{
    class ExceptionHandling
    {
        static void Main()
        {
            //In-built Exception
            try
            {
                int x = 10;
                int y = 0;
                int z = x / y;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            //Custom Exception
            try
            {
                int age = CheckAge();
                Console.WriteLine("Age is: " + age);
                double height = Height();
                Console.WriteLine("Height is: " + height);
            }
            catch (Custom_Ex ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        static int CheckAge()
        {
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            if (age < 18)
            {
                throw new Exception("Age should be greater than 18");
            }
            return age;
        }
        static double Height()
        {

            Console.WriteLine("Enter your height");
            double height = double.Parse(Console.ReadLine());
            if (height < 5)
            {
                throw new Exception("Height should be greater than 5");
            }
            return height;
        }

    }


    public class Custom_Ex : Exception
    {
        public Custom_Ex(string message) : base(message)
        {

        }
    }
}