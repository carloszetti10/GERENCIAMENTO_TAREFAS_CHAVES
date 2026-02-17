using GERENC_WPF.ViewModels.UsuarioCadastroModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GERENC_WPF.View.UsuarioView
{
    /// <summary>
    /// Interação lógica para UsuarioCadastroView.xam
    /// </summary>
    public partial class UsuarioCadastroView :Window
    {
        public UsuarioCadastroView(UsuarioCadastroViewModel view)
        {
            InitializeComponent();
            DataContext = view;
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (DataContext is UsuarioCadastroViewModel vm)
            {
                await vm.CarregarUsuariosAsync();
            }
        }
    }
}
