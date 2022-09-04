using Clase33_MVC.Data;
using Clase33_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clase33_MVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var ctx = new ApplicationDbContext();

            var usuarios = ctx.Users.ToList();

            List<UserViewModel> models = new List<UserViewModel>();
            
            foreach(var usu in usuarios)
            {
                UserViewModel user = new UserViewModel()
                {
                    Id = usu.Id,
                    UserName = usu.UserName
                };

                models.Add(user);
            }
            
            return View(models);
        }
    }
}
