using System.Diagnostics;
using System.Data;

namespace FundoTela
{
    public partial class frmConfig : Form
    {
        FileInfo[]? filesInfo;
        private int ponteiro = 0;

        int w; // Largura
        int h; // Altura
        int mEsq; // Margem Esquerda
        int mDir; // Margem Direita
        int mTop; // Margem do Topo

        public frmConfig(Form _this)
        {
            InitializeComponent();
            btnFechar.Click += BtnFechar_Click;

            Size pai = _this.Size;
            if (Properties.Settings.Default.maximize)
            {
                w = Convert.ToInt16(pai.Width * 0.60); // Dimensiona o comprimento deste Form em 60% da tela pai
                h = Convert.ToInt16(pai.Height * 0.75); // Dimensiona a altura deste Form em 75% da tela pai
            }
            else
            {
                w = Convert.ToInt16(pai.Width * 0.90); // Dimensiona o comprimento deste Form em 90% da tela pai
                h = Convert.ToInt16(pai.Height * 0.90); // Dimensiona a altura deste Form em 90% da tela pai
            }
            // Dimensiona esse Form com os valores calculados
            this.Size = new Size(w, h); 

            // Dimensiona o dataGridView, pictureBox e groupBox conforme o tamanho da tela
            this.dataGridView1.Size = new Size(Convert.ToInt16(w * 0.45), Convert.ToInt16(h * 0.865));
            this.pictureBox1.Size = new Size(Convert.ToInt16(w * 0.45), Convert.ToInt16(h * 0.45));
            this.groupBox1.Size = new Size(Convert.ToInt16(w * 0.45), Convert.ToInt16(h * 0.35));

            // Popula o numericUpDown com o valor quardado em "Properties.Settings.Default.slideTemp"
            this.numSlideTempo.Value = Properties.Settings.Default.slideTemp;

            if (Properties.Settings.Default.maximize) this.rBtnMax.Checked = true;
            else this.rBtnNormal.Checked = true;

            mTop = 62; // Margem do topo
            this.lblTitulo.Location = new Point((panel1.Width - this.lblTitulo.Size.Width) / 2, 10);


            // A margem da Esquerda para o "dataGridView1"
            mEsq = ((this.Size.Width -(this.dataGridView1.Size.Width+ this.pictureBox1.Size.Width))/2)-3; // A margem da Esquerda para o "dataGridView1"
            this.dataGridView1.Location = new Point(mEsq, mTop);

            // A margem mais ao cento para "pictureBox1 e groupBox1" 
            mDir = (this.Size.Width/2)+6; 
            this.pictureBox1.Location = new Point(mDir, mTop);
            this.lblFoto.Location = new Point(mDir, this.pictureBox1.Size.Height+65);
            this.lblFoto.Size = new Size(this.pictureBox1.Size.Width, 15);
            this.lblFoto.AutoSize = false;
            this.lblFoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.groupBox1.Location = new Point(this.pictureBox1.Location.X, this.pictureBox1.Size.Height + 95);
            this.panelSlide.Location = new Point(Convert.ToInt16((this.groupBox1.Size.Width - this.panelSlide.Size.Width) / 2), Convert.ToInt16(this.groupBox1.Location.Y * .15));

            this.panelTela.Location = new Point(Convert.ToInt16((this.groupBox1.Size.Width - this.panelSlide.Size.Width) / 2), this.panelSlide.Location.Y+45);

            this.panelButtons.Location = new Point(Convert.ToInt16((this.groupBox1.Size.Width - this.panelButtons.Size.Width) / 2), Convert.ToInt16(this.groupBox1.Location.Y * .40));
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            this.btnExcluir.Click += BtnExcluir_Click;
            this.btnExTodos.Click += BtnExTodos_Click;

            Init();

            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.KeyUp += dataGridView1_KeyUp;

        }


        private void Init()
        {
            if (dataGridView1.Columns["chks"] != null)
            {
                dataGridView1.Columns.Remove("chks");
            }
            cFuncoes.LerDir(frmPrincipal.originalPath, "*.", ref ponteiro, ref filesInfo);
            if (filesInfo != null && filesInfo.Length > 0)
            {
                DataTable dt = new DataTable(); // Defino um DataTable vazio e adiciono 3 colunas, "id", "file" e "status"
                dt.Columns.Add("id");
                dt.Columns.Add("file");
                dt.Columns.Add("status");
                for (int i = 0; i < filesInfo?.Length; i++)
                {
                    DataRow dRow = dt.NewRow(); // Defino uma Row com 3 colunas , "id", "file" e "status" e populo com nome do arquivo
                    dRow["id"] = i + 1;
                    dRow["file"] = filesInfo[i].Name;
                    dRow["status"] = 0;
                    dt.Rows.Add(dRow);  // Adiciono ao dataTable a linha Row
                }
                dataGridView1.DataSource = dt; // Passo o dataTable para o Grid
                GRID_INIT();
                ShowFoto(0); // Exibe a primeira foto do Grid
                this.ActiveControl = dataGridView1;
            }
            else
            {
                dataGridView1.DataSource = null;
                pictureBox1 = null; 
            }
        }

