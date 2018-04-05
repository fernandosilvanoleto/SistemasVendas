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
    public partial class FormTransferencia : Form
    {
        List<Maquina> maquinaV;
        public FormTransferencia()
        {
            InitializeComponent();
        }

        private void FormTransferencia_Load(object sender, EventArgs e)
        {
            preencherMaquina();
            ToolTip tool = new ToolTip();
            tool.AutoPopDelay = 5000;
            tool.InitialDelay = 100;
            tool.ReshowDelay = 500;
            buttonTransferir.Enabled = false;
            buttonRecuperar.Enabled = false;
            textBox1.Enabled = false;

            tool.ShowAlways = true;
            tool.SetToolTip(this.button1, "Voltar");
            tool.SetToolTip(this.buttonTransferir, "Transferir Máquina");
            tool.SetToolTip(this.buttonRecuperar, "Recuperar Máquina");
        }

        void preencherMaquina()
        {
            try
            {
                listView1.Items.Clear();
                maquinaV = MaquinaManager.All();
                for (int i = 0; i < maquinaV.Count; i++)
                {
                    if (!maquinaV[i].Status.Equals("Transferida"))
                    {
                        ListViewItem item = new ListViewItem(new string[]{
                    maquinaV[i].idMaquina+"",
                    maquinaV[i].Nome,
                    maquinaV[i].Marca.Nome,
                    maquinaV[i].Status                  
                    });
                        listView1.Items.Add(item);
                    }
                    else
                    {
                        ListViewItem item = new ListViewItem(new string[]{
                    maquinaV[i].idMaquina+"",
                    maquinaV[i].Nome,
                    maquinaV[i].Marca.Nome,
                    maquinaV[i].Status});
                        listView2.Items.Add(item);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro de listagem" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTransferir_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);             
                
                Maquina maquina = MaquinaManager.Maquina(cod);

                MaquinaManager.StatusMaquina(cod, "Transferida");
                ListViewItem item = new ListViewItem(new string[]{
                    maquina.idMaquina+"",
                    maquina.Nome,
                    maquina.Marca.Nome,
                    "Transferida"                    
                });
                listView2.Items.Add(item);
                listView1.SelectedItems[0].Remove();
                MessageBox.Show("Máquina transferida com sucesso!", "Transferência", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonTransferir.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao transferir máquina" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRecuperar_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = int.Parse(listView2.SelectedItems[0].SubItems[0].Text);
                Maquina maquina = MaquinaManager.Maquina(cod);
                MaquinaManager.StatusMaquina(cod, "Disponível");


                ListViewItem item = new ListViewItem(new string[]{
                    maquina.idMaquina+"",
                    maquina.Nome,
                    maquina.Marca.Nome,
                    "Disponível"                    
                });
                listView1.Items.Add(item);

                listView2.SelectedItems[0].Remove();
                MessageBox.Show("Máquina devolvida com sucesso!", "Devolução de Máquina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonRecuperar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro de inserção de vendas" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            buttonTransferir.Enabled = true;
        }

        private void listView2_MouseClick(object sender, MouseEventArgs e)
        {
            buttonRecuperar.Enabled = true;
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label8_Click(object sender, EventArgs e)
        { }
    }
}
