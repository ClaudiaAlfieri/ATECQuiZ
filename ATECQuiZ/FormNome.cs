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
    public partial class FormNome : Form
    {
        public string NomeJogador = "";
        public FormNome()
        {
            InitializeComponent();
        }

        private void FormNome_Load(object sender, EventArgs e)
        {
            //Centralizar labels e botões no Form:
            lblNome.Left = (this.ClientSize.Width - lblNome.Width) / 2;
            txtNome.Left = (this.ClientSize.Width - txtNome.Width) / 2;
            btnOk.Left = (this.ClientSize.Width - btnOk.Width) / 2;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            NomeJogador = txtNome.Text;
            this.Close();
        }
    }
}
