using GERENC_DOMAIN.Entities.Sala;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_APPLICATION.DTOs.Sala
{
    public class SalaCreateDto
    {
        public string NameSala { get; set; }
        public List<string> NomesChaves { get; set; }
        public List<int> CodigosCategorias {  get; set; }
    }
}
