using EF_Database_First.Models;
using EFDatabaseFirst.Namespace;

var ctx = new NorthwindContext();

var categories =  ctx.Categories;

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
