using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ATECQuizApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TornarBotaoArredondado(btnNovoJogo, 30);
            TornarBotaoArredondado(btnHighscores, 30);
            TornarBotaoArredondado(btnSair, 30);
        }

        private void TornarBotaoArredondado(Button btn, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(btn.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(btn.Width - raio, btn.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, btn.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            btn.Region = new Region(path);
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Color[] cores = { Color.White, Color.Yellow, Color.Cyan };
        int indiceCor = 0;

        private void timerAnimacao_Tick(object sender, EventArgs e)
        {
            lblTitulo.ForeColor = cores[indiceCor];
            indiceCor = (indiceCor + 1) % cores.Length;
        }
    }
}