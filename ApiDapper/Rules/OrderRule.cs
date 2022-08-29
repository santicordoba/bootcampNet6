using ApiDapper.Data;
using ApiDapper.Models;

namespace ApiDapper.Rules
{
    public class OrderRule
    {
        public List<Order> GetAllOrders() 
        {
            var data = new NorthwindData();
            return data.GetAllOrders();
        }

        public RespuestaDelete DeleteOrderById(int OrderId)
        {
            try
            {
                var data = new NorthwindData();
                var cant = data.DeleteOrderById(OrderId);
                return new RespuestaDelete
                {
                    Cantidad = cant,
                    Result = true,
                    Mensaje = cant + " registros eliminados con exito"
                };
            }   catch (Exception e)
            {
                return new RespuestaDelete()
                {
                    Cantidad = 0,
                    Result = false,
                    Mensaje = e.Message
                };
            } 
        }
        
    }
}
