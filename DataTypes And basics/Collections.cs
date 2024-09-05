//Collections are of two types Generic and Non-generic
//Non-generic collections are not type safe and can store any type of data
using System;

namespace Generics
{
    class DataStore<T>
    {
        public T[] data = new T[4];

        // Method to add or update the data at the specified index
        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 4)
            {
                data[index] = item;
            }
        }
        // Method to get the data at the specified index
        public T GetData(int index)
        {
            if (index >= 0 && index < 10)
            {
                return data[index];
            }
            else
            {
                return default(T);
            }
        }

        // Method to print the entire array
        public void PrintData()
        {
            Console.Write("\nArray = [");
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{data[i]}  ");
            }
            Console.WriteLine("]");
        }
    }

    // Generic class with two type parameters
    class KeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public void GenericMethod()
        {
            Console.WriteLine("\nKey type: " + typeof(TKey) + ", value: " + Key);
            Console.WriteLine("Value type: " + typeof(TValue) + ", value: " + Value);
        }
    }

    // Generic class with one type parameter
    public class MyGenericClass<T>
    {
        private T genericField;

        public MyGenericClass(T value)
        {
            genericField = value;
        }

        public void GenericMethod(T genericParameter)
        {
            Console.WriteLine("\nParameter type: " + typeof(T) + ", value: " + genericParameter);
            Console.WriteLine("Field type: " + typeof(T) + ", value: " + genericField);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the generic class
            DataStore<string> cities = new DataStore<string>();
            cities.AddOrUpdate(0, "Mumbai");
            cities.AddOrUpdate(1, "Chicago");
            cities.AddOrUpdate(2, "London");
            string result = cities.GetData(3);
            Console.WriteLine("City: " + result);
            cities.PrintData();

            DataStore<int> empIds = new DataStore<int>();
            empIds.AddOrUpdate(0, 50);
            empIds.AddOrUpdate(1, 65);
            empIds.AddOrUpdate(2, 89);
            int id = empIds.GetData(1);
            Console.WriteLine("Employee ID: " + id);

            KeyValuePair<int, string> kvp1 = new KeyValuePair<int, string>();
            kvp1.Key = 100;
            kvp1.Value = "Hundred";
            kvp1.GenericMethod();

            KeyValuePair<string, string> kvp2 = new KeyValuePair<string, string>();
            kvp2.Key = "IT";
            kvp2.Value = "Information Technology";
            kvp2.GenericMethod();

            MyGenericClass<int> intGenericClass = new MyGenericClass<int>(10);
            intGenericClass.GenericMethod(200);

            MyGenericClass<string> stringGenericClass = new MyGenericClass<string>("Hello, World!");
            stringGenericClass.GenericMethod("Hello, .NET!");

            MyGenericClass<double> doubleGenericClass = new MyGenericClass<double>(10.5);
            doubleGenericClass.GenericMethod(20.5);
        }
    }
}


namespace NonGeneric
{
    class DataStore
    {
        public object[] data = new object[4];

        // Method to add or update the data at the specified index
        public void AddOrUpdate(int index, object item)
        {
            if (index >= 0 && index < 4)
            {
                data[index] = item;
            }
        }
        // Method to get the data at the specified index
        public object GetData(int index)
        {
            if (index >= 0 && index < 10)
            {
                return data[index];
            }
            else
            {
                return null;
            }
        }

        // Method to print the entire array
        public void PrintData()
        {
            Console.Write("\nArray = [");
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{data[i]}  ");
            }
            Console.WriteLine("]");
        }
    }


    class KeyValuePair
    {
        public object Key { get; set; }
        public object Value { get; set; }

        public void GenericMethod()
        {
            Console.WriteLine("\nKey type: " + Key.GetType() + ", value: " + Key);
            Console.WriteLine("Value type: " + Value.GetType() + ", value: " + Value);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the non-generic class
            DataStore cities = new DataStore();
            cities.AddOrUpdate(0, "Mumbai");
            cities.AddOrUpdate(1, "Chicago");
            cities.AddOrUpdate(2, 1123);
            cities.AddOrUpdate(3, 10.5);
            string city = (string)cities.GetData(0);
            Console.WriteLine("City: " + city);
            cities.PrintData();

            KeyValuePair kvp1 = new KeyValuePair();
            kvp1.Key = 100;
            kvp1.Value = "Hundred";
            kvp1.GenericMethod();

            KeyValuePair kvp2 = new KeyValuePair();
            kvp2.Key = "India";
            kvp2.Value = "New Delhi";
            kvp2.GenericMethod();
        }
    }
}