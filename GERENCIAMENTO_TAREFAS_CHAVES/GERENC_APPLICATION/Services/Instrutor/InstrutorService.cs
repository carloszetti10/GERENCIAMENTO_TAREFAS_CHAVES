
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GERENC_APPLICATION.DTOs.Instrutor;
using GERENC_APPLICATION.Exceptions;
using GERENC_DOMAIN.Entities.Pessoas;
using GERENC_INFRAESTRUTURA.Exception;
using GERENC_INFRAESTRUTURA.Persistence;
using Microsoft.EntityFrameworkCore;


namespace GERENC_APPLICATION.Services.Instrutor
{
    public class InstrutorService : IInstrutorService
    {
        private readonly AppDbContext _context;

        public InstrutorService(AppDbContext context)
        {
            _context = context;
        }

        public void CriarConstrutor(InstrutorCreateDto dto)
        {

            try
            {
                var instrutor = new InstrutorModel(dto.Nome, dto.Cpf);
                foreach (var categoriasCodigo in dto.CategoriaCodigos)
                {

                    var categoria = _context.Categorias.Find(categoriasCodigo);
                    if (categoria != null)
                    {
                        instrutor.AdicionarCategoria(categoria);
                    }
                    else
                    {
                        throw new AppException("Categoria inexistente");
                    }
                }
                _context.Instrutores.Add(instrutor);
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw new InfraestruturaException("Não foi possivel salvar instrutor", ex);
            }
            catch (AppException ex)
            {
                throw;
            }

            

        }

        public async Task<IEnumerable<InstrutorListDto>> ListarInstrutorAsync(IEnumerable<int> idCatAgente)
        {
            try
            {
                return await _context.Instrutores
                    .Where(i => i.PessoaCategorias.Any(pc => idCatAgente.Contains(pc.Categoria.Id)))
                    .Select(i => new InstrutorListDto
                    {
                        Codigo = i.Id,
                        Nome = i.Nome,
                        Cpf = i.Cpf,
                        ListId = i.PessoaCategorias.Select(c => c.Categoria.Id).ToList()
                    })
                    .ToListAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new InfraestruturaException("Erro ao buscar instrutores no banco", ex);
            }

        }


        public async Task<IEnumerable<InstrutorListDto>> ListarInstrutorPorNomeAsync(string termo, IEnumerable<int> idCatAgente)
        {
            try
            {


                if (string.IsNullOrWhiteSpace(termo))
                    return Enumerable.Empty<InstrutorListDto>();

                termo = termo.Trim();

                return await _context.Instrutores
                    .Where(i => i.PessoaCategorias.Any(pc => idCatAgente.Contains(pc.Categoria.Id)))
                    .Where(i => EF.Functions.Like(i.Nome, $"%{termo}%"))
                    .Select(i => new InstrutorListDto
                    {
                        Codigo = i.Id,
                        Nome = i.Nome,
                        Cpf = i.Cpf,
                        ListId = i.PessoaCategorias
                                    .Select(c => c.Categoria.Id)
                                    .ToList()
                    })
                    .ToListAsync();

            }
            catch (DbUpdateException ex)
            {
                throw new InfraestruturaException("Erro ao buscar instrutores no banco", ex);
            }

        }

        








    }

}
