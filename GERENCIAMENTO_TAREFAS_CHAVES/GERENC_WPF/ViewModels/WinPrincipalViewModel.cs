using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_WPF.ViewModels
{
    public class WinPrincipalViewModel : ObservableObject
    {
        private ObservableObject _currentViewModel;
        public ObservableObject CurrentViewModel
        {
            get => _currentViewModel;
            set => SetProperty(ref _currentViewModel, value);
        }

        public WinPrincipalViewModel()
        {
            //CurrentViewModel = new HomeViewModel();
        }
    }
}
