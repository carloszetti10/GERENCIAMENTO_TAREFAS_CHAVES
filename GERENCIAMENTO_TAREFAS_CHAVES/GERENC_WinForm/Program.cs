using GERENC_APPLICATION.Interfaces.Categoria;
using GERENC_APPLICATION.Services.Categoria;
using GERENC_WinForm.Cadastros;
using GERENC_WinForm.Cadastros.FormCadastros;
using GERENC_WinForm.DialogService;
using Microsoft.Extensions.DependencyInjection;

namespace GERENC_WinForm
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            ////ApplicationConfiguration.Initialize();

            //var services = new ServiceCollection();

            //// serviços
            //services.AddSingleton<IDialogService, DialogoService>();
            //services.AddScoped<ICategoriaService, CategoriaService>();

            //// tela principal
            ////services.AddSingleton<FormPrincipal>();

            //// telas filhas
            //services.AddTransient<FormCategoria>();
            ////services.AddTransient<FormInstrutor>();

            //ServiceProvider = services.BuildServiceProvider();

            ////Application.Run(
            ////    ServiceProvider.GetRequiredService<FormPrincipal>()
            ////);
        }
    }
}
