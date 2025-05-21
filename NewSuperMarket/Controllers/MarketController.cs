using Application.Dtos;
using Application.Service;
using Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace NewSuperMarket.Controllers
{
    public class MarketController : Controller
    {
        private readonly ProductService productService
        public MarketController()
        {
            productService = new ProductService();
        }
        public IActionResult Index()
        {
            ProductListDto productListDto = productService.GetAll();

            ProductListViewModel productListModel = new()
            {
                Fruit = productListDto.Fruit.Select(s => new ProductViewModel()
                {
                    Name = s.Name,
                    Price = s.Price,
                    Descripcion = s.Descripcion,
                    Type = s.Type
                }).ToList(),
                Vegetables = productListDto.Vegetables.Select(s => new ProductViewModel()
                {
                    Name = s.Name,
                    Price = s.Price,
                    Descripcion = s.Descripcion,
                    Type = s.Type
                }).ToList(),
                Dairy = productListDto.Dairy.Select(s => new ProductViewModel()
                {
                    Name = s.Name,
                    Price = s.Price,
                    Descripcion = s.Descripcion,
                    Type = s.Type
                }).ToList()
            };
            return View(productListModel);
        }

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(AddProductViewModel product)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            productService.AddProduct(new ProductDto()
            {
                Name = product.Name,
                Price = product.Price,
                Descripcion = product.Descripcion,
                Type = product.Type
            });
            return View();
        }
    }
}
