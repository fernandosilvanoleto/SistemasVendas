using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_TCD.Managers;

namespace Projeto_TCD.Forms
{
    public partial class FormContGerente : Form
    {
        public FormContGerente()
        {
            InitializeComponent();
        }

        private void FormContGerente_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 1;
                label1.Text = "Entrando em contato com gerente. Por favor, aguarde um instante...";
                if(progressBar1.Value >= 50 && progressBar1.Value <=65)
                {
                       label2.Text = "Gerente encontra em reunião!";
                }
                if(progressBar1.Value > 65)
                {
                    label2.Text = "Gerente analisando o caso...";
                }
                if(progressBar1.Value == 100)
                {
                    MessageBox.Show("Autorizado o desconto\n Att, \n Gerente de Vendas \n Fernando Silva Noleto");
                }
            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false;
                
                this.Close();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {}

        private void pictureBox1_Click(object sender, EventArgs e)
        {}

        private void label8_Click(object sender, EventArgs e)
        {}

        private void label2_Click(object sender, EventArgs e)
        {}

        private void label1_Click(object sender, EventArgs e)
        {}
    }
}
