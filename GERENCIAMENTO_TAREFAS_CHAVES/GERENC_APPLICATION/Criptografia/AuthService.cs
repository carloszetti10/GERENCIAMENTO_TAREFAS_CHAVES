using System;
using BCrypt.Net;

namespace GERENC_APPLICATION.Criptografia
{
    public class AuthService : IAuthService
    {
        public Task<string> GerarHashAsync(string senha)
        {
            return Task.Run(() =>
                BCrypt.Net.BCrypt.HashPassword(senha, workFactor: 4)
            );
        }

        public Task<bool> VerificarSenhaAsync(string senha, string hash)
        {
            return Task.Run(() =>
                BCrypt.Net.BCrypt.Verify(senha, hash)
            );
        }
    }
}
