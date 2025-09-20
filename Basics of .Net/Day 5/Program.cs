using System;
using System.Data.SqlClient;

namespace DB_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Getting Connection ...");

            var datasource = @"LAPTOP-7OI0PJ4K\SQLEXPRESS"; // server
            var database = ".NET"; // database name

            // no usename and password for now
            //var username = "DESKTOP-LCNNVH9\\kk";
            //var password = ""; // password

            // Creating connection string
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + "; Trusted_Connection=True;";
            Console.WriteLine(connString);

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                Console.WriteLine("Opening Connection ...");
                // Open the connection
                conn.Open();
                Console.WriteLine("Connection successful!");
                //InsertStaff(conn);
                displayStaff(conn);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                // Close the connection
                conn.Close();
            }


        }
        static void InsertStaff(SqlConnection conn)
        {
            int id = 1;
            string name = "Dharmesh";
            string contact = "1234567890";
            string querry = "insert into student values (@id, @name, @contact)";

            SqlCommand cm = new SqlCommand(querry, conn);
            
            cm.Parameters.AddWithValue("@id", id);
            cm.Parameters.AddWithValue("@name", name);
            cm.Parameters.AddWithValue("@contact", contact);
            
            int rows = cm.ExecuteNonQuery();
            if (rows > 0)
            {
                Console.WriteLine("Inserted recordsuccessfully.");
            }
            else
            {
                Console.WriteLine("Insert Failed.");
            }
        }
        static void displayStaff(SqlConnection conn)
        {
            string query = "select * from student";
            SqlCommand cm = new SqlCommand(query, conn);

            SqlDataReader reader = cm.ExecuteReader();

            Console.WriteLine("Students Details :");
            while (reader.Read())
            {
                {
                    Console.WriteLine($"ID :{reader["std_id"]}");
                    Console.WriteLine($"Name :{reader["std_name"]}");
                    Console.WriteLine($"Contact :{reader["std_contact"]}");

                }
            }
        }
    }
}
