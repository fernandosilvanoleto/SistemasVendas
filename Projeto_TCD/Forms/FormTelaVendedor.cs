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
using Projeto_TCD.Forms;

namespace Projeto_TCD
{
    public partial class FormTelaVendedor : Form
    {
        public FormTelaVendedor()
        {
            InitializeComponent();
        }

        public FormTelaVendedor(int numero) :this()
        {
            
        }

        private void FormTelaVendedor_Load(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();
            tool.AutoPopDelay = 5000;
            tool.InitialDelay = 100;
            tool.ReshowDelay = 500;

            tool.ShowAlways = true;
            tool.SetToolTip(this.buttonSair, "Sair");
            tool.SetToolTip(this.buttonSistema,"Sobre o sistema");
            tool.SetToolTip(this.buttonVendas,"Cadastrar Venda");
            tool.SetToolTip(this.buttonVerCliente,"Visualizar cliente");
            tool.SetToolTip(this.buttonVerVendas,"Visualizar vendas");
            tool.SetToolTip(this.button1,"Cadastrar cliente");
        }

       

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonVendas_Click(object sender, EventArgs e)
        {
            FormVenda venda = new FormVenda();
            venda.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCliente cliente = new FormCliente();
            cliente.ShowDialog();
        }

        private void buttonVerCliente_Click(object sender, EventArgs e)
        {
            FormVerCliente clVer = new FormVerCliente();
            clVer.ShowDialog();
        }

        private void buttonVerVendas_Click(object sender, EventArgs e)
        {
            Boolean gerente = false;
            FormVisualizarVendas verVendas = new FormVisualizarVendas(gerente);
            verVendas.Show();
        }

        private void buttonSistema_Click(object sender, EventArgs e)
        {
            FormSigma sig = new FormSigma();
            sig.ShowDialog();
        }
    }
}
