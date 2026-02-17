using GERENC_WPF.ViewModels.TarafeViewModel;
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

namespace GERENC_WPF.View.TarefaView
{
    /// <summary>
    /// Lógica interna para TarefaCadView.xaml
    /// </summary>
    public partial class TarefaCadView : Window
    {
        public TarefaCadView(TarefaCadViewModel view)
        {
            InitializeComponent();
            DataContext = view;
        }
    }
}
