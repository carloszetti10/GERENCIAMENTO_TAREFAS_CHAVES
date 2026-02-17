using GERENC_APPLICATION.DTOs.Categoria;
using GERENC_APPLICATION.DTOs.Instrutor;
using GERENC_APPLICATION.Exceptions;
using GERENC_APPLICATION.Interfaces.Categoria;
using GERENC_DOMAIN.Entities;
using GERENC_INFRAESTRUTURA.Exception;
using GERENC_INFRAESTRUTURA.Persistence;
using Microsoft.EntityFrameworkCore;

namespace GERENC_APPLICATION.Services.Categoria
{
    public class CategoriaService : ICategoriaService
    {

        private readonly AppDbContext _context;

        public CategoriaService(AppDbContext context)
        {
            _context = context;
        }

        public void createCategoria(CategoriaCreateDto dto)
        {
            try
            {
                bool CategoriaExiste = _context.Categorias.Any(c => c.Nome == dto.Nome);
                if (CategoriaExiste)
                {
                    throw new AppException("Categoria já cadastrada");
                }
                _context.Categorias.Add(new CategoriaModel(dto.Nome));
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw new InfraestruturaException("Erro ao salvar categoria no banco!", ex);
            }
        }

        public async Task<IEnumerable<CategoriaListDto>> ListarCategoriasAsync(IEnumerable<int> idCatAgente)
        {
            try
            {

                return await _context.Categorias
                   .Where(c => c.PessoaCategorias.Any(pc => idCatAgente.Contains(pc.Categoria.Id)))
                   .Select(c => new CategoriaListDto
                   {
                       Id = c.Id,
                       Nome = c.Nome
                   })
                   .ToListAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new InfraestruturaException("Não foi possivel listar categorias", ex);
            }

        }

        public async Task<IEnumerable<CategoriaListDto>> ListarTCategoriasAsync()
        {
            try
            {

                return await _context.Categorias
                   .AsNoTracking()
                   .Select(c => new CategoriaListDto
                   {
                       Id = c.Id,
                       Nome = c.Nome
                   })
                   .ToListAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new InfraestruturaException("Não foi possivel listar categorias", ex);
            }
        }
    }
}
