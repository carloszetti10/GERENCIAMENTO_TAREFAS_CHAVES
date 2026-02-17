using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_APPLICATION.Criptografia
{
    public interface IAuthService
    {
        Task<string> GerarHashAsync(string senha);
        Task<bool> VerificarSenhaAsync(string senha, string hash);
    }
}
