namespace Application.ViewModel
{
    public class ProductListViewModel
    {
        public required List<ProductViewModel> Fruit { get; set; }
        public required List<ProductViewModel> Vegetables { get; set; }
        public required List<ProductViewModel> Dairy { get; set; }

    }
}
