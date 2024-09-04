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