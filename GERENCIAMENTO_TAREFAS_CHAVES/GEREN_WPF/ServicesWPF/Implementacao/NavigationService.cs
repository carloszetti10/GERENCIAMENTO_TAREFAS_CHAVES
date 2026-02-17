using CommunityToolkit.Mvvm.ComponentModel;
using GERENC_WPF.ServicesWPF.Intefaces;
using GERENC_WPF.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_WPF.ServicesWPF.Implementacao
{
    public class NavigationService : INavigationService
    {
        private readonly IServiceProvider _provider;

        public event Action<ObservableObject>? OnNavigate;

        public NavigationService(IServiceProvider provider)
        {
            _provider = provider;
        }

        public void Navigate<TViewModel>() where TViewModel : ObservableObject
        {
            var vm = _provider.GetRequiredService<TViewModel>();
            OnNavigate?.Invoke(vm);
        }

        public void Navigate(ObservableObject viewModel)
        {
            OnNavigate?.Invoke(viewModel);
        }

    }
}
