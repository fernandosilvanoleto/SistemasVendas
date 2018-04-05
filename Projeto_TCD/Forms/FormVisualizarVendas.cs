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
    public partial class FormVisualizarVendas : Form
    {
        public FormVisualizarVendas()
        {
            InitializeComponent();
        }
        public FormVisualizarVendas(Boolean gerente) :this()
        {
            if(gerente)
            {
                this.buttonVendaPorEst.Enabled = true;
                this.button1.Enabled = true;
            }
            else
            {
                this.buttonVendaPorEst.Visible = false;
                this.button1.Visible = false;
            }
        }

        private void FormVisualizarVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseBancosDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.databaseBancosDataSet.Cliente);
            preencherList();

            ToolTip tool = new ToolTip();
            tool.AutoPopDelay = 5000;
            tool.InitialDelay = 100;
            tool.ReshowDelay = 500;

            tool.ShowAlways = true;
            tool.SetToolTip(this.buttonVendaPorEst, "Vendas por Estado");
            tool.SetToolTip(this.buttonSair, "Sair");
            tool.SetToolTip(this.button1, "Estado que compram mais");
        }
        public void preencherList()
        {
            try
            {
                listViewRelatorios.Items.Clear();

                List<Vendas> vendas = VendasManager.All();

                for (int i = 0; i < vendas.Count; i++)
                {
                    ListViewItem item = new ListViewItem(new string[]{
                    vendas[i].idVenda+"",
                    vendas[i].idCliente+"",
                    vendas[i].Cliente.NomeCliente,
                    vendas[i].Maquina.Nome,
                    vendas[i].Maquina.Marca.Nome,
                    vendas[i].CustoTotal+"",
                    vendas[i].DataVenda+""
                });
                    listViewRelatorios.Items.Add(item);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar selecionar venda" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void listViewRelatorios_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int codVenda = int.Parse(listViewRelatorios.SelectedItems[0].SubItems[0].Text);
               
                Vendas vendasAl = VendasManager.Localizar(codVenda);
                
                FormVenda ven = new FormVenda(vendasAl);
                
                ven.ShowDialog();                
                preencherList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonVendaPorEst_Click(object sender, EventArgs e)
        {
            FormGraficoPorEstado estGraf = new FormGraficoPorEstado();
            estGraf.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDados dados = new FormDados();
            dados.ShowDialog();
        }

        private void listViewRelatorios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
