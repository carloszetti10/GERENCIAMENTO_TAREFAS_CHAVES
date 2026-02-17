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
            txt.Margin = new Padding(5);

            // Evento foco
            txt.Enter += (s, e) =>
            {
                txt.BackColor = Color.FromArgb(240, 248, 255); // leve azul
            };

            txt.Leave += (s, e) =>
            {
                txt.BackColor = Color.White;
            };

            // Desabilitado
            txt.EnabledChanged += (s, e) =>
            {
                if (!txt.Enabled)
                {
                    txt.BackColor = Color.FromArgb(240, 240, 240);
                    txt.ForeColor = Color.FromArgb(150, 150, 150);
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
