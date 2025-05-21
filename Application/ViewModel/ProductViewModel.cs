using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModel
{
    public class ProductViewModel
    {
        public required string Name { get; set; }
        public string? Descripcion { get; set; }
        public required double Price { get; set; }
        public required int Type { get; set; }

    }
}
