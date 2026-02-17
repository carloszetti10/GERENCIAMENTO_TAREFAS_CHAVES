using GERENC_DOMAIN.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_APPLICATION.DTOs.Usuario
{
    public class UsuarioListDto
    {
        public int Id {  get; set; }
        public string UsuarioLogin { get; set; }
        public TipoUsuarioEnum Tipo { get; set; }
    }
}
