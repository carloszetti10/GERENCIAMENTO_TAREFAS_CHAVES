using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GERENC_WPF.Conexao.ConexaoModell
{
    public static class ConexaoJsonService
    {
        public static void Conectar(string caminhoArquivo)
        {
            if (!File.Exists(caminhoArquivo))
                throw new FileNotFoundException("Arquivo de conexão não encontrado.");

            try
            {
                // 1️⃣ LÊ JSON
                var json = File.ReadAllText(caminhoArquivo);
                var dados = JsonSerializer.Deserialize<ConexaoModel>(json);

                if (dados == null)
                    throw new Exception("Arquivo de conexão inválido.");

                // 2️⃣ MONTA STRING
                var connString = MontarConnectionString(dados);

                // 3️⃣ TESTA CONEXÃO
                using var conn = new SqlConnection(connString);
                conn.Open();

                // 4️⃣ SALVA CONEXÃO GLOBAL
                AppConnection.Current = connString;
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao conectar no banco:\n" + ex.Message);
            }
        }

        private static string MontarConnectionString(ConexaoModel c)
        {

            return c.ConnectionString;  
            //// Windows Auth
            //if (string.IsNullOrEmpty(c.Usuario))
            //{
            //    return
            //        $"Server={c.Servidor};" +
            //        $"Database={c.Banco};" +
            //        $"Trusted_Connection=True;" +
            //        $"TrustServerCertificate=True;";
            //}

            //// SQL Auth
            //return
            //    $"Server={c.Servidor};" +
            //    $"Database={c.Banco};" +
            //    $"User Id={c.Usuario};" +
            //    $"Password={c.Senha};" +
            //    $"TrustServerCertificate=True;";
        }
    }
}
