namespace Application.Dtos
{
    public class ProductDto
    {
        public required string Name { get; set; }
        public string? Descripcion { get; set; }
        public required double Price { get; set; }
        public required int Type { get; set; }

    }
}
