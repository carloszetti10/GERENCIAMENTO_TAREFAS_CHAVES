using CommunityToolkit.Mvvm.ComponentModel;
using GERENC_WPF.ServicesWPF.Intefaces;
using GERENC_WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_WPF.ServicesWPF.Implementacao
{
    public class NavigationService : INavigationService
    {
        private readonly WinPrincipalViewModel _mainVm;

    
        public NavigationService(WinPrincipalViewModel mainVm)
        {
            _mainVm = mainVm;
        }

        public void Navigate(ObservableObject viewModel)
        {
            _mainVm.CurrentViewModel = viewModel;
        }
    }

}
