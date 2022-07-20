using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundoTela
{
    public partial class frmSobre : Form
    {
        public frmSobre()
        {
            InitializeComponent();
            btnSair.Click += BtnSair_Click;
            this.linkLabel1.LinkClicked += LinkLabel1_LinkClicked;
            System.Windows.Forms.Clipboard.SetText("https://marcaobonadiman.com.br");
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try {
                System.Diagnostics.Process.Start("https://marcaobonadiman.com.br");
            }catch (Exception)
            {
                MessageBox.Show("Link copiado para área de transferência");
            }
        }

        private void BtnSair_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
