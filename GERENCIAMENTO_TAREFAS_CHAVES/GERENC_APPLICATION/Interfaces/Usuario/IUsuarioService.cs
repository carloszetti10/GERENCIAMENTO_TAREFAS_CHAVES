using GERENC_APPLICATION.DTOs.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_APPLICATION.Interfaces.Usuario
{
    public interface IUsuarioService
    {
        void CriarUsuario(UsuarioCreateDto dto);

        Task<UsuarioRetornoDto> Logar(UsuarioLogarDto dto);

        Task<IEnumerable<UsuarioListDto>> ListUsuariosAsync();
    }

}
