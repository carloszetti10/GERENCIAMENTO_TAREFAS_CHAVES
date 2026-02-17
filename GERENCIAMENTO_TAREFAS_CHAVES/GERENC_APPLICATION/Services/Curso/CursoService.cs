using GERENC_APPLICATION.DTOs.Curso;
using GERENC_APPLICATION.Exceptions;
using GERENC_APPLICATION.Interfaces.Curso;
using GERENC_DOMAIN.Entities.Curso;
using GERENC_INFRAESTRUTURA.Exception;
using GERENC_INFRAESTRUTURA.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_APPLICATION.Services.Curso
{
    public class CursoService : ICursoService
    {
        private readonly AppDbContext _context;

        public CursoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task CriarCursoAsync(CursoCreateDto dto)
        {
            try
            {
                var curso = new CursoModel(dto.Nome);
                foreach (var categoriasCodigo in dto.CategoriaCodigos)
                {
                    var categoria = await _context.Categorias.FindAsync(categoriasCodigo);
                    if (categoria != null)
                    {
                        curso.AdicionarCategoria(categoria);
                    }else
                    {
                        throw new AppException("Categoria inexistente");
                    }
                }
                await _context.Cursos.AddAsync(curso);
                await _context.SaveChangesAsync();
            }
            catch (AppException ex)
            {
                throw;
            }catch (DbUpdateException e)
            {
                throw new InfraestruturaException("Erro ao cadastrar curso", e);
            }
        }
    }
}
