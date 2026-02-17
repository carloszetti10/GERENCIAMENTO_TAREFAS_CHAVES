using GERENC_APPLICATION.DTOs.Sala;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_APPLICATION.Interfaces.Sala
{
    public interface ISalaService
    {
        Task CreateSalaAsync(SalaCreateDto dto);
    }
}
