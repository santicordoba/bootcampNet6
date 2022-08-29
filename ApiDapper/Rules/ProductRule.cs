using ApiDapper.Models;
using ApiDapper.Data;

namespace ApiDapper.Rules
{
    public class ProductRule
    {
        public List<Product> GetAllProducts()
        {
            var data = new NorthwindData();

            return data.GetAllProducts();
        }
        
        public Product GetProductById(int id){
            var data = new NorthwindData();
            return data.GetProductById(id);
        }

    }
}
