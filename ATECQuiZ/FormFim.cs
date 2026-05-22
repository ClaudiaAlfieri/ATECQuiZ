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
using Microsoft.VisualBasic;
using System.Windows.Forms.VisualStyles;

namespace ATECQuizApp
{
    public partial class FormFim : Form
    {
        string mensagemFinal;
        string temaEscolhido;
        int pontuacaoFinal;

        public FormFim(string mensagem, string tema,  int pontuacao)
        {
            InitializeComponent();
            mensagemFinal = mensagem;
            temaEscolhido = tema;
            pontuacaoFinal = pontuacao;
            
        }

        Color[] cores = { Color.White, Color.Yellow, Color.Cyan };
        int indiceCor = 0;
        private void timerFim_Tick(object sender, EventArgs e)
        {
            lblFim.ForeColor = cores[indiceCor];
            indiceCor = (indiceCor + 1) % cores.Length;
        }

        private void FormFim_Load(object sender, EventArgs e)
        {
            lblPontuacao.Text = "Você fez " + pontuacaoFinal.ToString() + " pontos.";
            lblFeedback.Text = mensagemFinal.ToString();

            //Centralizar labels e botões no Form:
            lblFim.Left = (this.ClientSize.Width - lblFim.Width) / 2;
            lblPontuacao.Left = (this.ClientSize.Width - lblPontuacao.Width) / 2;
            lblFeedback.Left = (this.ClientSize.Width - lblFeedback.Width) / 2;
            btnVoltar.Left = (this.ClientSize.Width - btnVoltar.Width) / 2;
        }
                
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormNome formNome = new FormNome();
            formNome.ShowDialog();

            string nome = formNome.NomeJogador;

            if (nome != "")
            {
                string linha = nome + " | " + temaEscolhido + " | " + pontuacaoFinal;
                File.AppendAllText("highscores.txt", linha + "\n");
            }

            FormHighScore formHighscores = new FormHighScore();
            formHighscores.Show();
            this.Close();
        }
    }
}
