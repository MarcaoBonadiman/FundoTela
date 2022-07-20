using System.Diagnostics;

namespace FundoTela
{
    public partial class frmPrincipal : Form
    {
        // Pasta onde se encontra as fotos baixada pelo Windows. Esta pasta é genrenciada pelo próprio Windows, isto é, as fotos são apagadas ou subtituida automaticamente.
        public static string originalPath = @"%userprofile%\AppData\Local\Packages\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\LocalState\Assets";

        // Pasta onde o usuário guarda as fotos de deseja fazer uma cópia (Imagens\FundoTela)
        public static string localPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\FundoTela";

        FileInfo[]? filesInfo; 
        private int ponteiro = 0;
        private int oldPonteiro = -1;
        private bool slideShow = false;

        public frmPrincipal()
        {
            InitializeComponent();

            TamTela();

            // Verifica se existe a pasta (Imagens/FundoTela) 
            if (!Directory.Exists(localPath))
            {
                Directory.CreateDirectory(localPath); // Se não existe cria
            }

            // Define o Icon que vai aparecer na barra de tarefa do Windows
            Icon = Properties.Resources.Monitor;
            lblFile.Text = "";

            pictureBox1.Dock = DockStyle.Fill;
            StartPosition = FormStartPosition.CenterScreen;

            // Defino os eventos
            Activated += FrmPrincipal_Activated;
            btnFechar.Click += BtnFechar_Click;
            btnMinimizar.Click += BtnMinimizar_Click;
            btnProximo.Click += BtnProximo_Click;
            btnAnterior.Click += BtnAnterior_Click;
            btnGravar.Click += BtnCopiar_Click;
            btnGravados.Click += BtnGravados_Click;
            btnSlide.Click += BtnSlide_Click;
            btnPasta.Click += BtnPasta_Click;
            btnWallPaper.Click += BtnWallPaper_Click;
            btnConfig.Click += BtnConfig_Click;
            timer1.Tick += Timer1_Tick;
            SizeChanged += FrmPrincipal_SizeChanged;
            linkLbl.LinkClicked += LinkLbl_LinkClicked;

            ActiveControl = btnProximo;
        }

        private void FrmPrincipal_Activated(object? sender, EventArgs e)
        {
            TamTela();
            cFuncoes.LerDir(originalPath, "*.", ref ponteiro, ref filesInfo); // Ler as fotos que estão na pasta do Windows
            ShowIMG();
        }


        // Exibe em outra tela as fotos que já foram copiadas
        private void BtnGravados_Click(object? sender, EventArgs e)
        {
            // Verifica se a pasta está vazia
            var filePath = Environment.ExpandEnvironmentVariables(localPath);
            DirectoryInfo d = new DirectoryInfo(filePath);
            if (d.GetFileSystemInfos().Length == 0)
            {
                MessageBox.Show("A pasta: " + localPath + " está vazia!");
            }
            else
            {
                using (frmGravados frm = new frmGravados(this))
                {
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }
            }
        }

        // Tela que exibe meu nome e meu site
        private void LinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (frmSobre frm = new frmSobre()) {
                frm.ShowDialog();
            }
        }


        // Tela de configuração
        private void BtnConfig_Click(object? sender, EventArgs e)
        {
            using (frmConfig frm = new frmConfig(this))
            {
                frm.ShowDialog();
            }
        }

        // Faz da imagem da tela ser o fundo de tela da área de trabalho
        private void BtnWallPaper_Click(object? sender, EventArgs e)
        {
            if (ponteiro != -1 && filesInfo!=null) 
            {
                try
                {
                    string x = filesInfo[ponteiro].DirectoryName + "/" + filesInfo[ponteiro].Name;
                    Wallpaper.Set(Wallpaper.Style.Centered, x);
                }
                catch (Exception) { }
            }
        }

        // Abre o Windows Explore na pasta onde as fotos que o Windows fez download
        private void BtnPasta_Click(object? sender, EventArgs e)
        {
            // Verifica se a pasta está vazia
            var filePath = Environment.ExpandEnvironmentVariables(originalPath);
            DirectoryInfo d = new DirectoryInfo(filePath);
            if (d.GetFileSystemInfos().Length == 0)
            {
                MessageBox.Show("A pasta: " + originalPath + "\n está vazia!");
            }
            else
            {
                Process.Start("explorer.exe", filePath);
            }
        }

        // O Timer é usado para exibir o Slide
        private void Timer1_Tick(object? sender, EventArgs e)
        {
            timer1.Stop();
            ShowIMG();
            ponteiro++;
            if (ponteiro > filesInfo?.Length - 1) ponteiro = 0;
            timer1.Interval = (Properties.Settings.Default.slideTemp * 1000);
            timer1.Start();
        }


        // Liga a exibição dos slides. Para desligar pressione qualquer tela do teclado.
        private void BtnSlide_Click(object? sender, EventArgs e)
        {
            oldPonteiro = ponteiro;
            ponteiro = 0;
            slideShow = !slideShow;
            if (slideShow)
            {
                // Liga a exibição dos slides
                cFuncoes.LerDir(localPath, "*.jpg", ref ponteiro, ref filesInfo); // Ler todas as fotos da pasta (Imagens/FundoTela)
                if (ponteiro == -1)
                {
                    MessageBox.Show("Pasta: \"" + localPath + "\" não contém fotos!");
                }
                else
                {
                    panel1.Visible   = false;  // Torna o Top (Menu) invisível
                    this.WindowState = FormWindowState.Maximized; // Passo a tela para o tamanho máximo
                    timer1.Interval  = 1;     // Valor to tempo é 1 (um) para iniciar imediatamente. Dentro do Timer.Tick mudo esse valor para o tempo definido pelo usuário
                    timer1.Start();          // Inicia a exibição dos Slide chamando o Timer.Tick
                }
            }
            else
            {
                // Desliga a exibição dos slides
                if (Properties.Settings.Default.maximize) this.WindowState = FormWindowState.Maximized;
                else this.WindowState = FormWindowState.Normal;
                panel1.Visible = true;
                timer1.Stop();
                cFuncoes.LerDir(originalPath, "*.", ref ponteiro, ref filesInfo); // Ler as fotos que estão na pasta do Windows
                ShowIMG();
            }
        }

