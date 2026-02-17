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
            case "gravar":
                corNormal = Color.FromArgb(40, 167, 69);   // verde
                corHover = Color.FromArgb(32, 136, 56);
                corClick = Color.FromArgb(25, 105, 44);

                break;

            case "editar":
                corNormal = Color.FromArgb(255, 193, 7);   // amarelo
                corHover = Color.FromArgb(230, 173, 0);
                corClick = Color.FromArgb(200, 150, 0);
                btn.ForeColor = Color.White;
                break;

            case "excluir":
                corNormal = Color.FromArgb(220, 53, 69);   // vermelho
                corHover = Color.FromArgb(200, 35, 51);
                corClick = Color.FromArgb(170, 30, 45);
                break;

            case "novo":
                corNormal = Color.FromArgb(0, 123, 255);   // azul
                corHover = Color.FromArgb(0, 105, 217);
                corClick = Color.FromArgb(0, 90, 180);
                break;

            case "cancelar":
                corNormal = Color.FromArgb(108, 117, 125); // cinza
                corHover = Color.FromArgb(90, 98, 104);
                corClick = Color.FromArgb(70, 75, 80);
                break;
        }

        btn.BackColor = corNormal;
        btn.FlatAppearance.MouseOverBackColor = corHover;
        btn.FlatAppearance.MouseDownBackColor = corClick;
    }
}
