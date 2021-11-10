using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Almacen.Models
{
    public class Producto
    {
        [Key]
        public string producto { get; set; }
        [Display(Name = "Nombre del producto")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "El nombre debe contener entre 3 a 60 caracteres")]
        [Required(ErrorMessage = "El nombre del producto es requerido")]
        public string almacen { get; set; }
        [Display(Name = "nombre o nro de almacen")]
        public string informacion { get; set; }
        [Url]
        [Display(Name = "informacion de almacen")]
        public string link { get; set; }

    }
}
