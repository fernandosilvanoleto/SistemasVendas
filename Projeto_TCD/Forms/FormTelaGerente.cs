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
using Projeto_TCD.Forms;

namespace Projeto_TCD
{
    public partial class FormTelaGerente : Form
    {
        public FormTelaGerente()
        {
            InitializeComponent();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {}

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente clientesG = new FormCliente();
            clientesG.ShowDialog();
        }

        private void máquinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMaquina maquinaG = new FormMaquina();
            maquinaG.ShowDialog();
        }

        private void novasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean gerenteVendas = true;
            FormVenda vendasG = new FormVenda(gerenteVendas);
            vendasG.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVerCliente verClienteG = new FormVerCliente();
            verClienteG.ShowDialog();
        }

        private void máquinaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormVerMaquina verMaqG = new FormVerMaquina();
            verMaqG.ShowDialog();
        }

        private void vendasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Boolean gerente = true;
            FormVisualizarVendas vendasG = new FormVisualizarVendas(gerente);
            vendasG.ShowDialog();
        }

        private void buttonTerminarSess_Click(object sender, EventArgs e)
        {
            this.Close();
        }      

        private void buttonSistema_Click(object sender, EventArgs e)
        {
            FormSigma sigma = new FormSigma();
            sigma.ShowDialog();

        }       

        private void transferênciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTransferencia transf = new FormTransferencia();
            transf.ShowDialog();
        }
        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        { }
        private void máquinaToolStripMenuItem2_Click(object sender, EventArgs e)
        { }
        private void FormTelaGerente_Load(object sender, EventArgs e)
        { }
        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        { }
    }
}
