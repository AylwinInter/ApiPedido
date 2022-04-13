using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPedido.Modelo
{
    public class Rol
    {
        [Key]
        public int Id_rol { get; set; }
        public string rol { get; set; }
    }
}