        // Opção de fazer a Cópia da foto da tela para a pasta (Imagens/FundoTela)
        private void BtnCopiar_Click(object? sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = localPath;
            saveFileDialog1.FileName = "";
            saveFileDialog1.DefaultExt = "jpg";
            saveFileDialog1.Filter = "Tipo arquivo (*.jpg)|*.jpg";
            saveFileDialog1.AddExtension = true;
            String extension = ".jpg";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Byte[] bytes = File.ReadAllBytes(filesInfo?[ponteiro].DirectoryName + "/" + filesInfo?[ponteiro].Name);
                if (saveFileDialog1.FileName.Contains("."))
                {
                    File.WriteAllBytes(saveFileDialog1.FileName, bytes);
                }
                else
                {
                    File.WriteAllBytes(saveFileDialog1.FileName + extension, bytes);
                }
            }
        }

        // Navega para a foto anterior
        private void BtnAnterior_Click(object? sender, EventArgs e)
        {
            ponteiro--;
            if (ponteiro < 0) ponteiro = 0;
            ShowIMG();
        }

        // Navega para a foto posterior
        private void BtnProximo_Click(object? sender, EventArgs e)
        {
            ponteiro++;
            if (filesInfo != null)
            {
                if (ponteiro > filesInfo.Count() - 1) ponteiro = filesInfo.Count() - 1;
                ShowIMG();
            }
        }

        // Botão de minimizar a tela do aplicativo
        private void BtnMinimizar_Click(object? sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        // Botão de fechar o aplicativo
        private void BtnFechar_Click(object? sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }


        // Exibe a foto na tela, seu nome e resolução
        private void ShowIMG()
        {
            if (ponteiro < 0)
            {
                lblFile.Text = "Fotos: 0/0";
                pictureBox1.Image = null;
            }
            else
            {
                if (filesInfo?.Length > 0)
                {
                    try
                    {
                        if (ponteiro > filesInfo.Length - 1) ponteiro = filesInfo.Length - 1;
                        pictureBox1.Height = this.Height;
                        pictureBox1.Width = this.Width;
                        
                        // Leio o arquivo do disco e guarda na variável "bytes"
                        Byte[] bytes = File.ReadAllBytes(filesInfo[ponteiro].DirectoryName + "/" + filesInfo[ponteiro].Name);

                        // Converto para Stream em memória
                        MemoryStream ms = new MemoryStream(bytes, 0, bytes.Length);
                        
                        // Converto para Imagem
                        ms.Write(bytes, 0, bytes.Length);
                        Image img = Image.FromStream(ms, true);

                        // Exibo na Picture
                        pictureBox1.Image = img;

                        // Pego o tamanho da imagem
                        var size = pictureBox1.Image.Size;

                        this.lblFile.AutoSize = false;
                        this.lblFile.Text = "Fotos: " + (ponteiro + 1).ToString() + "/" + filesInfo.Length.ToString() + ",  Altura:" + size.Height.ToString() + ",  Largura: " + size.Width.ToString() + ",  Arquivo :" + filesInfo[ponteiro].Name;

                        // Se resolução da foto for maior que a tela, defino a Picture para "Stretch"
                        if (size.Height > this.Height || size.Width > this.Width) pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        else pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage; // Se não, apenas centralizo
                    }
                    catch (Exception) { }
                }
            }
        }


        // Fica escutando se alguma tela foi pressionada, útil quando o Slide for ligado, pois qualquer tecla pressiona faz desligar o Slide
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (slideShow) // Se qualquer tecla for pressionada e o Slide foi ligado
            {
                slideShow = false;
                TamTela();
                if (timer1.Enabled) timer1.Stop();
                cFuncoes.LerDir(originalPath, "*.", ref ponteiro, ref filesInfo);
                panel1.Visible = true;
                ponteiro = oldPonteiro;
                ShowIMG();
                this.ActiveControl = btnProximo;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        // Recupera a tela quando o App sair do minimizado 
        private void FrmPrincipal_SizeChanged(object? sender, EventArgs e)
        {
            if (!slideShow && this.WindowState != FormWindowState.Minimized)
            {
                TamTela();
            }
        }

        // Define o tamando da tela conforme configuração do usuário (Maximizada ou Normal (60% da largura e 75% da altura da tela cheia)
        private void TamTela()
        {
            if (Properties.Settings.Default.maximize)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                int screenWidth  = Screen.PrimaryScreen.Bounds.Width;
                int screenHeight = Screen.PrimaryScreen.Bounds.Height;
                int thiswidth    = Convert.ToInt32(screenWidth * .60);
                int thisheight   = Convert.ToInt32(thiswidth * .75);

                this.WindowState = FormWindowState.Normal;
                this.Location = new Point((screenWidth - thiswidth) / 2, (screenHeight - thisheight) / 2);
                this.Size = new Size(thiswidth, thisheight);
            }
        }
    }
}