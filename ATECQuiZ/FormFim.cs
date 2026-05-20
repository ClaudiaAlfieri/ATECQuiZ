using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATECQuizApp
{
    public partial class FormFim : Form
    {
        string mensagemFinal;
        int pontuacaoFinal;

        public FormFim(string mensagem, int pontuacao)
        {
            InitializeComponent();
            mensagemFinal = mensagem;
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
            Application.Restart();
        }
    }
}
