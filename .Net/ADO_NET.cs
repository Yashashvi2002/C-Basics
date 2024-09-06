using System;
using System.Data;
using System.Data.SqlClient;

namespace ADO_DOTNET
{
    internal class Program
    {
        static void Main()
        {
            Program.ConnectToDatabase();
        }

        static void ConnectToDatabase()
        {
            string cs = "Data Source=LAPTOP-TF84CB6M\\SQLEXPRESS;Initial Catalog=ado_db;Integrated Security=True";
            //Establishing the connection with the database
            using SqlConnection con = new SqlConnection(cs);

            //Creating the SQL command
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employees", con);
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    Console.WriteLine("Connected to database");
                }
                //Executing the command
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine();
                while (reader.Read())
                {
                    Console.WriteLine($"{reader["EmployeeID"],-10} {reader["FirstName"],-15} {reader["LastName"],-15} {reader["Position"],-20} {reader["Salary"],10:C}");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }


        }
    }
}

//Output
//Connected to database

//1          John            Doe             Software Engineer    $60,000.00
//2          Jane            Smith           Project Manager      $75,000.00
//3          Michael         Johnson         Analyst              $50,000.00
//4          Emily           Davis           HR Manager           $65,000.00


//Creating a table in the database
namespace ADO_DOTNET
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the Number of data entry: ");
            int n = int.Parse(Console.ReadLine());

            CreateTable();
            for (int i = 0; i < n; i++)
            {
                InsertData();
            }
            Update();
            Delete();

        }

        //Creating a table in the database
        static void CreateTable()
        {
            string cs = "Data Source=LAPTOP-TF84CB6M\\SQLEXPRESS;Initial Catalog=ado_db;Integrated Security=True";
            string query = @"
                CREATE TABLE Employees (
                    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
                    FirstName NVARCHAR(50),
                    LastName NVARCHAR(50),
                    Position NVARCHAR(50),
                    Salary DECIMAL(10, 2)
                );
            ";
            using SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table created successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        //Inserting data into the table
        static void InsertData()
        {
            string cs = "Data Source=LAPTOP-TF84CB6M\\SQLEXPRESS;Initial Catalog=ado_db;Integrated Security=True";
            using SqlConnection con = new SqlConnection(cs);
            Console.WriteLine("First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Position");
            string position = Console.ReadLine();
            Console.WriteLine("Salary");
            string salary = Console.ReadLine();
            string query = "INSERT INTO Employees (FirstName, LastName, Position, Salary) VALUES (@FirstName, @LastName, @Position, @Salary)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@FirstName", firstName);
            cmd.Parameters.AddWithValue("@LastName", lastName);
            cmd.Parameters.AddWithValue("@Position", position);
            cmd.Parameters.AddWithValue("@Salary", salary);
            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Data inserted successfully");
                }
                else
                {
                    Console.WriteLine("Data insertion failed");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }


        }

        //Updating data in the table
        static void Update()
        {
            string cs = "Data Source=LAPTOP-TF84CB6M\\SQLEXPRESS;Initial Catalog=ado_db;Integrated Security=True";
            using SqlConnection con = new SqlConnection(cs);
            Console.WriteLine("Employee ID");
            string id = Console.ReadLine();
            Console.WriteLine("First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Position");
            string position = Console.ReadLine();
            Console.WriteLine("Salary");
            string salary = Console.ReadLine();
            string query = "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, Position = @Position, Salary = @Salary WHERE EmployeeID = @EmployeeID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@EmployeeID", id);
            cmd.Parameters.AddWithValue("@FirstName", firstName);
            cmd.Parameters.AddWithValue("@LastName", lastName);
            cmd.Parameters.AddWithValue("@Position", position);
            cmd.Parameters.AddWithValue("@Salary", salary);
            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Data updated successfully");
                }
                else
                {
                    Console.WriteLine("Data updation failed");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        //Deleting data from the table
        static void Delete()
        {
            string cs = "Data Source=LAPTOP-TF84CB6M\\SQLEXPRESS;Initial Catalog=ado_db;Integrated Security=True";
            using SqlConnection con = new SqlConnection(cs);
            Console.WriteLine("Employee ID");
            string id = Console.ReadLine();
            string query = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@EmployeeID", id);
            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Data deleted successfully");
                }
                else
                {
                    Console.WriteLine("Data deletion failed");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}