//Generics
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