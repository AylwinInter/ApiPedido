using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPedido.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private SqlConfiguracion _connectionString;
        public UsuarioRepository(SqlConfiguracion connectionString)
        {
            _connectionString = connectionString;
        }
        protected SqlConnection dbConnectio()
        {
            return new SqlConnection(_connectionString.ConnectionString);
        }
        public Task<bool> DeleteUsuario()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IUsuarioRepository>> GetAllUsuario()
        {
            throw new NotImplementedException();
        }

        public Task<IUsuarioRepository> GetUsuarioDetail()
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertUsuario()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUsuario()
        {
            throw new NotImplementedException();
        }
    }
}
