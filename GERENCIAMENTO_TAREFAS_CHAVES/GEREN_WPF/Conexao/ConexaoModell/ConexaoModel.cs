using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_WPF.Conexao.ConexaoModell
{
    public class ConexaoModel
    {
        public string Servidor { get; set; }
        public string Banco { get; set; }
        public string Senha { get;set; }

        public string ConnectionString =>
             $"Server={Servidor};Database={Banco};User Id=sa;Password={Senha};TrustServerCertificate=True;";
            //$"Server={servidor};User Id=sa;Password={senha};TrustServerCertificate=True;";

    }
}
