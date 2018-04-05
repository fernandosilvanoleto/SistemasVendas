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
    public partial class FormVerMaquina : Form
    {
        List<Maquina> maquinaV;
        public FormVerMaquina()
        {
            InitializeComponent();
        }

        private void FormVerMaquina_Load(object sender, EventArgs e)
        {
            preencherListMaq();            
        }

        public void preencherListMaq()
        {
            try
            {
                listView1.Items.Clear();
                maquinaV = MaquinaManager.All();
                for (int i = 0; i < maquinaV.Count; i++)
                {
                    ListViewItem item = new ListViewItem(new string[]{
                    maquinaV[i].idMaquina+"",
                    maquinaV[i].Nome,
                    maquinaV[i].Modelo,
                    maquinaV[i].ValorMaquina+"",
                    maquinaV[i].AnoFabricacao+""
                });
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao listar máquina" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int cod = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                string nome = listView1.SelectedItems[0].SubItems[1].Text;
                string Modelo = listView1.SelectedItems[0].SubItems[2].Text;
                double valor = Double.Parse(listView1.SelectedItems[0].SubItems[3].Text);


                Maquina mE = maquinaV.Find(o => o.idMaquina == cod && o.Nome == nome && o.Modelo == Modelo && o.ValorMaquina == (decimal)valor);

                FormMaquina m = new FormMaquina(mE);
                m.ShowDialog();
                preencherListMaq();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar selecionar máquina" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                string valor = textBoxBuscar.Text;
                var maquinaSearch = from m in this.maquinaV
                                    where m.idMaquina.Equals(valor) || m.Nome.Contains(valor) || m.Modelo.Contains(valor) || m.ValorMaquina.Equals(valor) || m.AnoFabricacao.Equals(valor)
                                    select new { m.idMaquina, m.Nome, m.Modelo, m.ValorMaquina, m.AnoFabricacao };

                foreach (var m in maquinaSearch)
                {
                    ListViewItem item = new ListViewItem(
                        new String[]{
                    m.idMaquina+"",
                    m.Nome,
                    m.Modelo,
                    m.ValorMaquina+"",
                    m.AnoFabricacao+""
                    });
                    listView1.Items.Add(item);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar filtrar dados" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMaquina_Click(object sender, EventArgs e)
        {
            FormListaMaquina listaM = new FormListaMaquina();
            listaM.ShowDialog();
        }
    }
}
