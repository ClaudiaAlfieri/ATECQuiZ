using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace ATECQuizApp
{
    public partial class FormJogo : Form
    {
        XmlDocument doc = new XmlDocument();
        List<XmlNode> perguntasDoJogo = new List<XmlNode>();
        string temaEscolhido;
        int nivelAtual = 1;
        int perguntaAtual = 0;
        int pontuacao = 0;

        public FormJogo(string tema)
        {
            InitializeComponent();
            temaEscolhido = tema;
        }

        private void FormJogo_Load(object sender, EventArgs e)
        {
            doc.Load("QuizQuestions.xml");
            CarregarPerguntas();
        }

        private void CarregarPerguntas()
        {
            perguntasDoJogo.Clear();

            XmlNodeList nodeList = doc.SelectNodes("/QuizQuestions/Question");

            foreach (XmlNode node in nodeList)
            {
                string tema = node["Theme"].InnerText;
                string nivel = node["Level"].InnerText;

                bool temaCorreto = (temaEscolhido == "Mix") || (tema == temaEscolhido);
                bool nivelCorreto = nivel == nivelAtual.ToString();

                if (temaCorreto && nivelCorreto)
                {
                    perguntasDoJogo.Add(node);
                }
            }

            perguntaAtual = 0;
            MostrarPergunta();
        }

        private void MostrarPergunta()
        {
            XmlNode node = perguntasDoJogo[perguntaAtual];

            lblTema.Text = temaEscolhido;
            lblPerguntaNum.Text = "Pergunta: " + (perguntaAtual + 1);
            lblPontuacao.Text = "Pontuação: " + pontuacao;
            lblPergunta.Text = node["Text"].InnerText;

            XmlNodeList opcoes = node.SelectNodes("Options/Option");

            btnResposta1.Text = opcoes[0].InnerText;
            btnResposta2.Text = opcoes[1].InnerText;
            btnResposta3.Text = opcoes[2].InnerText;
            btnResposta4.Text = opcoes[3].InnerText;
        }


    }
}