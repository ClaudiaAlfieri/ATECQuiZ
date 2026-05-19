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
        int certasNesteNivel = 0;

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
            BaralharPergunta();
        }

        private void BaralharPergunta()
        {
            Random rnd = new Random();
            for (int i = perguntasDoJogo.Count - 1; i > 0; i--)
            {
                int j = rnd.Next(0, i + 1);

                XmlNode temp = perguntasDoJogo[i];
                perguntasDoJogo[i] = perguntasDoJogo[j];
                perguntasDoJogo[j] = temp;
            }

            if (perguntasDoJogo.Count > 5)
            {
                perguntasDoJogo = perguntasDoJogo.GetRange(0, 5);
            }
            
            MostrarPergunta();
        }

        private void MostrarPergunta()
        {
            XmlNode node = perguntasDoJogo[perguntaAtual];

            lblTema.Text = "Tema: " + temaEscolhido;
            lblNivel.Text = "Nível: " + nivelAtual.ToString();
            lblPerguntaNum.Text = "Pergunta: " + (perguntaAtual + 1);
            lblPontuacao.Text = "Pontuação: " + pontuacao;
            lblPergunta.Text = node["Text"].InnerText;

            XmlNodeList opcoes = node.SelectNodes("Options/Option");

            btnResposta1.Text = opcoes[0].InnerText;
            btnResposta2.Text = opcoes[1].InnerText;
            btnResposta3.Text = opcoes[2].InnerText;
            btnResposta4.Text = opcoes[3].InnerText;
        }

        private void VerificarResposta(string respostaEscolhida)
        {
            string respostaCorreta = perguntasDoJogo[perguntaAtual]["CorrectAnswer"].InnerText;
           
            if (respostaEscolhida == respostaCorreta)
            {
                MessageBox.Show("Resposta correta! 🎉", "Resultado");
                pontuacao++;
                certasNesteNivel += 1;
            }
            else
            {
                MessageBox.Show("Resposta errada! 😔", "Resultado");
            }

            perguntaAtual++;

            if (perguntaAtual < 5)
            {
                MostrarPergunta();
            }
            else
            {
               if (certasNesteNivel < 4)
                {
                    MessageBox.Show("Jogo encerrado");
                    this.Close();
                }
                else
                {
                    if (nivelAtual == 3)
                    {
                        MessageBox.Show("Parabéns, venceste o jogo! 🏆");
                        this.Close();
                    }
                    else
                    {
                        nivelAtual++;
                        certasNesteNivel = 0;
                        CarregarPerguntas();
                    }
                }
            }

        }

        private void btnResposta1_Click(object sender, EventArgs e)
        {
            VerificarResposta(btnResposta1.Text);
        }

        private void btnResposta2_Click(object sender, EventArgs e)
        {
            VerificarResposta(btnResposta2.Text);
        }

        private void btnResposta3_Click(object sender, EventArgs e)
        {
            VerificarResposta(btnResposta3.Text);
        }

        private void btnResposta4_Click(object sender, EventArgs e)
        {
            VerificarResposta(btnResposta4.Text);
        }
    }
}