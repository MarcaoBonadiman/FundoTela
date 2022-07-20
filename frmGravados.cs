using System.Data;

namespace FundoTela
{
    public partial class frmGravados : Form
    {
        FileInfo[]? filesInfo;
        private int ponteiro = 0;

        int w; // Largura
        int h; // Altura
        int mEsq; // Margem Esquerda
        int mDir; // Margem Direita
        int mTop; // Margem do Topo

        public frmGravados(Form _this)
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Monitor;

            btnFechar.Click += BtnFechar_Click;
            btnMinimizar.Click += BtnMinimizar_Click;
            btnWallPaper.Click += BtnWallPaper_Click;

            Size pai = _this.Size;
            if (Properties.Settings.Default.maximize)
            {
                w = Convert.ToInt16(pai.Width * 0.60); // Dimensiona o comprimento deste Form em 60% da tela pai
                h = Convert.ToInt16(pai.Height * 0.75); // Dimensiona a altura deste Form em 75% da tela pai
            }
            else
            {
                w = Convert.ToInt16(pai.Width * 0.90); // Dimensiona o comprimento deste Form em 80% da tela pai
                h = Convert.ToInt16(pai.Height * 0.90); // Dimensiona a altura deste Form em 80% da tela pai
            }
            // Dimensiona esse Form com os valores calculados
            this.Size = new Size(w, h); // Faz esse Form com os valores calculados

            // Dimensiona o dataGridView e pictureBox conforme o tamanho da tela
            this.dataGridView1.Size = new Size(Convert.ToInt16(w * 0.45), Convert.ToInt16(h * 0.865));
            this.pictureBox1.Size = new Size(Convert.ToInt16(w * 0.45), Convert.ToInt16(h * 0.45));

            mTop = 62; // Margem do topo
            this.lblTitulo.Location = new Point((panel1.Width - this.lblTitulo.Size.Width) / 2, 10);

            mEsq = ((this.Size.Width - (this.dataGridView1.Size.Width + this.pictureBox1.Size.Width)) / 2) - 3; // A margem da Esquerda para o "dataGridView1"
            this.dataGridView1.Location = new Point(mEsq, mTop);

            mDir = (this.Size.Width / 2) + 6; // A margem mais ao cento para "pictureBox1 e groupBox1" 
            this.pictureBox1.Location = new Point(mDir, mTop);

            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            this.btnWallPaper.Location = new Point(mDir+Convert.ToInt16((this.pictureBox1.Size.Width - this.btnWallPaper.Size.Width) / 2), this.pictureBox1.Size.Height+80);


            Init();

            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.KeyUp += dataGridView1_KeyUp;

        }

        // Permite minimizar a tela para visualizar melhor a área de trabalho com o novo fundo de tela
        private void BtnMinimizar_Click(object? sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        // Permite passar a foto selecionda para o fundo de tela
        private void BtnWallPaper_Click(object? sender, EventArgs e)
        {
            if (ponteiro != -1 && filesInfo != null)
            {
                try
                {
                    string x = filesInfo[ponteiro].DirectoryName + "/" + filesInfo[ponteiro].Name;
                    Wallpaper.Set(Wallpaper.Style.Centered, x);
                }
                catch (Exception) { }
            }
        }


        // Fecha esse form
        private void BtnFechar_Click(object? sender, EventArgs e)
        {
            this.Close();
        }


        private void Init()
        {
            // Carrega todas as fotos da pasta (Imagens/FundoTela)
            cFuncoes.LerDir(frmPrincipal.localPath, "*.jpg", ref ponteiro, ref filesInfo);
            if (filesInfo != null && filesInfo.Length > 0)
            {
                DataTable dt = new DataTable(); // Defino um DataTable vazio e adiciono 2 colunas, "id" e "file"
                dt.Columns.Add("id");
                dt.Columns.Add("file");
                for (int i = 0; i < filesInfo?.Length; i++)
                {
                    DataRow dRow = dt.NewRow(); // Defino uma Row com 2 colunas , "id" e "file" e populo com nome do arquivo
                    dRow["id"] = i + 1;
                    dRow["file"] = filesInfo[i].Name;
                    dt.Rows.Add(dRow);  // Adiciono ao dataTable a linha Row
                }
                dataGridView1.DataSource = dt;
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

            dataGridView1.Columns["id"].HeaderText = "Item";
            dataGridView1.Columns["id"].Width = 50;
            dataGridView1.Columns["id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["file"].HeaderText = "Nome do arquivo";
            dataGridView1.Columns["file"].Width = 200;
            dataGridView1.Columns["file"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridView1.Refresh();
        }


        private void dataGridView1_KeyUp(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                LerID();
            }
        }

        private void dataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                LerID();
            }
        }

        private void LerID(int id = 0)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                ponteiro = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["id"].Value) - 1;
                ShowFoto(ponteiro);
            }
        }

        private void ShowFoto(int idx)
        {
            if (filesInfo != null)
            {
                Byte[] bytes = File.ReadAllBytes(filesInfo[idx].DirectoryName + "/" + filesInfo[idx].Name);
                MemoryStream ms = new MemoryStream(bytes, 0, bytes.Length);
                ms.Write(bytes, 0, bytes.Length);
                Image img = Image.FromStream(ms, true);
                pictureBox1.Image = img;
                //lblFoto.Text = "Altura:" + img.Height.ToString() + "   x    Largura: " + img.Width.ToString();
            }
        }


    }
}
