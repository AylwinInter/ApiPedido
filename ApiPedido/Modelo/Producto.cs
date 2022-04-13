using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPedido.Modelo
{
    public class Producto
    {
        [Key]
        public int Id_producto { get; set; }
        [Required]
        public string Codigo_barra { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
