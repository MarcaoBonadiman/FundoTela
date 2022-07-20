namespace FundoTela
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGravados = new System.Windows.Forms.Button();
            this.linkLbl = new System.Windows.Forms.LinkLabel();
            this.lblFile = new System.Windows.Forms.Label();
            this.btnWallPaper = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnPasta = new System.Windows.Forms.Button();
            this.btnSlide = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnGravados);
            this.panel1.Controls.Add(this.linkLbl);
            this.panel1.Controls.Add(this.lblFile);
            this.panel1.Controls.Add(this.btnWallPaper);
            this.panel1.Controls.Add(this.btnConfig);
            this.panel1.Controls.Add(this.btnPasta);
            this.panel1.Controls.Add(this.btnSlide);
            this.panel1.Controls.Add(this.btnGravar);
            this.panel1.Controls.Add(this.btnProximo);
            this.panel1.Controls.Add(this.btnAnterior);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1419, 55);
            this.panel1.TabIndex = 0;
            // 
            // btnGravados
            // 
            this.btnGravados.BackColor = System.Drawing.Color.Orange;
            this.btnGravados.FlatAppearance.BorderSize = 0;
            this.btnGravados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravados.Location = new System.Drawing.Point(154, 9);
            this.btnGravados.Name = "btnGravados";
            this.btnGravados.Size = new System.Drawing.Size(74, 23);
            this.btnGravados.TabIndex = 11;
            this.btnGravados.Text = "Gravados";
            this.btnGravados.UseVisualStyleBackColor = false;
            // 
            // linkLbl
            // 
            this.linkLbl.AutoSize = true;
            this.linkLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLbl.LinkColor = System.Drawing.Color.Orange;
            this.linkLbl.Location = new System.Drawing.Point(513, 12);
            this.linkLbl.Name = "linkLbl";
            this.linkLbl.Size = new System.Drawing.Size(40, 15);
            this.linkLbl.TabIndex = 10;
            this.linkLbl.TabStop = true;
            this.linkLbl.Text = "Sobre";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.ForeColor = System.Drawing.Color.White;
            this.lblFile.Location = new System.Drawing.Point(11, 37);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(38, 15);
            this.lblFile.TabIndex = 9;
            this.lblFile.Text = "label1";
            // 
            // btnWallPaper
            // 
            this.btnWallPaper.BackColor = System.Drawing.Color.Orange;
            this.btnWallPaper.FlatAppearance.BorderSize = 0;
            this.btnWallPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWallPaper.Location = new System.Drawing.Point(385, 9);
            this.btnWallPaper.Name = "btnWallPaper";
            this.btnWallPaper.Size = new System.Drawing.Size(74, 23);
            this.btnWallPaper.TabIndex = 8;
            this.btnWallPaper.Text = "Wallpaper";
            this.btnWallPaper.UseVisualStyleBackColor = false;
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Image = global::FundoTela.Properties.Resources.settings_24;
            this.btnConfig.Location = new System.Drawing.Point(474, 9);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(32, 23);
            this.btnConfig.TabIndex = 4;
            this.btnConfig.UseVisualStyleBackColor = false;
            // 
            // btnPasta
            // 
            this.btnPasta.BackColor = System.Drawing.Color.Orange;
            this.btnPasta.FlatAppearance.BorderSize = 0;
            this.btnPasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasta.Location = new System.Drawing.Point(308, 9);
            this.btnPasta.Name = "btnPasta";
            this.btnPasta.Size = new System.Drawing.Size(74, 23);
            this.btnPasta.TabIndex = 7;
            this.btnPasta.Text = "Pasta";
            this.btnPasta.UseVisualStyleBackColor = false;
            // 
            // btnSlide
            // 
            this.btnSlide.BackColor = System.Drawing.Color.Orange;
            this.btnSlide.FlatAppearance.BorderSize = 0;
            this.btnSlide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlide.Location = new System.Drawing.Point(231, 9);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(74, 23);
            this.btnSlide.TabIndex = 6;
            this.btnSlide.Text = "Slide";
            this.btnSlide.UseVisualStyleBackColor = false;
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.Orange;
            this.btnGravar.FlatAppearance.BorderSize = 0;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Location = new System.Drawing.Point(77, 9);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(74, 23);
            this.btnGravar.TabIndex = 5;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.Orange;
            this.btnProximo.FlatAppearance.BorderSize = 0;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Image = global::FundoTela.Properties.Resources.seta_direita_24;
            this.btnProximo.Location = new System.Drawing.Point(43, 9);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(31, 23);
            this.btnProximo.TabIndex = 3;
            this.btnProximo.UseVisualStyleBackColor = false;
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.Orange;
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Image = global::FundoTela.Properties.Resources.seta_esquerda_24;
            this.btnAnterior.Location = new System.Drawing.Point(9, 9);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(31, 23);
            this.btnAnterior.TabIndex = 2;
            this.btnAnterior.UseVisualStyleBackColor = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::FundoTela.Properties.Resources.minimizar24;
            this.btnMinimizar.Location = new System.Drawing.Point(1335, 7);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(33, 28);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = global::FundoTela.Properties.Resources.fechar24;
            this.btnFechar.Location = new System.Drawing.Point(1375, 7);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(33, 28);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 199);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 786);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnFechar;
        private Button btnMinimizar;
        private Label lblFile;
        private Button btnWallPaper;
        private Button btnPasta;
        private Button btnSlide;
        private Button btnGravar;
        private Button btnConfig;
        private Button btnProximo;
        private Button btnAnterior;
        private SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private LinkLabel linkLbl;
        private Button btnGravados;
    }
}