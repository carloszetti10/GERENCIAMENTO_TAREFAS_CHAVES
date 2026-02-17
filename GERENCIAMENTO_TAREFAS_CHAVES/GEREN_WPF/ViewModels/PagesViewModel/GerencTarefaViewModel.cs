using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GERENC_WinForm;
using GERENC_WinForm.Cadastros.FormCadastros;
using GERENC_WPF.ServicesWPF.Intefaces;
using GERENC_WPF.ViewModels.UsuarioCadastroModel;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace GERENC_WPF.ViewModels
{
    public partial class GerencTarefaViewModel : ObservableObject
    {

        public ObservableCollection<TarefaModel> Tarefas { get; }

     
        private readonly IWindowService _windowService;
        private readonly IServiceProvider _serviceProvider;

        public GerencTarefaViewModel(IWindowService windowService, IServiceProvider serviceProvider)
        {
            _windowService = windowService;
            Tarefas = GerarTarefasFake();
            _serviceProvider = serviceProvider;
        }


        [RelayCommand]
        public void AbrirTelaInstrutor()
        {
            var form = _serviceProvider.GetRequiredService<FormConsultor>();

            form.ShowDialog();

        }

        [RelayCommand]
        public void AbrirTelaTarefa()
        {
            _windowService.AbrirTarefaCad();

        }

        [RelayCommand]
        public void AbrirTelaCurso()
        {
            
        }


        public ObservableCollection<TarefaModel> GerarTarefasFake()
        {
            var random = new Random();

            string[] cursos = { "Curso de C#", "Curso de Java", "Curso de WPF", "Curso de SQL", "Curso de Angular", "Curso de React" };

            string[] status = { "ATIVO", "CONCLUIDO" };

            string[] instrutores = { "Ana Silva", "Carlos Souza", "João Lima", "Mariana Costa", "Pedro Alves", "Fernanda Rocha" };

            string[] turnos = { "MATUTINO", "VESPERTINO", "NOTURNO" };

            string[] dias = { "Seg, Qua", "Ter, Qui", "Qua, Sex", "Seg, Sex", "Ter, Sáb" };

            var lista = new ObservableCollection<TarefaModel>();

            for (int i = 1; i <= 1000; i++)
            {
                var inicio = DateTime.Today.AddDays(random.Next(1, 20));
                var fim = inicio.AddDays(random.Next(10, 25));

                lista.Add(new TarefaModel
                {
                    Codigo = i.ToString(),
                    Curso = cursos[random.Next(cursos.Length)],
                    Instrutor = instrutores[random.Next(instrutores.Length)],
                    Periodo = $"{inicio:dd/MM} - {fim:dd/MM}",
                    Turno = turnos[random.Next(turnos.Length)],
                    Dias = dias[random.Next(dias.Length)],
                    Status = status[random.Next(status.Length)]
                });
            }

            return lista;
        }

    }

    public class TarefaModel 
    {

        public string? Codigo { get; set; }
        public string? Curso { get; set; }
        public string? Instrutor { get; set; }
        public string? Periodo { get; set; }
        public string? Turno { get; set; }
        public string? Dias { get; set; }
        public string? Status { get; set; }





        //public event PropertyChangedEventHandler? PropertyChanged;

        //protected void OnPropertyChanged([CallerMemberName] string? name = null)
        //    => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}