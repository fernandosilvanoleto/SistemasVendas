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
    public partial class FormSigma : Form
    {
        public FormSigma()
        {
            InitializeComponent();
        }

        private void FormSigma_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
