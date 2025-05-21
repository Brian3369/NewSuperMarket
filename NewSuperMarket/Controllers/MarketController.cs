using Application.Dtos;
using Application.Service;
using Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace NewSuperMarket.Controllers
{
    public class MarketController : Controller
    {
        private readonly ProductService productService;
        public MarketController()
        {
            productService = new ProductService();
        }
        public IActionResult Index(string? message = null, string? messageType = null)
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

            ViewBag.Message = message;
            ViewBag.MessageType = messageType;
            return View(productListModel);
        }

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(AddProductViewModel product)
        {
            try
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
                return RedirectToRoute(new { controller = "Market", action = "Index", message = "Producto creado correctamente", messageType = "success" });
            }
            catch
            {
                return RedirectToRoute(new { controller = "Market", action = "Index", message = "Error creando el producto", messageType="alert"});
            }
        }
    }
}
