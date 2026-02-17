using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GERENC_WPF.View;
using System.Windows;




namespace GERENC_WPF.ViewModels
{
     public class LoginViewModel: ObservableObject
    {
        

        public LoginViewModel()
        {
          
           
        }

        [RelayCommand]
        private void Logar()
        {

            MessageBox.Show("Cliquei em logar");
            // var winPrincipal = new WinPrincipalView();

            // // define a nova janela principal
            //Application.Current.MainWindow = winPrincipal;

            // winPrincipal.Show();
        }

    }
}
