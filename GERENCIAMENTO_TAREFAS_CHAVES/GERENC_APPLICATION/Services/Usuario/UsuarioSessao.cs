using GERENC_APPLICATION.DTOs.Usuario;
using GERENC_APPLICATION.Interfaces.Usuario;
using GERENC_INFRAESTRUTURA.Exception;
using GERENC_INFRAESTRUTURA.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_APPLICATION.Services.Usuario
{
    public class UsuarioSessao : IUsuarioSessao
    {
        private readonly AppDbContext _context;
        public UsuarioRetornoDto Usuario { get; private set; }

        public bool EstaLogado => Usuario != null;

        public UsuarioSessao(AppDbContext appContext)
        {
            _context = appContext;
        }

        public void Logar(UsuarioRetornoDto usuario)
        {
            Usuario = usuario;
        }

        public void Deslogar()
        {
            Usuario = null;
        }

        public async Task<IEnumerable<int>> ListaIdCategoriasDoUsuarioAsync(int idUsuario)
        {
            try
            {
                return await (from u in _context.Usuarios
                             join a in _context.Agentes
                             on u.Id equals a.UsuarioId
                             join p in _context.Pessoas
                             on a.PessoaId equals p.Id
                             join pc in _context.PessoaCategoria
                             on p.Id equals pc.PessoaId
                             where u.Id == idUsuario
                             select pc.CategoriaId)
                              .Distinct()
                              .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new InfraestruturaException(
                "Erro ao buscar IDs das categorias do usuário", ex);
            }
        }

        
    }
}
