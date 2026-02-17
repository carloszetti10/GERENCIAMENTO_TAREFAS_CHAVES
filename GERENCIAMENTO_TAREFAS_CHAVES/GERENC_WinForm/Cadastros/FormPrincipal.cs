using GERENC_WinForm.Cadastros.FormCadastros;
using GERENC_WinForm.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GERENC_WinForm.Cadastros
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAbrir.Create<FormCategoria>().ShowDialog();
        }
    }
}
