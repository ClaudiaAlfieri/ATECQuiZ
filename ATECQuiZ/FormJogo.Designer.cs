namespace ATECQuizApp
{
    partial class FormJogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJogo));
            this.lblTema = new System.Windows.Forms.Label();
            this.lblPerguntaNum = new System.Windows.Forms.Label();
            this.lblPontuacao = new System.Windows.Forms.Label();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.btnResposta2 = new System.Windows.Forms.Button();
            this.btnResposta3 = new System.Windows.Forms.Button();
            this.btnResposta4 = new System.Windows.Forms.Button();
            this.lblNivel = new System.Windows.Forms.Label();
            this.timerFeedback = new System.Windows.Forms.Timer(this.components);
            this.btnResposta1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.BackColor = System.Drawing.Color.Transparent;
            this.lblTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTema.ForeColor = System.Drawing.Color.White;
            this.lblTema.Location = new System.Drawing.Point(236, 150);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(63, 24);
            this.lblTema.TabIndex = 0;
            this.lblTema.Text = "Tema";
            // 
            // lblPerguntaNum
            // 
            this.lblPerguntaNum.AutoSize = true;
            this.lblPerguntaNum.BackColor = System.Drawing.Color.Transparent;
            this.lblPerguntaNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerguntaNum.ForeColor = System.Drawing.Color.White;
            this.lblPerguntaNum.Location = new System.Drawing.Point(568, 150);
            this.lblPerguntaNum.Name = "lblPerguntaNum";
            this.lblPerguntaNum.Size = new System.Drawing.Size(175, 24);
            this.lblPerguntaNum.TabIndex = 1;
            this.lblPerguntaNum.Text = "Pergunta Número";
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.BackColor = System.Drawing.Color.Transparent;
            this.lblPontuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontuacao.ForeColor = System.Drawing.Color.White;
            this.lblPontuacao.Location = new System.Drawing.Point(851, 150);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(109, 24);
            this.lblPontuacao.TabIndex = 2;
            this.lblPontuacao.Text = "Pontuação";
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.BackColor = System.Drawing.Color.Transparent;
            this.lblPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.ForeColor = System.Drawing.Color.White;
            this.lblPergunta.Location = new System.Drawing.Point(613, 241);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(108, 26);
            this.lblPergunta.TabIndex = 3;
            this.lblPergunta.Text = "Pergunta";
            // 
            // btnResposta2
            // 
            this.btnResposta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResposta2.ForeColor = System.Drawing.Color.Indigo;
            this.btnResposta2.Location = new System.Drawing.Point(388, 336);
            this.btnResposta2.Name = "btnResposta2";
            this.btnResposta2.Size = new System.Drawing.Size(250, 35);
            this.btnResposta2.TabIndex = 5;
            this.btnResposta2.Text = "Resposta 2";
            this.btnResposta2.UseVisualStyleBackColor = true;
            this.btnResposta2.Click += new System.EventHandler(this.btnResposta2_Click);
            // 
            // btnResposta3
            // 
            this.btnResposta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResposta3.ForeColor = System.Drawing.Color.Indigo;
            this.btnResposta3.Location = new System.Drawing.Point(675, 336);
            this.btnResposta3.Name = "btnResposta3";
            this.btnResposta3.Size = new System.Drawing.Size(250, 35);
            this.btnResposta3.TabIndex = 6;
            this.btnResposta3.Text = "Resposta 3";
            this.btnResposta3.UseVisualStyleBackColor = true;
            this.btnResposta3.Click += new System.EventHandler(this.btnResposta3_Click);
            // 
            // btnResposta4
            // 
            this.btnResposta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResposta4.ForeColor = System.Drawing.Color.Indigo;
            this.btnResposta4.Location = new System.Drawing.Point(951, 336);
            this.btnResposta4.Name = "btnResposta4";
            this.btnResposta4.Size = new System.Drawing.Size(250, 35);
            this.btnResposta4.TabIndex = 7;
            this.btnResposta4.Text = "Resposta 4";
            this.btnResposta4.UseVisualStyleBackColor = true;
            this.btnResposta4.Click += new System.EventHandler(this.btnResposta4_Click);
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.BackColor = System.Drawing.Color.Transparent;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.ForeColor = System.Drawing.Color.White;
            this.lblNivel.Location = new System.Drawing.Point(395, 150);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(57, 24);
            this.lblNivel.TabIndex = 8;
            this.lblNivel.Text = "Nível";
            // 
            // timerFeedback
            // 
            this.timerFeedback.Interval = 1000;
            this.timerFeedback.Tick += new System.EventHandler(this.timerFeedback_Tick);
            // 
            // btnResposta1
            // 
            this.btnResposta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResposta1.ForeColor = System.Drawing.Color.Indigo;
            this.btnResposta1.Location = new System.Drawing.Point(89, 336);
            this.btnResposta1.Name = "btnResposta1";
            this.btnResposta1.Size = new System.Drawing.Size(250, 35);
            this.btnResposta1.TabIndex = 9;
            this.btnResposta1.Text = "Resposta 1";
            this.btnResposta1.UseVisualStyleBackColor = true;
            // 
            // FormJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 647);
            this.Controls.Add(this.btnResposta1);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.btnResposta4);
            this.Controls.Add(this.btnResposta3);
            this.Controls.Add(this.btnResposta2);
            this.Controls.Add(this.lblPergunta);
            this.Controls.Add(this.lblPontuacao);
            this.Controls.Add(this.lblPerguntaNum);
            this.Controls.Add(this.lblTema);
            this.Name = "FormJogo";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormJogo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Label lblPerguntaNum;
        private System.Windows.Forms.Label lblPontuacao;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.Button btnResposta2;
        private System.Windows.Forms.Button btnResposta3;
        private System.Windows.Forms.Button btnResposta4;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Timer timerFeedback;
        private System.Windows.Forms.Button btnResposta1;
    }
}