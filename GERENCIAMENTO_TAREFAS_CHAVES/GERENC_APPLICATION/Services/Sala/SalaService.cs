using GERENC_APPLICATION.DTOs.Sala;
using GERENC_APPLICATION.Exceptions;
using GERENC_APPLICATION.Interfaces.Sala;
using GERENC_DOMAIN.Entities.Sala;
using GERENC_INFRAESTRUTURA.Exception;
using GERENC_INFRAESTRUTURA.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_APPLICATION.Services.Sala
{
    public class SalaService : ISalaService
    {
        private readonly AppDbContext _context;
        public SalaService(AppDbContext appDbContext) 
        {
            _context = appDbContext;
        }
        public async Task CreateSalaAsync(SalaCreateDto dto)
        {
            try
            {
                var sala = new SalaModel(dto.NameSala);
                foreach (var chave in dto.NomesChaves)
                {
                    sala.AdicionarChave(chave);
                }

                foreach (var categoriasCodigo in dto.CodigosCategorias)
                {

                    var categoria = _context.Categorias.Find(categoriasCodigo);
                    if (categoria != null)
                    {
                        sala.AdicionarCategoria(categoria);
                    }
                    else
                    {
                        throw new AppException("Categoria inexistente");
                    }
                }

                await _context.AddAsync(sala);
                await _context.SaveChangesAsync();

            }
            catch (DbUpdateException ex)
            {
                throw new InfraestruturaException("Não foi possivel salvar Sala", ex);
            }
            catch (AppException ex)
            {
                throw;
            }
        }

        
    }
}
