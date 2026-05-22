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
            TornarBotaoArredondado(btnCinema, 30);
            TornarBotaoArredondado(btnDesporto, 30);
            TornarBotaoArredondado(btnHistoria, 30);
            TornarBotaoArredondado(btnMix, 30);
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

        Color[] cores = { Color.White, Color.Yellow, Color.Cyan };
        int indiceCor = 0;

        private void timerAnimacao_Tick(object sender, EventArgs e)
        {
            lblTitulo.ForeColor = cores[indiceCor];
            indiceCor = (indiceCor + 1) % cores.Length;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCinema_Click(object sender, EventArgs e)
        {
            FormJogo formJogo = new FormJogo("Cinema");
            formJogo.Show();
            this.Hide();
        }

        private void btnDesporto_Click(object sender, EventArgs e)
        {
            FormJogo formJogo = new FormJogo("Desporto");
            formJogo.Show();
            this.Hide();
        }

        private void btnHistoria_Click(object sender, EventArgs e)
        {
            FormJogo formJogo = new FormJogo("Historia");
            formJogo.Show();
            this.Hide();
        }

        private void btnMix_Click(object sender, EventArgs e)
        {
            FormJogo formJogo = new FormJogo("Mix");
            formJogo.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Centralizar labels e botões no Form:
            lblTitulo.Left = (this.ClientSize.Width - lblTitulo.Width) / 2;

            int espaco = 40;
            int larguraTotal = btnCinema.Width + espaco + btnHistoria.Width;
            int inicioX = (this.ClientSize.Width - larguraTotal) / 2;
            btnCinema.Left = inicioX;
            btnHistoria.Left = inicioX + btnCinema.Width + espaco;

            int larguraTotal1 = btnDesporto.Width + espaco + btnMix.Width;
            int inicioX1 = (this.ClientSize.Width - larguraTotal) / 2;
            btnDesporto.Left = inicioX;
            btnMix.Left = inicioX + btnDesporto.Width + espaco;

            btnHighscores.Left = (this.ClientSize.Width - btnHighscores.Width) / 2;
            btnSair.Left = (this.ClientSize.Width - btnSair.Width) / 2;
        }

        private void btnHighscores_Click(object sender, EventArgs e)
        {
            FormHighScore formHighscores = new FormHighScore();
            formHighscores.Show();
            this.Hide();
        }
    }
}