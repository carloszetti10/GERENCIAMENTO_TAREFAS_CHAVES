using System.Drawing;
using System.Windows.Forms;

public static class ButtonStyle
{
    public static void Apply(Button btn, string tipo)
    {
        btn.FlatStyle = FlatStyle.Flat;
        btn.FlatAppearance.BorderSize = 0;
        btn.ForeColor = Color.White;
        btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btn.Cursor = Cursors.Hand;

        if (!btn.Enabled)
        {
            btn.BackColor = Color.FromArgb(240, 240, 240); // cinza
            btn.ForeColor = Color.FromArgb(150, 150, 150); // texto cinza
            btn.FlatAppearance.MouseOverBackColor = btn.BackColor;
            btn.FlatAppearance.MouseDownBackColor = btn.BackColor;
            return;
        }

        Color corNormal = Color.Gray;
        Color corHover = Color.DarkGray;
        Color corClick = Color.DimGray;


        switch (tipo.ToLower())
        {
            case "gravar": // Verde igual CardGreenStyle
                corNormal = Color.FromArgb(230, 247, 239);   // #E6F7EF
                corHover = Color.FromArgb(210, 235, 225);
                corClick = Color.FromArgb(190, 220, 210);
                btn.ForeColor = Color.FromArgb(25, 135, 84); // texto verde mais forte
                break;

            case "novo": // Azul igual CardBlueStyle
                corNormal = Color.FromArgb(232, 240, 254);   // #E8F0FE
                corHover = Color.FromArgb(210, 225, 252);
                corClick = Color.FromArgb(190, 210, 250);
                btn.ForeColor = Color.FromArgb(13, 110, 253);
                break;

            case "editar": // Amarelo igual CardYellowStyle
                corNormal = Color.FromArgb(255, 248, 225);   // #FFF8E1
                corHover = Color.FromArgb(255, 235, 180);
                corClick = Color.FromArgb(255, 220, 150);
                btn.ForeColor = Color.FromArgb(255, 152, 0);
                break;

            case "excluir": // Podemos manter vermelho moderno
                corNormal = Color.FromArgb(255, 235, 238);
                corHover = Color.FromArgb(255, 205, 210);
                corClick = Color.FromArgb(239, 154, 154);
                btn.ForeColor = Color.FromArgb(211, 47, 47);
                break;

            case "cancelar":
                corNormal = Color.White;
                corHover = Color.FromArgb(240, 240, 240);
                corClick = Color.FromArgb(220, 220, 220);
                btn.ForeColor = Color.FromArgb(108, 117, 125);
                btn.FlatAppearance.BorderSize = 1;
                btn.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
                break;
        }

         btn.BackColor = corNormal;
         btn.FlatAppearance.MouseOverBackColor = corHover;
         btn.FlatAppearance.MouseDownBackColor = corClick;
    }
}
