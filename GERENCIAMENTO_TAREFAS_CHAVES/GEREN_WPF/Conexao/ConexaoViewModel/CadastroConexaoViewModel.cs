using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GERENC_WPF.Conexao.ConexaoModell;
using GERENC_WPF.Conexao.ConexaoService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GERENC_WPF.Conexao.ConexaoViewModel
{
    public partial class CadastroConexaoViewModel : ObservableObject
    {
        [ObservableProperty]
        private string servidor;

        [ObservableProperty]
        private string senha;

        public ObservableCollection<string> Bancos { get; } = new();

        [ObservableProperty]
        private string bancoSelecionado;

        [RelayCommand]
        private void BuscarBancos()
        {
            try
            {
                Bancos.Clear();

                var lista = BancoService.ListarBancos(Servidor, Senha);

                foreach (var banco in lista)
                {
                    Bancos.Add(banco);
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Erro");
            }
        }

        [RelayCommand]
        private void Salvar()
        {
            if (string.IsNullOrEmpty(BancoSelecionado))
            {
                System.Windows.MessageBox.Show("Selecione um banco.");
                return;
            }

            ConexaoFileService.Salvar(new ConexaoModel
            {
                Servidor = Servidor,
                Banco = BancoSelecionado,
                Senha = Senha
            });

            System.Windows.MessageBox.Show("Conexão salva com sucesso!");


        }
    }
}
