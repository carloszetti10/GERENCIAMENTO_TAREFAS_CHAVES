using GERENC_WPF.Conexao.ConexaoModell;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GERENC_WPF.Conexao.ConexaoService
{
    public static class ConexaoFileService
    {
        //private static readonly string pasta =
        //    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Conexoes");

        private static readonly string pasta =
        @"C:\Users\Suporte - Nortesys\GERENCIAMENTO_TAREFAS_CHAVES\GERENCIAMENTO_TAREFAS_CHAVES\GERENC_WPF";


        public static void Salvar(ConexaoModel conexao)
        {
            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);

            int indice = Directory.GetFiles(pasta, "conexao*.json").Length + 1;
            string nome = indice == 1 ? "conexao.json" : $"conexao{indice}.json";

            string caminho = Path.Combine(pasta, nome);

            var json = JsonSerializer.Serialize(conexao, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(caminho, json);
        }

        public static List<string> ListarArquivos()
        {
            if (!Directory.Exists(pasta))
                return new List<string>();

            return Directory.GetFiles(pasta, "conexao*.json")
                            .Select(Path.GetFileName)
                            .ToList();
        }

        public static ConexaoModel Ler(string arquivo)
        {
            var json = File.ReadAllText(Path.Combine(pasta, arquivo));
            return JsonSerializer.Deserialize<ConexaoModel>(json);
        }
    }
}
