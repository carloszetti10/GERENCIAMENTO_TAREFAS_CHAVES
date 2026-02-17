using GERENC_APPLICATION.DTOs.Categoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_APPLICATION.Interfaces.Categoria
{
    public interface ICategoriaService
    {
        public void createCategoria(CategoriaCreateDto dto);

        Task<IEnumerable<CategoriaListDto>> ListarCategoriasAsync(IEnumerable<int> idCatAgente);

        Task<IEnumerable<CategoriaListDto>> ListarTCategoriasAsync();
    }
}
