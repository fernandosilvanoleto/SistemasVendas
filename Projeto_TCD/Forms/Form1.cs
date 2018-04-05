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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();
            tool.AutoPopDelay = 5000;
            tool.InitialDelay = 100;
            tool.ReshowDelay = 500;
            textBox1.Enabled = false;

            tool.ShowAlways = true;
            tool.SetToolTip(this.buttonEntrar, "Entrar");
            tool.SetToolTip(this.buttonCancelar, "Cancelar e sair");
            tool.SetToolTip(this.maskedTextBox1, "Login");
            tool.SetToolTip(this.maskedTextBox2, "Senha");
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (maskedTextBox1.Text == String.Empty || maskedTextBox2.Text == String.Empty)
                {
                    MessageBox.Show("Um dos campos obrigatório foi deixado em\nbranco ou está em um formato inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    int login = 0;
                    int senha = 0;
                    login = int.Parse(maskedTextBox1.Text);
                    senha = int.Parse(maskedTextBox2.Text);
                    if (login == 4040 || login == 1010)
                    {
                        if (login == 4040 && senha == 4040)
                        {
                            //this.Visible = false;
                            FormTelaVendedor vend = new FormTelaVendedor();
                            vend.ShowDialog();
                            limpar();
                        }
                        else if (login == 1010 && senha == 1010)
                        {
                            //this.Visible = false;
                            FormTelaGerente gerente = new FormTelaGerente();
                            gerente.ShowDialog();
                            limpar();

                        }
                        else
                        {
                            MessageBox.Show("Senha Incorreta. \n Por favor, verificar senha", "Senha Incorreta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            maskedTextBox2.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login ou senha incorretos \n Por favor, verifique novamente", "Login incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        limpar();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu ao tentar fazer login" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                limpar();
                MessageBox.Show("Cancelado!", "Cancelamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu ao tentar sair" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       

        void limpar()
        {
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {}
        private void pictureBox2_Click(object sender, EventArgs e)
        {}
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {}
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {}
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {}
        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Senha do Sistema  \n  Gerente: \n Login: 1010 \n Senha: 1010 \n Vendedor: \n Login: 4040 \n Senha: 4040");
        }
    }
}
