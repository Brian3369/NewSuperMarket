using Application.ViewModel;
using Application.Dtos;

namespace Application.Service
{
    public class ProductService
    {
        public ProductListDto productList { get; set; }
        public ProductService() { 
            productList = new() {
                Fruit = new(),
                Vegetables = new(),
                Dairy = new()
            };
        }

        public void AddProduct(ProductDto product)
        {
            switch (product.Type)
            {
                case 1:
                    productList.Fruit.Add(product);
                    break;
                case 2:
                    productList.Vegetables.Add(product);
                    break;
                case 3:
                    productList.Dairy.Add(product);
                    break;
                default:
                    throw new ArgumentException("Invalid product type");
            }
        }

        public ProductListDto GetAll()
        {
            return productList;
        }
    }
}
