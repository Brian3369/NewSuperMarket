using Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace NewSuperMarket.Controllers
{
    public class MarketController : Controller
    {
        public IActionResult Index()
        {
            List<ProductViewModel> productsFruit = new() 
            { 
                new ProductViewModel { Name = "Fresa", Descripcion = "1 libra", Price = 10.10, Type = 1 },
                new ProductViewModel { Name = "Zanahoria", Descripcion = "1 zanahoria", Price = 2.00, Type = 2 },
                new ProductViewModel { Name = "Queso", Descripcion = "Paquete 200 rebanadas", Price = 20.00, Type = 3 }
            };

            List<ProductViewModel> productsVegetable = new()
            {
                new ProductViewModel { Name = "Fresa", Descripcion = "1 libra", Price = 10.10, Type = 1 },
                new ProductViewModel { Name = "Zanahoria", Descripcion = "1 zanahoria", Price = 2.00, Type = 2 },
                new ProductViewModel { Name = "Queso", Descripcion = "Paquete 200 rebanadas", Price = 20.00, Type = 3 }
            };

            List<ProductViewModel> productsDairy = new()
            {
                new ProductViewModel { Name = "Fresa", Descripcion = "1 libra", Price = 10.10, Type = 1 },
                new ProductViewModel { Name = "Zanahoria", Descripcion = "1 zanahoria", Price = 2.00, Type = 2 },
                new ProductViewModel { Name = "Queso", Descripcion = "Paquete 200 rebanadas", Price = 20.00, Type = 3 }
            };

            ProductListViewModel productList = new ProductListViewModel
            {
                Fruit = productsFruit,
                Vegetables = productsVegetable,
                Dairy = productsDairy
            };
            return View(productList);
        }

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(AddProductViewModel product)
        {
            return View();
        }
        //public IActionResult AddProduct(string Name, double Price, string Descripcion, int Type)
        //{
        //    return View();
        //}
    }
}
