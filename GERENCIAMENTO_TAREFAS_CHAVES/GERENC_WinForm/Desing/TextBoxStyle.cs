using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_WinForm.Desing
{
    public class TextBoxStyle
    {
        public static void Apply(TextBox txt)
        {
            txt.BorderStyle = BorderStyle.None;
            txt.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            txt.BackColor = Color.White;
            txt.ForeColor = Color.FromArgb(33, 37, 41);

            // Painel para simular borda inferior
            Panel border = new Panel();
            border.Height = 2;
            border.Dock = DockStyle.Bottom;
            border.BackColor = Color.FromArgb(200, 200, 200);

            txt.Controls.Add(border);


            // Evento foco
            txt.Enter += (s, e) =>
            {
                border.BackColor = Color.FromArgb(0, 120, 215); // azul moderno
            };

            txt.Leave += (s, e) =>
            {
                border.BackColor = Color.FromArgb(200, 200, 200);
            };

            // Desabilitado
            txt.EnabledChanged += (s, e) =>
            {
                if (!txt.Enabled)
                {
                    txt.BackColor = Color.FromArgb(245, 245, 245);
                    txt.ForeColor = Color.Gray;
                    border.BackColor = Color.LightGray;
                }
                else
                {
                    txt.BackColor = Color.White;
                    txt.ForeColor = Color.FromArgb(33, 37, 41);
                }
            };
        }
    }
}
