using GERENC_APPLICATION.DTOs.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_APPLICATION.Interfaces.Usuario
{
    public interface IUsuarioSessao
    {
        UsuarioRetornoDto Usuario { get; }
        bool EstaLogado { get; }

        void Logar(UsuarioRetornoDto usuario);
        void Deslogar();

        Task<IEnumerable<int>> ListaIdCategoriasDoUsuarioAsync(int idUsuario);
    }
}
