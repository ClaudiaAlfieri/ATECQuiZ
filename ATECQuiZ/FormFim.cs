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
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
