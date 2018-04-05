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

namespace Projeto_TCD.Forms
{
    public partial class FormVerCliente : Form
    {
        List<Cliente> clienteV;
        
        public FormVerCliente()
        {
            InitializeComponent();
        }

        private void FormVerCliente_Load(object sender, EventArgs e)
        {
            preencherList();
            ToolTip tool = new ToolTip();
            tool.AutoPopDelay = 5000;
            tool.InitialDelay = 100;
            tool.ReshowDelay = 500;

            tool.ShowAlways = true;
            tool.SetToolTip(this.buttonLista, "Imprimir lista completa de cliente");
            tool.SetToolTip(this.buttonSair, "Sair");
        }

        void preencherList()
        {
            try
            {
                listView1.Items.Clear();
                clienteV = ClienteManager.All();

                for (int i = 0; i < clienteV.Count; i++)
                {
                    ListViewItem item = new ListViewItem(new string[]{
                    clienteV[i].idCliente+"",
                    clienteV[i].NomeCliente,
                    clienteV[i].Email,
                    clienteV[i].Telefone
                });
                    listView1.Items.Add(item);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao listar cliente" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int cod = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                string nome = listView1.SelectedItems[0].SubItems[1].Text;
                string email = listView1.SelectedItems[0].SubItems[2].Text;
                string tel = listView1.SelectedItems[0].SubItems[3].Text;
                Cliente cte = clienteV.Find(o => o.idCliente == cod && o.NomeCliente == nome && o.Email == email && o.Telefone == tel);

                FormCliente cC = new FormCliente(cte);
                cC.ShowDialog();
                preencherList();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar selecionar cliente" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                string valor = textBoxBuscar.Text;
                var clienteSearch = from c in this.clienteV
                                    where c.idCliente.Equals(valor) || c.NomeCliente.Contains(valor) || c.Email.Contains(valor) || c.Telefone.Contains(valor)
                                    select new { c.idCliente, c.NomeCliente, c.Email, c.Telefone };

                foreach (var c in clienteSearch)
                {
                    ListViewItem item = new ListViewItem(
                        new String[]{
                        c.idCliente+"",
                        c.NomeCliente,
                        c.Email,
                        c.Telefone
                    });
                    listView1.Items.Add(item);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar filtrar cliente" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void buttonLista_Click(object sender, EventArgs e)
        {
            FormListaCliente listaCliente = new FormListaCliente();
            listaCliente.ShowDialog();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {}
        private void label1_Click(object sender, EventArgs e)
        {     

        }
    }
}
