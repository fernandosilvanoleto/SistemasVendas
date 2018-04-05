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

namespace Projeto_TCD.Forms
{
    public partial class FormCliente : Form
    {
        Cliente clienteAL;
        Boolean alterar = false;

        int codigoCliente;

        string nomeAL, emailAL, telAL;
        public FormCliente()
        {
            InitializeComponent();
            button();
        }        

        public FormCliente(Cliente clA) :this()
        {
            alterar = true;
            button();
            buttonCadastrar.Enabled = false;
            clienteAL = clA;            
            preencherCampos(clienteAL);
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();
            tool.AutoPopDelay = 5000;
            tool.InitialDelay = 100;
            tool.ReshowDelay = 500;

            tool.ShowAlways = true;
            tool.SetToolTip(this.buttonCadastrar, "Cadastrar Cliente");
            tool.SetToolTip(this.buttonCancelar, "Cancelar");
            tool.SetToolTip(this.buttonExcluir, "Excluir Cliente");
            tool.SetToolTip(this.buttonSalvar, "Salvar Alteração");
            tool.SetToolTip(this.button1, "Sair da página de cliente");
        }
       
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {            
            try
            {
                string nome = textBoxNome.Text;
                string tipo = comboBoxTipo.Text;
                string cpf = textBoxCPF.Text;
                string rg = textBoxRG.Text;
                string email = textBoxEmail.Text;
                string data = maskedTextBoxDTNasc.Text;
                string sexo = comboBoxSexo.Text;
                string rua = textBoxRua.Text;
                string num = textBoxNumero.Text;
                string bairro = textBoxBairro.Text;
                string comp = textBoxComplemento.Text;
                string cidade = textBoxCidade.Text;
                string est = comboBoxEstado.Text;
                string tel = maskedTextBoxTelefone.Text;

                if(nome != "" && tipo != "" && cpf != "" && rg != "" && email != "" && data != "" && sexo != "" && rua != "" && bairro != "" && num != "" && cidade != "" && est != "" && tel != "")
                {             

                ClienteManager.Adicionar(nome, tipo, cpf, rg, data, sexo, email, rua, bairro, num, comp, cidade, est, tel);
                MessageBox.Show("Cliente cadastrado com sucesso!", "Cadastro de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
                }
                else
                {
                    MessageBox.Show("Preencher os campos obrigatórios, novamente","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro de cadastramento de cliente" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("Mensagem de Erro", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            codigoCliente = clienteAL.idCliente;            
            try
            {               
                DialogResult r = MessageBox.Show("Tem certeza que deseja excluir!", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == DialogResult.Yes)
                {
                    
                    
                    ClienteManager.Excluir(codigoCliente);
                    MessageBox.Show("Cliente Excluído com sucesso", "Excluído",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    limparCampos();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cliente não excluído!", "Cancelamento",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro de exclusão" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Tem certeza que deseja cancelar!", "Cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == DialogResult.Yes)
                {
                    MessageBox.Show("Cancelado com sucesso!","Cancelado",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    limparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro de cancelamento" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = textBoxNome.Text;
                string tipo = comboBoxTipo.Text;
                string cpf = textBoxCPF.Text;
                string rg = textBoxRG.Text;
                string email = textBoxEmail.Text;
                string data = maskedTextBoxDTNasc.Text;
                string sexo = comboBoxSexo.Text;
                string rua = textBoxRua.Text;
                string num = textBoxNumero.Text;
                string bairro = textBoxBairro.Text;
                string comp = textBoxComplemento.Text;
                string cidade = textBoxCidade.Text;
                string est = comboBoxEstado.Text;
                string tel = maskedTextBoxTelefone.Text;


                if (nome != "" && tipo != "" && cpf != "" && rg != "" && email != "" && data != "" && sexo != "" && rua != "" && bairro != "" && num != "" && cidade != "" && est != "" && tel != "")
                {                    
                        ClienteManager.Alterar(clienteAL.idCliente, nome, tipo, cpf, rg, data, sexo, email, rua, bairro, num, comp, cidade, est, tel);
                        MessageBox.Show("Dados Alterados com sucesso!","Alteração",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        limparCampos();    
                    this.Close();                    
                }
                else
                {
                    MessageBox.Show("Preencher os campos obrigatórios, novamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro de alteração de cliente" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

       public void preencherCampos(Cliente c)
        {
            try
            {
                textBoxNome.Text = c.NomeCliente;
                comboBoxTipo.Text = c.TipoCliente;
                textBoxCPF.Text = c.CPF;
                textBoxRG.Text = c.RG;
                textBoxEmail.Text = c.Email;
                maskedTextBoxDTNasc.Text = c.DataNascimento;
                comboBoxSexo.Text = c.Sexo;
                textBoxRua.Text = c.Rua;
                textBoxNumero.Text = c.Numero;
                textBoxBairro.Text = c.Bairro;
                textBoxComplemento.Text = c.Complemento;
                textBoxCidade.Text = c.Cidade;
                comboBoxEstado.Text = c.Estado;
                maskedTextBoxTelefone.Text = c.Telefone;
                nomeAL = c.NomeCliente;
                emailAL = c.Email;
                telAL = c.Telefone;
            }
           catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro de preenchimento de cliente" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void button()
        {
            if (!alterar)
            {
                buttonCadastrar.Enabled = true;
                buttonSalvar.Enabled = false;
                buttonExcluir.Enabled = false;
                buttonCancelar.Enabled = true;
                
            }
            else
            {
                buttonCadastrar.Enabled = false;
                buttonSalvar.Enabled = true;
                buttonExcluir.Enabled = true;                
                buttonCancelar.Enabled = true;
            }
        }

        private void limparCampos()
        {
            try
            {
                textBoxNome.Text = "";
                comboBoxTipo.SelectedIndex = -1;
                textBoxCPF.Text = "";
                textBoxRG.Text = "";
                textBoxEmail.Text = "";
                maskedTextBoxDTNasc.Text = "";
                comboBoxSexo.SelectedIndex = -1;
                textBoxRua.Text = "";
                textBoxNumero.Text = "";
                textBoxBairro.Text = "";
                textBoxComplemento.Text = "";
                textBoxCidade.Text = "";
                comboBoxEstado.SelectedIndex = -1;
                maskedTextBoxTelefone.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao limpar dados de cliente" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }  

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {               
                    limparCampos();
                    this.Close();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao sair" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {}

        private void label15_Click(object sender, EventArgs e)
        {}        
      }
}

