using System.Data.SqlClient;

var connectionString = @"Server=.\SQLEXPRESS;Database=Northwind;Trusted_Connection=yes;";

using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();
    var command = new SqlCommand("SELECT * FROM Customers", connection);
    using (var reader = command.ExecuteReader())
    {
        while (reader.Read())
        {
            Console.WriteLine($"{reader["CustomerID"]} - {reader["CompanyName"]} - {reader["ContactName"]}");
        }
    }

    command = new SqlCommand("SELECT * FROM Suppliers", connection);
    using (var reader = command.ExecuteReader())
    {
        while (reader.Read())
        {
            Console.WriteLine($"{reader["SupplierID"]} - {reader["CompanyName"]} - {reader["ContactName"]}");
        }
    }


}
