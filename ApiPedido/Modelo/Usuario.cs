using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPedido.Modelo
{
    public class Usuario
    {
        [Key]
        public int Id_user { get; set; }
        [Required]
        public string first_name { get; set; }
        [Required]
        public string last_name { get; set; }
        public string direction { get; set; }
        public string phone { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
        [Required]
        public int rol { get; set; }
    }
}
