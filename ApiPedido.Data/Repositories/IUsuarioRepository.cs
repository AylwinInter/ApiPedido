using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPedido.Data.Repositories
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<IUsuarioRepository>> GetAllUsuario();
        Task<IUsuarioRepository> GetUsuarioDetail();
        Task<bool> InsertUsuario();
        Task<bool> UpdateUsuario();
        Task<bool> DeleteUsuario();
    }
}
