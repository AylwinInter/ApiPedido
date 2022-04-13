using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPedido.Modelo
{
    public class Compra
    {
        [Key]
        public int Id_compra { get; set; }
        [Required]
        public int Id_user { get; set; }
        [Required]
        public int Id_proveedor { get; set; }
        [Required]
        public string Tipo_comprobante { get; set; }
        [Required]
        public string Correlativo { get; set; }
        public double Iva { get; set; }
        public string Estado { get; set; }
    }
}
