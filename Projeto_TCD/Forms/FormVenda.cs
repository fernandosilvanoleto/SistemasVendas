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
using Projeto_TCD.Managers;

namespace Projeto_TCD
{
    public partial class FormVenda : Form
    {
        int codigoVendedor, codigoMaquina, codigoCliente, codigoTransportadora, codigoGerente, pesoMaquinaVenda;
        double valorMaqVenda, valorFreteVenda, custoFinal = 0, freteTotalC, auxPrecoMaq, descontoVenda;
        Boolean liberarDesconto = false, cadastrar = true;
        string nomeMarca, nomeTransp;
        List<Vendedor> vendedorVenda;
        List<Maquina> maquinaVenda;
        List<Cliente> clienteVenda;
        List<Transportadora> transportadoraVenda;
        Vendas venda;
        
        public FormVenda()
        {
            InitializeComponent();

            vendedorVenda = VendedorManager.All();
            maquinaVenda = MaquinaManager.All();
            clienteVenda = ClienteManager.All();
            transportadoraVenda = TransportadoraManager.All();
            textBoxDesconto.Enabled = false;
            buttonAlterar.Enabled = false;
            buttonExcluir.Enabled = false;
            button1.Enabled = true;
            textBoxCustoTotal.Enabled = false;
        }
        public FormVenda(Boolean gerenteVendas) :this()
        {
            if (gerenteVendas)              //quando gerente realizar a venda
            {
                this.buttonDesconto.Visible = false;
                this.buttonDes.Enabled = false;
                textBoxDesconto.Enabled = true;
                liberarDesconto = true;
            }
        }
        public FormVenda(Vendas ven)            : this() //quando os dados vem de relatórios de venda
        {
            venda = ven;
            liberarDesconto = false;
            preencherCampos(ven);            
            buttonDesconto.Enabled = true;
            buttonDes.Enabled = false;
            textBoxDesconto.Enabled = false;
            comboBoxTransportadora.Enabled = true;
            
            buttonAlterar.Enabled = true;
            button1.Enabled = false;
            buttonExcluir.Enabled = true;
            cadastrar = false;
            buttonDetMaq.Enabled = false;
        }

        private void FormVenda_Load(object sender, EventArgs e)
        {
            preencherVendedor();
            preencherCliente();
            preencherMaquina();
            preencherTransp();            
            buttonDes.Enabled = false;
            buttonDesconto.Enabled = true;
            comboBoxTransportadora.Enabled = false;            

            ToolTip tool = new ToolTip();
            tool.AutoPopDelay = 5000;
            tool.InitialDelay = 100;
            tool.ReshowDelay = 500;
            tool.ShowAlways = true;
            tool.SetToolTip(this.button1, "Registrar Venda");
            tool.SetToolTip(this.buttonAlterar, "Alterar dados de Venda");
            tool.SetToolTip(this.buttonExcluir, "Excluir Venda");
            tool.SetToolTip(this.buttonCancelar, "Cancelar");
            tool.SetToolTip(this.buttonSair, "Sair");
            tool.SetToolTip(this.buttonDetMaq, "Detalhes da Máquina");
            tool.SetToolTip(this.buttonDesconto, "Deseja obter ter desconto, chama o cliente");
            tool.SetToolTip(this.buttonDes, "Confirmar");
        }       

