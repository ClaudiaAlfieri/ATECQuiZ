using System;
using System.Windows.Forms;
using System.Xml;

namespace ATECQuizApp
{
    public partial class FormJogo : Form
    {
        XmlDocument doc = new XmlDocument();
        string temaEscolhido;

        public FormJogo(string tema)
        {
            InitializeComponent();
            temaEscolhido = tema;
        }

        private void FormJogo_Load(object sender, EventArgs e)
        {
            doc.Load("QuizQuestions.xml");
        }
    }
}