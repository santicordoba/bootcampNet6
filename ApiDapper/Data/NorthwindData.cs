using ApiDapper.Models;
using Dapper;
using System.Data.SqlClient;

namespace ApiDapper.Data
{
    public class NorthwindData
    {
        public List<Product> GetAllProducts()
        {
            using (var connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;"))
            {
                connection.Open();
                var query = "SELECT * FROM Products";
                var listProducts = connection.Query<Product>(query).ToList();
                return listProducts;
            }
        }
        
        public Product GetProductById(int id)
        {
            using (var connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;"))
            {
                connection.Open();
                var query = "SELECT * FROM Products WHERE ProductId = @id";
                var product = connection.QueryFirstOrDefault<Product>(query, new { id });
                return product;
            }
        }

        public Product GetProductById(Product p)
        {
            using (var connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;"))
            {
                connection.Open();
                var query = "SELECT * FROM Products WHERE ProductId = @ProductId";
                var product = connection.QueryFirstOrDefault<Product>(query, p);
                return product;
            }
        }

    }
}
