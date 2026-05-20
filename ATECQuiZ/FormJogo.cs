using ATECQuiZ;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        Button botaoClicado;

        public FormJogo(string tema)
        {
            InitializeComponent();
            temaEscolhido = tema;
        }

        private void FormJogo_Load(object sender, EventArgs e)
        {        
            doc.Load("Resources\\QuizQuestions.xml");
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

            //Centralizar labels e botões no Form:

            int espaco = 30;
            int larguraTotal = lblTema.Width + espaco + lblNivel.Width + espaco + lblPerguntaNum.Width + espaco + lblPontuacao.Width;
            int inicioX = (this.ClientSize.Width - larguraTotal) / 2;
            lblTema.Left = inicioX;
            lblNivel.Left = lblTema.Left + lblTema.Width + espaco;
            lblPerguntaNum.Left = lblNivel.Left + lblNivel.Width + espaco;
            lblPontuacao.Left = lblPerguntaNum.Left + lblPerguntaNum.Width + espaco;

            lblPergunta.Left = (this.ClientSize.Width - lblPergunta.Width) / 2;

            int espaco1 = 15;
            int larguraTotal1 = btnResposta1.Width + espaco1 + btnResposta2.Width + espaco1 + btnResposta3.Width + espaco1 + btnResposta4.Width;
            int inicioX1 = (this.ClientSize.Width - larguraTotal1) / 2;
            btnResposta1.Left = inicioX1;
            btnResposta2.Left = btnResposta1.Left + btnResposta1.Width + espaco1;
            btnResposta3.Left = btnResposta2.Left + btnResposta2.Width + espaco1;
            btnResposta4.Left = btnResposta3.Left + btnResposta3.Width + espaco1;            
        }

        private void VerificarResposta(Button respostaEscolhida)
        {
            string respostaCorreta = perguntasDoJogo[perguntaAtual]["CorrectAnswer"].InnerText;

            botaoClicado = respostaEscolhida;
            if (respostaEscolhida.Text == respostaCorreta)
            {
                respostaEscolhida.BackColor = Color.Green;
                pontuacao++;
                certasNesteNivel += 1;
            }
            else
            {
                respostaEscolhida.BackColor = Color.Red;               
            }

            btnResposta1.Enabled = false;
            btnResposta2.Enabled = false;
            btnResposta3.Enabled = false;
            btnResposta4.Enabled = false;

            timerFeedback.Start();

        }

        private void timerFeedback_Tick(object sender, EventArgs e)
        {
            timerFeedback.Stop();

            botaoClicado.BackColor = Color.White;

            btnResposta1.Enabled = true;
            btnResposta2.Enabled = true;
            btnResposta3.Enabled = true;
            btnResposta4.Enabled = true;

            perguntaAtual++;

            if (perguntaAtual < 5)
            {
                MostrarPergunta();
            }
            else
            {
                if (certasNesteNivel < 4)
                {
                    FormFim formFim = new FormFim("Não foi desta vez, tente novamente!", pontuacao);
                    formFim.Show();
                    this.Hide();
                }
                else
                {
                    if (nivelAtual == 3)
                    {
                        FormFim formFim = new FormFim("Parabéns, venceste! 🏆", pontuacao);
                        formFim.Show();
                        this.Hide();

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
            VerificarResposta(btnResposta1);
        }

        private void btnResposta2_Click(object sender, EventArgs e)
        {
            VerificarResposta(btnResposta2);
        }

        private void btnResposta3_Click(object sender, EventArgs e)
        {
            VerificarResposta(btnResposta3);
        }

        private void btnResposta4_Click(object sender, EventArgs e)
        {
            VerificarResposta(btnResposta4);
        }

        
    }
}