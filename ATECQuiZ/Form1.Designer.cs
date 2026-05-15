namespace ATECQuizApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNovoJogo = new System.Windows.Forms.Button();
            this.btnHighscores = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNovoJogo
            // 
            this.btnNovoJogo.BackColor = System.Drawing.Color.Magenta;
            this.btnNovoJogo.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.btnNovoJogo.FlatAppearance.BorderSize = 2;
            this.btnNovoJogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoJogo.ForeColor = System.Drawing.Color.White;
            this.btnNovoJogo.Location = new System.Drawing.Point(534, 195);
            this.btnNovoJogo.Name = "btnNovoJogo";
            this.btnNovoJogo.Size = new System.Drawing.Size(200, 50);
            this.btnNovoJogo.TabIndex = 0;
            this.btnNovoJogo.Text = "🎮 Novo Jogo";
            this.btnNovoJogo.UseVisualStyleBackColor = false;
            // 
            // btnHighscores
            // 
            this.btnHighscores.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnHighscores.FlatAppearance.BorderSize = 0;
            this.btnHighscores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHighscores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighscores.ForeColor = System.Drawing.Color.White;
            this.btnHighscores.Location = new System.Drawing.Point(534, 292);
            this.btnHighscores.Name = "btnHighscores";
            this.btnHighscores.Size = new System.Drawing.Size(200, 50);
            this.btnHighscores.TabIndex = 1;
            this.btnHighscores.Text = " 🏆 Highscores";
            this.btnHighscores.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(534, 387);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(200, 50);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "❌ Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1305, 681);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnHighscores);
            this.Controls.Add(this.btnNovoJogo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovoJogo;
        private System.Windows.Forms.Button btnHighscores;
        private System.Windows.Forms.Button btnSair;
    }
}

