
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace GERENC_WPF.Conexao.ConexaoService
{
  

    public static class BancoService
    {
        public static List<string> ListarBancos(string servidor, string senha)
        {
            var bancos = new List<string>();

            var connString =
            //$"Server={servidor};User=sa;Password={senha};Trusted_Connection=True;TrustServerCertificate=True;";
            $"Server={servidor};User Id=sa;Password={senha};TrustServerCertificate=True;";



            using var conn = new SqlConnection(connString);
            conn.Open();

            var cmd = new SqlCommand("SELECT name FROM sys.databases ORDER BY name", conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
                bancos.Add(reader.GetString(0));

            return bancos;
        }
    }

}
