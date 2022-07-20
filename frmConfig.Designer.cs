namespace FundoTela
{
    partial class frmConfig
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelTela = new System.Windows.Forms.Panel();
            this.rBtnNormal = new System.Windows.Forms.RadioButton();
            this.rBtnMax = new System.Windows.Forms.RadioButton();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnExTodos = new System.Windows.Forms.Button();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numSlideTempo = new System.Windows.Forms.NumericUpDown();
            this.lblFoto = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelTela.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelSlide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSlideTempo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 40);
            this.panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(249, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(113, 21);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Configuração";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = global::FundoTela.Properties.Resources.fechar24;
            this.btnFechar.Location = new System.Drawing.Point(573, 6);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(33, 28);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(364, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(307, 162);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(39, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(112, 36);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir Marcados";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.panelTela);
            this.groupBox1.Controls.Add(this.panelButtons);
            this.groupBox1.Controls.Add(this.panelSlide);
            this.groupBox1.Location = new System.Drawing.Point(63, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 193);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informe:";
            // 
            // panelTela
            // 
            this.panelTela.Controls.Add(this.rBtnNormal);
            this.panelTela.Controls.Add(this.rBtnMax);
            this.panelTela.Location = new System.Drawing.Point(75, 87);
            this.panelTela.Name = "panelTela";
            this.panelTela.Size = new System.Drawing.Size(325, 27);
            this.panelTela.TabIndex = 14;
            // 
            // rBtnNormal
            // 
            this.rBtnNormal.AutoSize = true;
            this.rBtnNormal.Location = new System.Drawing.Point(194, 4);
            this.rBtnNormal.Name = "rBtnNormal";
            this.rBtnNormal.Size = new System.Drawing.Size(88, 19);
            this.rBtnNormal.TabIndex = 1;
            this.rBtnNormal.TabStop = true;
            this.rBtnNormal.Text = "Tela Normal";
            this.rBtnNormal.UseVisualStyleBackColor = true;
            // 
            // rBtnMax
            // 
            this.rBtnMax.AutoSize = true;
            this.rBtnMax.Location = new System.Drawing.Point(43, 4);
            this.rBtnMax.Name = "rBtnMax";
            this.rBtnMax.Size = new System.Drawing.Size(112, 19);
            this.rBtnMax.TabIndex = 0;
            this.rBtnMax.TabStop = true;
            this.rBtnMax.Text = "Tela Maximizada";
            this.rBtnMax.UseVisualStyleBackColor = true;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnExcluir);
            this.panelButtons.Controls.Add(this.btnExTodos);
            this.panelButtons.Location = new System.Drawing.Point(75, 127);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(325, 40);
            this.panelButtons.TabIndex = 13;
            // 
            // btnExTodos
            // 
            this.btnExTodos.Location = new System.Drawing.Point(179, 3);
            this.btnExTodos.Name = "btnExTodos";
            this.btnExTodos.Size = new System.Drawing.Size(112, 36);
            this.btnExTodos.TabIndex = 12;
            this.btnExTodos.Text = "Excluir Todos";
            this.btnExTodos.UseVisualStyleBackColor = true;
            // 
            // panelSlide
            // 
            this.panelSlide.Controls.Add(this.label3);
            this.panelSlide.Controls.Add(this.label4);
            this.panelSlide.Controls.Add(this.numSlideTempo);
            this.panelSlide.Location = new System.Drawing.Point(75, 48);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(325, 27);
            this.panelSlide.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "segundos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tempo de exposição do Slide  em";
            // 
            // numSlideTempo
            // 
            this.numSlideTempo.Location = new System.Drawing.Point(193, 1);
            this.numSlideTempo.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numSlideTempo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSlideTempo.Name = "numSlideTempo";
            this.numSlideTempo.Size = new System.Drawing.Size(64, 23);
            this.numSlideTempo.TabIndex = 14;
            this.numSlideTempo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(365, 173);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(38, 15);
            this.lblFoto.TabIndex = 13;
            this.lblFoto.Text = "label1";
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(612, 474);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfig";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panelTela.ResumeLayout(false);
            this.panelTela.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelSlide.ResumeLayout(false);
            this.panelSlide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSlideTempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Button btnExcluir;
        private Button btnFechar;
        private Label lblTitulo;
        private GroupBox groupBox1;
        private Button btnExTodos;
        private Panel panelButtons;
        private Panel panelSlide;
        private Label label3;
        private Label label4;
        private NumericUpDown numSlideTempo;
        private Label lblFoto;
        private Panel panelTela;
        private RadioButton rBtnNormal;
        private RadioButton rBtnMax;
    }
}