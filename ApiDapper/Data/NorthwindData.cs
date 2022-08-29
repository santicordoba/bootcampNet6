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

        public List<Order> GetAllOrders()
        {
            using (var connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;"))
            {
                connection.Open();
                var query = "SELECT o.OrderId, o.CustomerID, od.* FROM Orders o "
                    + "INNER JOIN [Order Details] od ON o.OrderID = od.OrderID";
                var dicc = new Dictionary<int, Order>();

                connection.Query<Order, OrderDetail, Order>(query,
                (o, d) =>
                {
                    if (!dicc.TryGetValue(o.OrderID, out Order order))
                        dicc.Add(o.OrderID, order = o);
                    if (order.Details == null)
                        order.Details = new List<OrderDetail>();
                    order.Details.Add(d);
                    return order;
                },
                splitOn: "OrderID").AsQueryable();

                var orders = dicc.Values.ToList();

                return orders;
                
            }
        }

        public int DeleteOrderById(int orderId)
        {
            using (var connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;"))
            {
                connection.Open();
                var tran = connection.BeginTransaction();
                try
                {
                    var q = "DELETE FROM [Order Details] WHERE OrderID = @orderId";
                    var cant = connection.Execute(q, new { orderId }, tran);
                    q = "DELETE FROM Orders WHERE OrderId = @orderId";
                    cant += connection.Execute(q, new { orderId }, tran);
                    tran.Commit();
                    return cant;
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
                finally
                {
                    connection.Close();
                }

            }
        }
    }
}
