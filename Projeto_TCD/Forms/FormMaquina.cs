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
    public partial class FormMaquina : Form
    {
        List<Marca> marca;
        Maquina maquina;
        int codigoMarca, codMaquinaAL;
        Boolean alterar = false;

       string nomeAL,motorAL;
        public FormMaquina()
        {
            InitializeComponent();
            botton();
            radioButtonTrator.Checked = true;
        }
        public FormMaquina(Maquina mq) :this()
        {
            maquina = mq;
            preencherDados(mq);
            alterar = true;
            botton();
        }

        void botton()
        {
            if(!alterar)
            {
                button1.Enabled = true;
                buttonSalvar.Enabled = false;
                button2.Enabled = false;
                buttonCancelar.Enabled = true;
                buttonSair.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                buttonSalvar.Enabled = true;
                button2.Enabled = true;
                buttonCancelar.Enabled = true;
                buttonSair.Enabled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (codigoMarca != 0 &&  textBoxNomeMaquina.Text != "" && textBoxMotor.Text != ""
                    && textBoxPotencia.Text != "" && comboBoxCombustivel.Text != "" && comboBox1.Text != "" && textBoxValor.Text != "")
                {
                    string nome = textBoxNomeMaquina.Text;
                    string modelo;
                    if (radioButtonTrator.Checked)
                    { modelo = "Trator"; }
                    else { modelo = "Colheitadeira"; }
                    int ano = (int)numericUpDownAnoFab.Value;
                    string motor = textBoxMotor.Text;
                    string potencia = textBoxPotencia.Text;
                    string combustivel = comboBoxCombustivel.Text;
                    int peso = (int)numericUpDownPeso.Value;
                    string cor = comboBox1.Text;
                    double valor = Double.Parse(textBoxValor.Text);
                    
                    MaquinaManager.Adicionar(codigoMarca, nome, modelo, ano, motor,
                        potencia, combustivel, peso, cor,valor);
                    MessageBox.Show("Máquina cadastrada com sucesso!", "Cadastro", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    limparDados();
                }
                else
                {
                    MessageBox.Show("Verificar os campos preenchidos corretamente!","Verificar os campos",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {                
                MessageBox.Show("Ocorreu um erro de cadastramento de máquina" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxValor.BackColor = Color.Red;
                label7.Text = "Somente número nesse campo";
                textBoxValor.Text = "";
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (codigoMarca != 0 && textBoxMotor.Text != "" && textBoxPotencia.Text != "" && 
                    comboBoxCombustivel.Text != "" && comboBox1.Text != "" && textBoxValor.Text != "" && comboBox1.Text != "")
                {
                    string nome = textBoxNomeMaquina.Text;
                    string modelo;
                    if (radioButtonTrator.Checked)
                    { modelo = "Trator"; }
                    else { modelo = "Colheitadeira"; }
                    int ano = (int)numericUpDownAnoFab.Value;
                    string motor = textBoxMotor.Text;
                    string potencia = textBoxPotencia.Text;
                    string combustivel = comboBoxCombustivel.Text;
                    int peso = (int)numericUpDownPeso.Value;
                    string cor = comboBox1.Text;
                    double valor = Double.Parse(textBoxValor.Text);


                    MaquinaManager.Alterar(maquina.idMaquina, codigoMarca, nome, modelo, ano, motor, potencia, combustivel, peso, cor, valor);
                    MessageBox.Show("Dados Alterados com sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limparDados();
                        this.Close();
                }
                else
                {
                        MessageBox.Show("Verificar os campos não preenchidos!", "Verificar os campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro de alteração de máquina" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxValor.BackColor = Color.Red;
                label7.Text = "Somente número nesse campo";
                textBoxValor.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e) //botao excluir
        {
            try
            {
                DialogResult r = MessageBox.Show("Deseja excluir Máquina!", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (r == DialogResult.Yes)
                {                   
                    int codMaquina = maquina.idMaquina;          
                    MaquinaManager.Excluir(codMaquina);
                    MessageBox.Show("Excluído com sucesso!", "Exclusão", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    limparDados();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Exclusão Cancelada!", "Cancelado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro de exclusão de máquina" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Deseja cancela o processamento!", "Cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == DialogResult.Yes)
                {
                    limparDados();
                    MessageBox.Show("Cancelado com sucesso!","Cancelamento",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não cancelado!","Cancelamento",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de cancelamento" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FormMaquina_Load(object sender, EventArgs e)
        {
            preencherMarca();

            ToolTip tool = new ToolTip();
            tool.AutoPopDelay = 5000;
            tool.InitialDelay = 100;
            tool.ReshowDelay = 500;

            tool.ShowAlways = true;
            tool.SetToolTip(this.button1, "Cadastrar Máquina");
            tool.SetToolTip(this.buttonSalvar, "Alterar Máquina");
            tool.SetToolTip(this.button2, "Excluir Máquina");
            tool.SetToolTip(this.buttonCancelar, "Cancelar");
            tool.SetToolTip(this.buttonSair, "Sair");
        }

        private void preencherMarca()
        {
            try
            {
                comboBoxMarca.Items.Clear();
                marca = MarcaManager.AllMarca();
                for (int i = 0; i < marca.Count; i++)
                {
                    comboBoxMarca.Items.Add(marca[i].Nome);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro de lista de marca" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxMarca.SelectedIndex != -1)
                {
                    textBoxNomeMarca.Text = "";
                    Marca m = marca[comboBoxMarca.SelectedIndex];
                    textBoxNomeMarca.Text = m.Nome;
                    codigoMarca = m.idMarca;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro de ao inserir marca" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        
        void limparDados()
        {
            try
            {
                comboBoxMarca.SelectedIndex = -1;
                textBoxNomeMarca.Text = "";
                textBoxNomeMaquina.Text = "";
                numericUpDownAnoFab.Value = (decimal)2000;
                radioButtonTrator.Checked = true;
                radioButtonColheitadeira.Checked = false;
                textBoxMotor.Text = "";
                textBoxPotencia.Text = "";
                comboBoxCombustivel.SelectedIndex = -1;
                comboBox1.SelectedIndex = -1;
                textBoxValor.Text = "";
                numericUpDownPeso.Value = (decimal)1000;
                codigoMarca = 0;
                comboBoxMarca.SelectedIndex = -1;
                textBoxValor.BackColor = Color.White;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao limpar dados" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void preencherDados(Maquina m)
        {
            try
            {
                comboBoxMarca.Text = m.Marca.Nome;
                textBoxNomeMarca.Text = m.Marca.Nome;
                textBoxNomeMaquina.Text = m.Nome;
                numericUpDownAnoFab.Value = m.AnoFabricacao;
                if (m.Modelo.Equals("Trator"))
                {
                    radioButtonTrator.Checked = true;
                }
                else
                {
                    radioButtonColheitadeira.Checked = true;
                }
                textBoxMotor.Text = m.Motor;
                textBoxPotencia.Text = m.Potencia;
                comboBoxCombustivel.Text = m.Combustivel;
                comboBox1.Text = m.Cor;
                numericUpDownPeso.Value = m.PesoMaquina;
                textBoxValor.Text = m.ValorMaquina + "";

                codMaquinaAL = m.idMaquina;
                codigoMarca = m.Marca.idMarca;
                nomeAL = m.Nome;
                motorAL = m.Motor;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro de preenchimento" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }    
        

       
        private void buttonSair_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                limparDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao sair" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxTamanho_SelectedIndexChanged(object sender, EventArgs e)
        {}

        private void comboBoxCombustivel_SelectedIndexChanged(object sender, EventArgs e)
        {}
        private void radioButtonGrande_CheckedChanged(object sender, EventArgs e)
        { }
        private void radiobuttonMedio_CheckedChanged(object sender, EventArgs e)
        { }
    }
}
