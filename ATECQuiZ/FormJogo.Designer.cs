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
            this.lblTema = new System.Windows.Forms.Label();
            this.lblPerguntaNum = new System.Windows.Forms.Label();
            this.lblPontuacao = new System.Windows.Forms.Label();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.btnResposta1 = new System.Windows.Forms.Button();
            this.btnResposta2 = new System.Windows.Forms.Button();
            this.btnResposta3 = new System.Windows.Forms.Button();
            this.btnResposta4 = new System.Windows.Forms.Button();
            this.lblNivel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTema.Location = new System.Drawing.Point(234, 119);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(59, 24);
            this.lblTema.TabIndex = 0;
            this.lblTema.Text = "Tema";
            // 
            // lblPerguntaNum
            // 
            this.lblPerguntaNum.AutoSize = true;
            this.lblPerguntaNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerguntaNum.Location = new System.Drawing.Point(566, 119);
            this.lblPerguntaNum.Name = "lblPerguntaNum";
            this.lblPerguntaNum.Size = new System.Drawing.Size(160, 24);
            this.lblPerguntaNum.TabIndex = 1;
            this.lblPerguntaNum.Text = "Pergunta Número";
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontuacao.Location = new System.Drawing.Point(849, 110);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(100, 24);
            this.lblPontuacao.TabIndex = 2;
            this.lblPontuacao.Text = "Pontuação";
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.Location = new System.Drawing.Point(408, 231);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(86, 24);
            this.lblPergunta.TabIndex = 3;
            this.lblPergunta.Text = "Pergunta";
            // 
            // btnResposta1
            // 
            this.btnResposta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResposta1.Location = new System.Drawing.Point(133, 335);
            this.btnResposta1.Name = "btnResposta1";
            this.btnResposta1.Size = new System.Drawing.Size(250, 35);
            this.btnResposta1.TabIndex = 4;
            this.btnResposta1.Text = "Resposta 1";
            this.btnResposta1.UseVisualStyleBackColor = true;
            this.btnResposta1.Click += new System.EventHandler(this.btnResposta1_Click);
            // 
            // btnResposta2
            // 
            this.btnResposta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResposta2.Location = new System.Drawing.Point(412, 335);
            this.btnResposta2.Name = "btnResposta2";
            this.btnResposta2.Size = new System.Drawing.Size(250, 35);
            this.btnResposta2.TabIndex = 5;
            this.btnResposta2.Text = "Resposta 2";
            this.btnResposta2.UseVisualStyleBackColor = true;
            this.btnResposta2.Click += new System.EventHandler(this.btnResposta2_Click);
            // 
            // btnResposta3
            // 
            this.btnResposta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResposta3.Location = new System.Drawing.Point(699, 335);
            this.btnResposta3.Name = "btnResposta3";
            this.btnResposta3.Size = new System.Drawing.Size(250, 35);
            this.btnResposta3.TabIndex = 6;
            this.btnResposta3.Text = "Resposta 3";
            this.btnResposta3.UseVisualStyleBackColor = true;
            this.btnResposta3.Click += new System.EventHandler(this.btnResposta3_Click);
            // 
            // btnResposta4
            // 
            this.btnResposta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResposta4.Location = new System.Drawing.Point(975, 335);
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
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(393, 119);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(52, 24);
            this.lblNivel.TabIndex = 8;
            this.lblNivel.Text = "Nível";
            // 
            // FormJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 647);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.btnResposta4);
            this.Controls.Add(this.btnResposta3);
            this.Controls.Add(this.btnResposta2);
            this.Controls.Add(this.btnResposta1);
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
        private System.Windows.Forms.Button btnResposta1;
        private System.Windows.Forms.Button btnResposta2;
        private System.Windows.Forms.Button btnResposta3;
        private System.Windows.Forms.Button btnResposta4;
        private System.Windows.Forms.Label lblNivel;
    }
}