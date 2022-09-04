using Clase33_MVC.Data;
using Clase33_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Clase33_MVC.Controllers
{
    public class VehicleController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        
        public VehicleController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var vehiculos = _dbContext.Vehiculos.ToList();

            var model = new VehicleListViewModel
            {
                Vehiculos = vehiculos
                    .Select(v => new VehicleListModel
                    {
                        Id = v.Id,
                        Dominio = v.Dominio,
                        AnoFabricacion = v.AnoFabricacion
                    })
                    .ToList()
            };

            return View("List", model);
        }
    }
}
