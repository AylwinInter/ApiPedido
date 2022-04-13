using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPedido.Data
{
    public class SqlConfiguracion
    {
        public SqlConfiguracion(string connectionString) => ConnectionString = connectionString;
        public string ConnectionString { get; set; }
    }
}
