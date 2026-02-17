using GERENC_APPLICATION.Interfaces.Categoria;
using GERENC_WinForm.DialogService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GERENC_WinForm.Cadastros.FormCadastros
{
    public partial class FormConsultor : TelaBase
    {

        
        public FormConsultor()
        {
            InitializeComponent();
            preencherCkeckList();
        }


        public void preencherCkeckList()
        {
            checkedListCategoria.Items.Clear();
            _categoriaService.ListarTCategoriasAsync();
            checkedListCategoria.Items.Add("nome");
        }
    }
}