        private void GRID_INIT()
        {
            // Definição default do Grid
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowDrop = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.EnableHeadersVisualStyles = true;

            dataGridView1.Columns["status"].Visible = false;

            dataGridView1.Columns["id"].HeaderText = "Item";
            dataGridView1.Columns["id"].Width = 50;
            dataGridView1.Columns["id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["file"].HeaderText = "Nome do arquivo";
            dataGridView1.Columns["file"].Width = 200;
            // Adiciono um CheckBox ao Grid se não existir
            if (!dataGridView1.Columns.Contains("chks") == true)
            {
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                dataGridView1.Columns.Add(chk);
                chk.HeaderText = "Status";
                chk.Name = "chks";
                chk.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dataGridView1.Columns["chks"].Width = 50;
            dataGridView1.Columns["file"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            if (dataGridView1.Columns["chks"] != null)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells["chks"].Value = Convert.ToInt32(row.Cells["status"].Value);
                }
            }
            dataGridView1.Refresh();
        }


        // Se uma tecla foi pressionada, ao soltar entra aqui
        private void dataGridView1_KeyUp(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                LerID();
            }
        }

        // Se foi clicado com o mouse em algima linha
        private void dataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                LerID();
            }

            // Se foi clicado na coluna do CheckBox
            if (e.ColumnIndex == dataGridView1.Rows[e.RowIndex].Cells["chks"].ColumnIndex)
            {
                int st = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["chks"].Value);
                if (st == 0) dataGridView1.Rows[e.RowIndex].Cells["chks"].Value = 1;
                else dataGridView1.Rows[e.RowIndex].Cells["chks"].Value = 0;
                dataGridView1.EndEdit();
            }
        }


        // Fecha o form e grava os valores que foram alterados
        private void BtnFechar_Click(object? sender, EventArgs e)
        {
            Properties.Settings.Default.slideTemp = Convert.ToInt16(this.numSlideTempo.Value);
            if (this.rBtnMax.Checked) Properties.Settings.Default.maximize = true;
            else Properties.Settings.Default.maximize = false;
            Properties.Settings.Default.Save();
            this.Close();
        }

        // Atualiza a variável ponteiro e mostra a foto correspondente
        private void LerID()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                ponteiro = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["id"].Value)-1;
                ShowFoto(ponteiro);
            }
        }

        // Exibe a foto selecionada
        private void ShowFoto(int idx)
        {
            if (filesInfo != null)
            {
                Byte[] bytes = File.ReadAllBytes(filesInfo[idx].DirectoryName + "/" + filesInfo[idx].Name);
                MemoryStream ms = new MemoryStream(bytes, 0, bytes.Length);
                ms.Write(bytes, 0, bytes.Length);
                Image img = Image.FromStream(ms, true);
                pictureBox1.Image = img;
                lblFoto.Text = "Altura:" + img.Height.ToString() + "   x    Largura: " + img.Width.ToString();
            }
        }

        // Botão para excluir todas as fotos 
        private void BtnExTodos_Click(object? sender, EventArgs e)
        {
            if (filesInfo?.Length > 0)
            {
                DialogResult result = new DialogResult();
                if (filesInfo?.Length == 1)
                {
                    result = MessageBox.Show("Confirma excluir o arquivo?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                else
                {
                    result = MessageBox.Show("Confirma excluir todos os " + filesInfo?.Length + " arquivos?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        string filePath = Environment.ExpandEnvironmentVariables(frmPrincipal.originalPath);
                        if (!filePath.EndsWith("/")) filePath += @"/";
                        filePath += row.Cells["file"].Value;
                        if (File.Exists(filePath))
                        {
                            File.Delete(filePath);
                            //Debug.WriteLine("File: " + filePath);
                        }
                    }
                    Init();
                }
            }
        }

        // Exclui as fotos que foram ticadas
        private void BtnExcluir_Click(object? sender, EventArgs e)
        {
            int cnt = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToInt16(row.Cells["chks"].Value) == 1)
                {
                    cnt++;
                }
            }
            if (cnt > 0)
            {
                DialogResult result = new DialogResult();
                if (cnt == 1)
                {
                    result = MessageBox.Show("Confirma excluir o selecionado", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                else if (cnt > 1)
                {
                    result = MessageBox.Show("Confirma excluir os selecionados", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (Convert.ToInt16(row.Cells["chks"].Value)==1)
                        {
                            string filePath = Environment.ExpandEnvironmentVariables(frmPrincipal.originalPath);
                            if (!filePath.EndsWith("/")) filePath += @"/";
                            filePath += row.Cells["file"].Value;
                            if (File.Exists(filePath))
                            {
                                File.Delete(filePath);
                                //Debug.WriteLine("File: " + filePath);
                            }
                        }
                    }
                    Init();
                }
            }
        }
    }
}
