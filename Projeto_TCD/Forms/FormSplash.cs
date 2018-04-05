using Projeto_TCD.Forms;
using Projeto_TCD.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_TCD
{
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
        }        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 1;
                label2.Text = "Carregando" + " " + progressBar1.Value + "%";
                if (progressBar1.Value >= 10 && progressBar1.Value <= 25)
                {
                    
                    label4.Text = "Bem vindo ao sistema...";
                }
                if (progressBar1.Value > 25 && progressBar1.Value <= 50)
                {
                    
                    label4.Text = "Dúvida sobre o SIGMA, entre em contato com nosso pessoal!";
                }
                if (progressBar1.Value > 50 && progressBar1.Value <= 75)
                {
                    
                    label4.Text = "Avalie o nosso sistema...";
                }
                if (progressBar1.Value > 75 && progressBar1.Value <= 100)
                {
                    
                    label4.Text = "SIGMA em busca da simplicidade para o campo e para a cidade!";
                }
            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false;
                Form1 f = new Form1();
                f.ShowDialog();
                this.Close();
            }
        }

        private void FormSplash_Load(object sender, EventArgs e)
        {}
        private void pictureBox1_Click(object sender, EventArgs e)
        { }
        private void progressBar1_Click(object sender, EventArgs e)
        { }
        
    }
}
