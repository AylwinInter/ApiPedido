using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPedido.Modelo
{
    public class Menu
    {
        [Key]
        public int Id_menu { get; set; }
        [Required]
        public string menu { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Stok { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