        private void comboBoxVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxNomeVendedor.Text = "";
                if (comboBoxVendedor.SelectedIndex != -1)
                {
                    Vendedor vd = vendedorVenda[comboBoxVendedor.SelectedIndex];
                    codigoVendedor = vd.idVendedor;
                    textBoxNomeVendedor.Text = vd.Nome;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro na escolha de vendedor" + "," + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 

        private void comboBox1Maquina_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxPreco.Text = "";
                textBoxPreco.Enabled = false;
                textBoxMarca.Text = "";
                textBoxMarca.Enabled = false;
                textBoxCustoTotal.Text = "";
                valorMaqVenda = 0;                        // zerar o valor da maquina
                buttonDetMaq.Enabled = true;

                numericUpDownQuantidade.Value = (decimal)1;   //cada que vez que selecionar uma máquina, a quantidade ficará no 1

                if (comboBox1Maquina.SelectedIndex != -1)
                {
                    Maquina maqui = maquinaVenda[comboBox1Maquina.SelectedIndex];                  
                    textBoxPreco.Text = maqui.ValorMaquina + "";
                    textBoxMarca.Text = maqui.Marca.Nome;
                    codigoMaquina = maqui.idMaquina;                    //pego o código da máquina
                    pesoMaquinaVenda = maqui.PesoMaquina;               //pego a peso da máquina
                    valorMaqVenda = (double)maqui.ValorMaquina;         //pego o valor da máquina
                    auxPrecoMaq = valorMaqVenda;                        //o auxPrecoMaq tem como função, guardar o valor real da máquina, para que possa ser realizadas alterações em quantidades e calculo do frete. Pois que ele me retorna o valor original da máquina escolhida
                    
                    nomeMarca = maqui.Nome;
                    textBoxCustoTotal.Text = maqui.ValorMaquina + "";
                    numericUpDownQuantidade.Enabled = true;             //habilitar o botão quantidade e transportadora
                    comboBoxTransportadora.Enabled = true;

                    if (codigoTransportadora != 0)
                    {
                        calculoPesoFrete();                       
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro na escolha de máquina" + "," + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void calculoPesoFrete()
        {
            try
            {
                custoFinal = 0;                     //zero o custo final, para calcular novo
                freteTotalC = 0;                    //zero o frete final
                textBoxCustoTotal.Text = "";        //zero o campo de custo final no form

                double pesoM = pesoMaquinaVenda;   //pego o peso da máquina
                double valorF = valorFreteVenda;  // pega o valor do frete para calcular

                double auxFrete = (pesoM / 1000);  // pega o peso para calcular o frete
                freteTotalC = auxFrete * valorF;
                custoFinal = freteTotalC + valorMaqVenda;
                textBoxCustoTotal.Text = custoFinal + "";                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao realizar o cálculo do frete" + "," + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private void comboBoxTransportadora_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                textBoxFrete.Text = "";
                if (comboBoxTransportadora.SelectedIndex != -1)
                {
                    Transportadora transp = transportadoraVenda[comboBoxTransportadora.SelectedIndex];
                    codigoTransportadora = transp.idTransportadora;                 //código da transportadora                 
                    textBoxFrete.Text = transp.ValorFrete+"";
                    valorFreteVenda = (double)transp.ValorFrete;         // valor do frete
                    nomeTransp = transp.Nome;  //nome transportadora

                    calculoPesoFrete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro na escolha da transportadora" + " " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void numericUpDownQuantidade_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                valorMaqVenda = auxPrecoMaq;
                if (numericUpDownQuantidade.Value == 1)
                { valorMaqVenda = valorMaqVenda * 1; }
                else if (numericUpDownQuantidade.Value == 2)
                { valorMaqVenda = valorMaqVenda * 2; }
                else if (numericUpDownQuantidade.Value == 3)
                { valorMaqVenda = valorMaqVenda * 3; }
                else if (numericUpDownQuantidade.Value == 4)
                { valorMaqVenda = valorMaqVenda * 4; }
                else if (numericUpDownQuantidade.Value == 5)
                { valorMaqVenda = valorMaqVenda * 5; }
                else if (numericUpDownQuantidade.Value == 6)
                { valorMaqVenda = valorMaqVenda * 6; }
                else if (numericUpDownQuantidade.Value == 7)
                { valorMaqVenda = valorMaqVenda * 7; }              
                calculoPesoFrete();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro na quantidade de maquina" + " " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDetMaq_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1Maquina.SelectedIndex != -1 || codigoMaquina != 0)
                {
                    Maquina maqui = maquinaVenda[comboBox1Maquina.SelectedIndex];
                    string mensagem = string.Format("Você informou: \n"
                        + "Nome: {0}\n"
                        + "Marca: {1}\n"
                        + "Modelo: {2}\n"
                        + "Ano de Fabricação: {3}\n"
                        + "Combustível: {4}\n"
                        + "Valor cobrado: {5}\n"
                        + "Peso: {6}",
                        maqui.Nome,
                        maqui.Marca.Nome,
                        maqui.Modelo,
                        maqui.AnoFabricacao + "",                      
                        maqui.Combustivel,
                        maqui.ValorMaquina + "",
                        maqui.PesoMaquina + "");

                    MessageBox.Show(mensagem);
                }
                else
                {
                    MessageBox.Show("Selecione uma máquina!", "Escolhe uma máquina", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro nos detalhes em máquina" + " " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBoxNomeCliente.Text = "";
                int cod = int.Parse(listViewCliente.SelectedItems[0].SubItems[0].Text);
                Cliente cl = ClienteManager.LocalizarCliente(cod);
                textBoxNomeCliente.Text = cl.NomeCliente;
                codigoCliente = cl.idCliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar localizar cliente" + " " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }    

        private void button1_Click(object sender, EventArgs e)
        {
            try{
                if (codigoVendedor != 0)  //verifica se pelo um dos dois, foi preenchido
                {
                    if (codigoMaquina != 0 && codigoCliente != 0 && textBoxCidCompra.Text != "" && comboBoxEstCompra.Text != ""
                        && codigoTransportadora != 0 && textBoxCidadeEnt.Text != "" && comboBoxEstadoEn.Text != "" && textBoxEnderecoEnt.Text != "")
                    {                       

                        DateTime dataPC = dateTimePickerData.Value;
                        double freteTotalPC = freteTotalC;
                        string estComPC = comboBoxEstCompra.Text;
                        string cidCompPC = textBoxCidCompra.Text;
                        int quantPC = (int)numericUpDownQuantidade.Value;
                        string estDesPC = comboBoxEstadoEn.Text;
                        string cidDesPC = textBoxCidadeEnt.Text;

                        string enderecoEnt = textBoxEnderecoEnt.Text;
                        double descPC = 0;                      
                        
                        
                        if (liberarDesconto)   //quando o gerente participa da venda
                        {
                            descPC = descontoVenda;                            
                            codigoGerente = GerenteManager.LocalizarGerente(1);                                                     
                        }
                        
                            VendasManager.RealizarVendas(codigoCliente, codigoGerente, codigoVendedor, codigoMaquina, codigoTransportadora,
                                dataPC, freteTotalPC, custoFinal, estComPC, cidCompPC, quantPC, cidDesPC,
                                estDesPC, descPC, enderecoEnt, liberarDesconto);                        
                        MessageBox.Show("Cadastro de venda realizado com sucesso! \n Obrigado pela Compra", "Transação Aprovada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limparCampos();
                    }
                   else
                   {
                        MessageBox.Show("Preencher os campos obrigatórios", "Verificar Campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Escolha um funcionário para finalização da compra!", "Selecione um funcionário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                //tratamento de erro da camada superior
                MessageBox.Show("Ocorreu um erro de inserção de vendas" +" "+ ex,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            }
     }

        public void limparCampos()
        {
            try
            {
                comboBoxVendedor.SelectedIndex = -1;
                textBoxNomeVendedor.Text = "";
                dateTimePickerData.Value = DateTime.Now;
                comboBox1Maquina.SelectedIndex = -1;
                numericUpDownQuantidade.Value = (decimal)1;
                textBoxPreco.Text = "";
                textBoxMarca.Text = "";
                comboBoxTransportadora.SelectedIndex = -1;
                textBoxFrete.Text = "";

                textBoxCidCompra.Text = "";
                comboBoxEstCompra.SelectedIndex = -1;
                textBoxCustoTotal.Text = "";
                textBoxCidadeEnt.Text = "";
                textBoxNomeCliente.Text = "";
                textBoxCidadeEnt.Text = "";
                comboBoxEstadoEn.SelectedIndex = -1;

                textBoxEnderecoEnt.Text = "";
                textBoxDesconto.Text = "";

                valorMaqVenda = 0;
                valorFreteVenda = 0;
                custoFinal = 0;
                textBoxCustoTotal.Text = "";
                codigoGerente = 0;
                codigoVendedor = 0;
                liberarDesconto = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro de limpeza de dados" + " " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (codigoVendedor != 0 || codigoGerente != 0)  //verifica se pelo um dos dois, foi preenchido
                {
                    if (codigoMaquina != 0 && codigoCliente != 0 && textBoxCidCompra.Text != "" && comboBoxEstCompra.Text != ""
                        && codigoTransportadora != 0 && textBoxCidadeEnt.Text != "" && comboBoxEstadoEn.Text != "" && textBoxEnderecoEnt.Text != "")
                    {
                        DateTime dataPC = dateTimePickerData.Value;                        
                        double freteTotalPC = freteTotalC;                        
                        string estComPC = comboBoxEstCompra.Text;
                        string cidCompPC = textBoxCidCompra.Text;
                        int quantPC = (int)numericUpDownQuantidade.Value;
                        string estDesPC = comboBoxEstadoEn.Text;
                        string cidDesPC = textBoxCidadeEnt.Text;                        
                        string enderecoEnt = textBoxEnderecoEnt.Text;                 
                        double descPC = 0;                        
                        if (liberarDesconto)
                        {
                            descPC = descontoVenda;
                            codigoGerente = GerenteManager.LocalizarGerente(1);
                        }
                        int codVenda = venda.idVenda;                       

                        VendasManager.Alterar(codVenda, codigoCliente, codigoGerente, codigoVendedor, codigoMaquina, codigoTransportadora,
                           dataPC, freteTotalPC, custoFinal, estComPC, cidCompPC, quantPC, cidDesPC,
                           estDesPC, descPC, enderecoEnt, liberarDesconto);
                        MessageBox.Show("Venda alterado com sucesso", "Campo de Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limparCampos();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Preencher os campos obrigatórios", "Verificar Campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Escolha um funcionário", "Falta selecionar Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro de alteração de máquina" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Deseja excluir venda", "Exluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    int codVenda = venda.idVenda;
                    VendasManager.RemoverVenda(codVenda);
                    MessageBox.Show("Venda excluída com sucesso!", "Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Exclusão cancelada", "Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro de exclusão de venda" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Atenção! Deseja cancelar ação", "Cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    limparCampos();                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro de cancelamento" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            try
            {                
                limparCampos();
                this.Close();           
            }
                catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao sair de área de vendas" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void preencherVendedor()
        {
            try
            {
                comboBoxVendedor.Items.Clear();

                List<Vendedor> vendedor = VendedorManager.All();

                for (int i = 0; i < vendedor.Count; i++)
                {
                    comboBoxVendedor.Items.Add(vendedor[i].Nome);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro de listagem de vendedor" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }      

        public void preencherCliente()
        {
            try
            {
                listViewCliente.Items.Clear();
                List<Cliente> clienteV = ClienteManager.All();
                for (int i = 0; i < clienteV.Count; i++)
                {
                    ListViewItem item = new ListViewItem(new string[]{
                    clienteV[i].idCliente+"",
                    clienteV[i].NomeCliente,
                    clienteV[i].Cidade
                });
                    listViewCliente.Items.Add(item);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro de listagem de cliente" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void preencherMaquina()
        {
            try
            {
                comboBox1Maquina.Items.Clear();
                List<Maquina> maquina = MaquinaManager.All();
                for (int i = 0; i < maquina.Count; i++)
                {
                    if (!maquina[i].Status.Equals("Transferida"))
                    {
                        comboBox1Maquina.Items.Add(maquina[i].Nome);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro de preenchimento de máquina" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void preencherTransp()
        {
            try
            {
                comboBoxTransportadora.Items.Clear();
                List<Transportadora> transportadora = TransportadoraManager.All();
                for (int i = 0; i < transportadora.Count; i++)
                {
                    comboBoxTransportadora.Items.Add(transportadora[i].Nome);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro de preenchimento de máquina" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void preencherCampos(Vendas v)
        {
            try
            {
                comboBoxVendedor.Text = v.Vendedor.Nome;
                textBoxNomeVendedor.Text = v.Vendedor.Nome; //dados do vendedor
                codigoVendedor = v.Vendedor.idVendedor;

                comboBox1Maquina.Text = v.Maquina.Nome;
                numericUpDownQuantidade.Value = (decimal)v.QtProdutos;
                textBoxPreco.Text = v.Maquina.ValorMaquina + "";            //dados de máquina
                textBoxMarca.Text = v.Maquina.Marca.Nome;
                codigoMaquina = v.idMaquina;
                valorMaqVenda = (double)v.Maquina.ValorMaquina;
                auxPrecoMaq = valorMaqVenda;   //auxilia no preco na quantidade e no calculo frete
                pesoMaquinaVenda = v.Maquina.PesoMaquina;


                textBoxNomeCliente.Text = v.Cliente.NomeCliente;
                codigoCliente = v.Cliente.idCliente;                //dados de cliente
                textBoxCidadeEnt.Text = v.CidadeDestino;
                comboBoxEstadoEn.Text = v.EstadoDestino;
                textBoxEnderecoEnt.Text = v.EnderecoEntrega;


                comboBoxTransportadora.Text = v.Transportadora.Nome;
                textBoxFrete.Text = v.Transportadora.ValorFrete + "";         //dados de transportadora

                codigoTransportadora = v.Transportadora.idTransportadora;
                valorFreteVenda = (double)v.Transportadora.ValorFrete;


                textBoxCidCompra.Text = v.CidadeCompra;
                comboBoxEstCompra.Text = v.EstadoCompra;


                textBoxCustoTotal.Text = v.CustoTotal + "";
                custoFinal = (double)v.CustoTotal;
                textBoxDesconto.Text = v.DescontoVenda + "";
                descontoVenda = (double)v.DescontoVenda;
                if (descontoVenda != 0)
                {
                    codigoGerente = v.Gerente.idGerente;
                    liberarDesconto = true;
                }
                dateTimePickerData.Value = v.DataVenda;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro de preenchimento de dados" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        
        private void buttonDesconto_Click(object sender, EventArgs e)
        {
            try
            {
                descontoVenda = 0;
                textBoxDesconto.Text = "";

                FormContGerente g = new FormContGerente();
                g.ShowDialog();
                liberarDesconto = true;                 //busca o gerente, quando for cadastrar venda e se o liberarDesconto for true
                textBoxDesconto.Enabled = true;
                buttonDes.Enabled = false;
                if (cadastrar)
                {
                    button1.Enabled = false;
                }
                else
                {
                    buttonAlterar.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao solicitar desconto" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }         

        private void buttonDes_Click(object sender, EventArgs e)
        {
            try
            {
                descontoVenda = double.Parse(textBoxDesconto.Text);
                custoFinal = custoFinal - descontoVenda;
                MessageBox.Show("Desconto de: " + descontoVenda + "\n" + "\nCusto Final:" + "R$" + custoFinal, "Desconto de Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxDesconto.Enabled = false;
                buttonDesconto.Enabled = true;
                buttonDes.Enabled = false;
                if (cadastrar)
                {
                    button1.Enabled = true;
                }
                else
                {
                    buttonAlterar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao confirmar desconto" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxDesconto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double custo = custoFinal;
                if (textBoxDesconto.Text != "")
                {
                    double des = double.Parse(textBoxDesconto.Text);
                    custo = custo - des;
                    textBoxCustoTotal.Text = custo + "";
                    buttonDes.Enabled = true;
                }
                else
                {
                    textBoxCustoTotal.Text = custo + "";
                    buttonDes.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao digitar valor" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonNovoCliente_Click(object sender, EventArgs e)
        {
            try
            {
                FormCliente cliente = new FormCliente();
                cliente.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao solicitar novo cliente" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                listViewCliente.Items.Clear();
                string valor = textBoxBuscarCliente.Text;
                var clienteSearch = from c in this.clienteVenda
                                    where c.idCliente.Equals(valor) || c.NomeCliente.Contains(valor) || c.Cidade.Contains(valor)
                                    select new { c.idCliente, c.NomeCliente, c.Cidade };

                foreach (var c in clienteSearch)
                {
                    ListViewItem item = new ListViewItem(
                        new String[]{
                        c.idCliente+"",
                        c.NomeCliente,
                        c.Cidade
                   });
                    listViewCliente.Items.Add(item);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao filtar cliente" + ", " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label6_Click(object sender, EventArgs e){}
        private void tabPage1_Click(object sender, EventArgs e){}
        private void numericUpDownDesconto_ValueChanged(object sender, EventArgs e) {}
        private void comboBoxEstadoEn_SelectedIndexChanged(object sender, EventArgs e){ }
        private void label17_Click(object sender, EventArgs e){}
        private void groupBox3_Enter(object sender, EventArgs e){ }
        //private void textBox1_TextChanged_2(object sender, EventArgs e){}
        private void textBox2_TextChanged(object sender, EventArgs e){ }
        private void label18_Click(object sender, EventArgs e){ }
        private void textBox1_TextChanged_1(object sender, EventArgs e){ }
        private void textBox1_TextChanged(object sender, EventArgs e) {}
}

}

