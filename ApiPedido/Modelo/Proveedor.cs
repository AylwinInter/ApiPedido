using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPedido.Modelo
{
    public class Proveedor
    {
        [Key]
        public int Id_proveedor { get; set; }
        public string Razon_social { get; set; }
        public string Tipo_documento { get; set; }
        public string Numero_documento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}
