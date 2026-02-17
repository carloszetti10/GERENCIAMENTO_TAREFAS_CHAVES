using GERENC_DOMAIN.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_APPLICATION.DTOs.Usuario
{
    public class UsuarioCreateDto
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public TipoUsuarioEnum Tipo { get; set; }

        public List<int> CategoriasCodigos { get; set; } = new();
    }
}
