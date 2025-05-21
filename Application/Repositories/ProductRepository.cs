using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public sealed class ProductRepository
    {
        private ProductRepository() { }
        public static ProductRepository Instance { get; } = new();
        public ProductListDto ProductList { get; set; } = new()
        {
            Fruit = new(),
            Vegetables = new(),
            Dairy = new()
        };
    }
}
