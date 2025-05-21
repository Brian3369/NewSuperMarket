using Application.ViewModel;
using Application.Dtos;
using Application.Repositories;
using Application.Enum;

namespace Application.Service
{
    public class ProductService
    {
        public void AddProduct(ProductDto product)
        {
            switch (product.Type)
            {
                case (int)ProductType.Fruit:
                    ProductRepository.Instance.ProductList.Fruit.Add(product);
                    break;
                case (int)ProductType.Vegetables:
                    ProductRepository.Instance.ProductList.Vegetables.Add(product);
                    break;
                case (int)ProductType.Dairy:
                    ProductRepository.Instance.ProductList.Dairy.Add(product);
                    break;
                default:
                    throw new ArgumentException("Invalid product type");
            }
        }

        public ProductListDto GetAll()
        {
            return ProductRepository.Instance.ProductList;
        }
    }
}
