using EF_Database_First.Models;
using EFDatabaseFirst.Namespace;
using Microsoft.EntityFrameworkCore;

var ctx = new NorthwindContext();

/*var categories =  ctx.Categories;

foreach (var category in categories)
{
    Console.WriteLine($"Categoria: {category.CategoryName}");
}

var nuevaCategoria = new Category
{
    CategoryName = "Nueva Categoria",
    Description = "Sarasa"
};

categories.Add(nuevaCategoria);

var categories2 = ctx.Categories;

foreach (var category in categories2)
{
    Console.WriteLine($"Categoria: {category.CategoryName}");
}
*/


/*// CREACION NUEVO CUSTOMER

var newCustomer = new Customer()
{
    CustomerId = "SANTI",
    CompanyName = "Dangotoons",
    Orders = new List<Order>()
};

newCustomer.Orders.Add(new Order
{
    CustomerId = "SANTI",
    OrderDate = DateTime.Now,
});

// ALTA CUSTOMER

ctx.Add(newCustomer);
ctx.SaveChanges();*/

// EDITAR
/*var reg = ctx.Customers.FirstOrDefault(r => r.CustomerId == "SANTI");
if(reg != null)
{
    reg.CompanyName = "DANGO";
    ctx.SaveChanges();
}*/

// ELIMINAR

// eliminar las relaciones
var regOrders = ctx.Orders.Where(r => r.CustomerId == "SANTI");
ctx.RemoveRange(regOrders);

// ahora podemos borrar el customer

var regCustomer = ctx.Customers.FirstOrDefault(r => r.CustomerId == "SANTI");
ctx.Remove(regCustomer);


ctx.SaveChanges();

Console.WriteLine("LISTA DE CUSTOMERS");
Console.WriteLine();
Console.WriteLine("===============================================================");
var customers = ctx.Customers.Select(dato => new { IdCustomer = dato.CustomerId, CompanyName = dato.CompanyName });

foreach (var c in customers)   
{
    Console.WriteLine($"ID: {c.IdCustomer} - Company Name: {c.CompanyName}");
}

Console.WriteLine("===============================================================");
Console.WriteLine();

Console.Write("Ingrese el IDCustomer que desea consultar: ");
string idCustomer = Console.ReadLine();

bool anyCustomer = ctx.Customers.Any(dato => dato.CustomerId == idCustomer.ToUpper());

if (anyCustomer)
{
    Console.WriteLine("ENCONTRADO");
    var customer = ctx.Customers.Include(i => i.Orders)
        .FirstOrDefault(dato => dato.CustomerId == idCustomer.ToUpper());
    Console.WriteLine($"{customer.ContactName}");
    Console.WriteLine($"Cantidad de ordenes: {customer.Orders.Count}");
    Console.WriteLine($"Lista de ordenes");
    foreach(var item in customer.Orders)
    {
        Console.WriteLine($"OrderId: {item.OrderId} - OrderDate: {item.OrderDate}");
    }
} else
{
    Console.WriteLine("El id customer no existe en la BD");
}

Console.WriteLine("===============================================================");
