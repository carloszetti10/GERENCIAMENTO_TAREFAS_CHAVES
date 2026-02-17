using GERENC_WPF.Conexao.ConexaoViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GERENC_WPF.Conexao.ConexaoView
{
    /// <summary>
    /// Lógica interna para CadastroConexaoView.xaml
    /// </summary>
    public partial class CadastroConexaoView : Window
    {
        public CadastroConexaoView()
        {
            InitializeComponent();
            DataContext = new CadastroConexaoViewModel();
        }
    }
}
