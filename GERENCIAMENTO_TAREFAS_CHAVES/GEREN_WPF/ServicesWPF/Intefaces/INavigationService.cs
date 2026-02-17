using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_WPF.ServicesWPF.Intefaces
{
    public interface INavigationService
    {
        void Navigate<TViewModel>() where TViewModel : ObservableObject;

        void Navigate(ObservableObject viewModel);

        event Action<ObservableObject> OnNavigate;
    }

}
