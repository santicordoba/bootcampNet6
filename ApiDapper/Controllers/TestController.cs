using ApiDapper.Models;
using ApiDapper.Rules;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiDapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("/api/products")]
        public List<Product> GetAllProducts()
        {
            var rule = new ProductRule();
            return rule.GetAllProducts();
        }

        [HttpGet("/api/products/{id}")]
        public Product GetProductById(int id)
        {
            var rule = new ProductRule();
            return rule.GetProductById(id);
        }

        [HttpGet("/api/orders")]
        public List<Order> GetAllOrders()
        {
            var rule = new OrderRule();
            return rule.GetAllOrders();
        }

        [HttpDelete("/api/orders/")]
        public RespuestaDelete DeleteOrderById(int orderId)
        {
            var rule = new OrderRule();
            return rule.DeleteOrderById(orderId);
        }

    }

}
