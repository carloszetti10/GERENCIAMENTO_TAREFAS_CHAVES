using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_APPLICATION.DTOs.Curso
{
    public class CursoCreateDto
    {
        public string Nome { get; set; }
        public List<int> CategoriaCodigos { get; set; } = new();
    }
}
