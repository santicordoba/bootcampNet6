namespace Clase33_MVC.Data.Entities
{
    public class Vehiculo : BaseEntity
    {
        public string Dominio { get; set; }
        public string NumeroChasis { get; set; }
        public string Propietario { get; set; }
        public int AnoFabricacion { get; set; }
    }
}
