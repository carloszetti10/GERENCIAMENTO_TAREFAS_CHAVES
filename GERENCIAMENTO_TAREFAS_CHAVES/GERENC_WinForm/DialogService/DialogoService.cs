using System.Windows.Forms;

namespace GERENC_WinForm.DialogService
{
    public class DialogoService : IDialogService
    {
        public void ShowInfo(string message, string title = "Informação")
        {
            MessageBox.Show(
                message,
                title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public void ShowSuccess(string message, string title = "Sucesso")
        {
            MessageBox.Show(
                message,
                title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public void ShowAtenc(string message, string title = "Atenção")
        {
            MessageBox.Show(
                message,
                title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        public void ShowError(string message, string title = "Erro")
        {
            MessageBox.Show(
                message,
                title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        public bool Confirm(string message, string title = "Confirmação")
        {
            var result = MessageBox.Show(
                message,
                title,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return result == DialogResult.Yes;
        }
    }
}
