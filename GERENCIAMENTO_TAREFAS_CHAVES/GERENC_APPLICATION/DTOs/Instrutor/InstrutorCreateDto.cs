using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_APPLICATION.DTOs.Instrutor
{
    public class InstrutorCreateDto
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public List<int> CategoriaCodigos { get; set; } = new();
    }
}
