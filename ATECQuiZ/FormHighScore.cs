using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ATECQuizApp
{
    public partial class FormHighScore : Form
    {
        string ficheiro = "highscores.txt";
        public FormHighScore()
        {
            InitializeComponent();
        }

        Color[] cores = { Color.White, Color.Yellow, Color.Cyan };
        int indiceCor = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTitulo.ForeColor = cores[indiceCor];
            indiceCor = (indiceCor + 1) % cores.Length;
        }

        private void FormHighScore_Load(object sender, EventArgs e)
        {
            MostrarHighscores();

            //Centralizar labels e botões no Form:
            lblTitulo.Left = (this.ClientSize.Width - lblTitulo.Width) / 2;
            lstHighscores.Left = (this.ClientSize.Width - lstHighscores.Width) / 2;
            btnVoltar.Left = (this.ClientSize.Width - btnVoltar.Width) / 2;
        }
                

        private void MostrarHighscores()
        {
            lstHighscores.Items.Clear();

            if (!File.Exists(ficheiro))
            {
                lstHighscores.Items.Add("Ainda não há pontuações guardadas.");
                return;
            }

            string[] linhas = File.ReadAllLines(ficheiro);

            foreach (string linha in linhas)
            {
                lstHighscores.Items.Add(linha);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }
    }
}
