using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModel
{
    public class AddProductViewModel
    {
        [Required(ErrorMessage = "Nombre es requerido")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Precio es requerido")]
        public required double Price { get; set; }

        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "Type es requerido")]
        public required int Type { get; set; }

    }
}
