using Application.ViewModel;

namespace Application.Dtos
{
    public class ProductListDto
    {
        public required List<ProductDto> Fruit { get; set; }
        public required List<ProductDto> Vegetables { get; set; }
        public required List<ProductDto> Dairy { get; set; }

    }
}
