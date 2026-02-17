using GERENC_APPLICATION.Exceptions;
using GERENC_INFRAESTRUTURA.Exception;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_WPF.Conexao.ConexaoModell
{
    public static class AppConnection
    {
        public static string Current { get; set; }
    }


    public static class ConexaoStartupService
    {
        //private static readonly string pasta =
        //    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Conexoes");

        private static readonly string pasta =
        @"C:\Users\Suporte - Nortesys\GERENCIAMENTO_TAREFAS_CHAVES\GERENCIAMENTO_TAREFAS_CHAVES\GERENC_WPF";




        public static bool ExisteConexao()
        => Directory.Exists(pasta)
           && Directory.GetFiles(pasta, "*.json").Any();

        public static void ConectarPrimeira()
        {
            try
            {
                var arquivo = Directory
               .GetFiles(pasta, "*.json")
               .First();
                //File.Delete(arquivo);
                ConexaoJsonService.Conectar(arquivo);

            }
            catch (Exception ex)
            {
                throw new AppException("Erro ao conectar com o arquivo json." + ex.Message + pasta);
                
            }
           
        }
    }

}
