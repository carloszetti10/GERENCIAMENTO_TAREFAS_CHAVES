using GERENC_APPLICATION.DTOs.Curso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_APPLICATION.Interfaces.Curso
{
    public interface ICursoService
    {
         Task CriarCursoAsync(CursoCreateDto cursoCreateDto);
    }
}
