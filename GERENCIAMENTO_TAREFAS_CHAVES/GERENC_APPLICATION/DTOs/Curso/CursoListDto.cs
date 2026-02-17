using GERENC_DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_APPLICATION.DTOs.Curso
{
    public class CursoListDto
    {
        public int Id {  get; set; }
        public string Nome { get; set; }

        public List<CategoriaModel> categorias { get; set; }
    }
}
