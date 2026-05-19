namespace ATECQuizApp
{
    partial class FormFim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFim));
            this.lblFim = new System.Windows.Forms.Label();
            this.timerFim = new System.Windows.Forms.Timer(this.components);
            this.lblPontuacao = new System.Windows.Forms.Label();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFim
            // 
            this.lblFim.AutoSize = true;
            this.lblFim.BackColor = System.Drawing.Color.Transparent;
            this.lblFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFim.ForeColor = System.Drawing.Color.White;
            this.lblFim.Location = new System.Drawing.Point(438, 163);
            this.lblFim.Name = "lblFim";
            this.lblFim.Size = new System.Drawing.Size(354, 37);
            this.lblFim.TabIndex = 11;
            this.lblFim.Text = "✨ Jogo Encerrado ✨";
            // 
            // timerFim
            // 
            this.timerFim.Enabled = true;
            this.timerFim.Interval = 500;
            this.timerFim.Tick += new System.EventHandler(this.timerFim_Tick);
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontuacao.Location = new System.Drawing.Point(564, 249);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(109, 24);
            this.lblPontuacao.TabIndex = 12;
            this.lblPontuacao.Text = "Pontuação";
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.Location = new System.Drawing.Point(578, 334);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(95, 24);
            this.lblFeedback.TabIndex = 14;
            this.lblFeedback.Text = "Feedback";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.ForeColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Location = new System.Drawing.Point(556, 429);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(158, 62);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // FormFim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1285, 651);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.lblPontuacao);
            this.Controls.Add(this.lblFim);
            this.Name = "FormFim";
            this.Text = "FormFim";
            this.Load += new System.EventHandler(this.FormFim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFim;
        private System.Windows.Forms.Timer timerFim;
        private System.Windows.Forms.Label lblPontuacao;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Button btnVoltar;
    }
}