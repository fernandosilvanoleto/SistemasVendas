namespace Projeto_TCD
{
    partial class FormVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDes = new System.Windows.Forms.Button();
            this.textBoxDesconto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxCustoTotal = new System.Windows.Forms.TextBox();
            this.buttonDesconto = new System.Windows.Forms.Button();
            this.comboBoxEstCompra = new System.Windows.Forms.ComboBox();
            this.textBoxCidCompra = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LABEL9 = new System.Windows.Forms.Label();
            this.textBoxFrete = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxTransportadora = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDetMaq = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.LABE = new System.Windows.Forms.Label();
            this.numericUpDownQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1Maquina = new System.Windows.Forms.ComboBox();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNomeVendedor = new System.Windows.Forms.TextBox();
            this.comboBoxVendedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxBuscarCliente = new System.Windows.Forms.TextBox();
            this.buttonNovoCliente = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxEstadoEn = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxCidadeEnt = new System.Windows.Forms.TextBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.textBoxEnderecoEnt = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.listViewCliente = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label19 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantidade)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(465, 459);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dateTimePickerData);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxNomeVendedor);
            this.tabPage1.Controls.Add(this.comboBoxVendedor);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(457, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados de Venda";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDes);
            this.groupBox2.Controls.Add(this.textBoxDesconto);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBoxCustoTotal);
            this.groupBox2.Controls.Add(this.buttonDesconto);
            this.groupBox2.Controls.Add(this.comboBoxEstCompra);
            this.groupBox2.Controls.Add(this.textBoxCidCompra);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.LABEL9);
            this.groupBox2.Controls.Add(this.textBoxFrete);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBoxTransportadora);
            this.groupBox2.Location = new System.Drawing.Point(9, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 207);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transportadora";
            // 
            // buttonDes
            // 
            this.buttonDes.FlatAppearance.BorderSize = 0;
            this.buttonDes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDes.Image = global::Projeto_TCD.Properties.Resources.Desconto1;
            this.buttonDes.Location = new System.Drawing.Point(82, 142);
            this.buttonDes.Name = "buttonDes";
            this.buttonDes.Size = new System.Drawing.Size(71, 44);
            this.buttonDes.TabIndex = 21;
            this.buttonDes.UseVisualStyleBackColor = true;
            this.buttonDes.Click += new System.EventHandler(this.buttonDes_Click);
            // 
            // textBoxDesconto
            // 
            this.textBoxDesconto.Location = new System.Drawing.Point(179, 160);
            this.textBoxDesconto.Name = "textBoxDesconto";
            this.textBoxDesconto.Size = new System.Drawing.Size(85, 20);
            this.textBoxDesconto.TabIndex = 20;
            this.textBoxDesconto.TextChanged += new System.EventHandler(this.textBoxDesconto_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(287, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "R$";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(178, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 26);
            this.label13.TabIndex = 16;
            this.label13.Text = "Digite o valor\r\ndo Desconto";
            // 
            // textBoxCustoTotal
            // 
            this.textBoxCustoTotal.Location = new System.Drawing.Point(316, 139);
            this.textBoxCustoTotal.Name = "textBoxCustoTotal";
            this.textBoxCustoTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustoTotal.TabIndex = 15;
            this.textBoxCustoTotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // buttonDesconto
            // 
            this.buttonDesconto.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.buttonDesconto.FlatAppearance.BorderSize = 0;
            this.buttonDesconto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDesconto.Image = global::Projeto_TCD.Properties.Resources.Desconto;
            this.buttonDesconto.Location = new System.Drawing.Point(5, 105);
            this.buttonDesconto.Name = "buttonDesconto";
            this.buttonDesconto.Size = new System.Drawing.Size(71, 44);
            this.buttonDesconto.TabIndex = 13;
            this.buttonDesconto.UseVisualStyleBackColor = true;
            this.buttonDesconto.Click += new System.EventHandler(this.buttonDesconto_Click);
            // 
            // comboBoxEstCompra
            // 
            this.comboBoxEstCompra.FormattingEnabled = true;
            this.comboBoxEstCompra.Items.AddRange(new object[] {
            "Acre",
            "Amazonas\t",
            "Ceará",
            "Goiás",
            "Mato Grosso do Sul",
            "Pará",
            "Pernambuco",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Roraima",
            "São Paulo ",
            "Tocantins"});
            this.comboBoxEstCompra.Location = new System.Drawing.Point(290, 78);
            this.comboBoxEstCompra.Name = "comboBoxEstCompra";
            this.comboBoxEstCompra.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEstCompra.TabIndex = 12;
            // 
            // textBoxCidCompra
            // 
            this.textBoxCidCompra.Location = new System.Drawing.Point(6, 79);
            this.textBoxCidCompra.Name = "textBoxCidCompra";
            this.textBoxCidCompra.Size = new System.Drawing.Size(273, 20);
            this.textBoxCidCompra.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(294, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Estado da Compra*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Cidade de Compra*";
            // 
            // LABEL9
            // 
            this.LABEL9.AutoSize = true;
            this.LABEL9.Location = new System.Drawing.Point(7, 79);
            this.LABEL9.Name = "LABEL9";
            this.LABEL9.Size = new System.Drawing.Size(0, 13);
            this.LABEL9.TabIndex = 7;
            // 
            // textBoxFrete
            // 
            this.textBoxFrete.Location = new System.Drawing.Point(179, 33);
            this.textBoxFrete.Name = "textBoxFrete";
            this.textBoxFrete.Size = new System.Drawing.Size(100, 20);
            this.textBoxFrete.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Valor do Frete";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Selecione*";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboBoxTransportadora
            // 
            this.comboBoxTransportadora.FormattingEnabled = true;
            this.comboBoxTransportadora.Location = new System.Drawing.Point(5, 32);
            this.comboBoxTransportadora.Name = "comboBoxTransportadora";
            this.comboBoxTransportadora.Size = new System.Drawing.Size(163, 21);
            this.comboBoxTransportadora.TabIndex = 0;
            this.comboBoxTransportadora.SelectedIndexChanged += new System.EventHandler(this.comboBoxTransportadora_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDetMaq);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxMarca);
            this.groupBox1.Controls.Add(this.textBoxPreco);
            this.groupBox1.Controls.Add(this.LABE);
            this.groupBox1.Controls.Add(this.numericUpDownQuantidade);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1Maquina);
            this.groupBox1.Location = new System.Drawing.Point(8, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 135);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Máquina";
            // 
            // buttonDetMaq
            // 
            this.buttonDetMaq.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.buttonDetMaq.FlatAppearance.BorderSize = 0;
            this.buttonDetMaq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDetMaq.Image = global::Projeto_TCD.Properties.Resources.Spotify_icon;
            this.buttonDetMaq.Location = new System.Drawing.Point(203, 74);
            this.buttonDetMaq.Name = "buttonDetMaq";
            this.buttonDetMaq.Size = new System.Drawing.Size(77, 45);
            this.buttonDetMaq.TabIndex = 8;
            this.buttonDetMaq.UseVisualStyleBackColor = true;
            this.buttonDetMaq.Click += new System.EventHandler(this.buttonDetMaq_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Marca";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(6, 77);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(174, 20);
            this.textBoxMarca.TabIndex = 6;
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(268, 38);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(100, 20);
            this.textBoxPreco.TabIndex = 5;
            // 
            // LABE
            // 
            this.LABE.AutoSize = true;
            this.LABE.Location = new System.Drawing.Point(277, 16);
            this.LABE.Name = "LABE";
            this.LABE.Size = new System.Drawing.Size(98, 13);
            this.LABE.TabIndex = 4;
            this.LABE.Text = "Preço da Máquina*";
            // 
            // numericUpDownQuantidade
            // 
            this.numericUpDownQuantidade.Location = new System.Drawing.Point(193, 38);
            this.numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            this.numericUpDownQuantidade.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownQuantidade.TabIndex = 3;
            this.numericUpDownQuantidade.ValueChanged += new System.EventHandler(this.numericUpDownQuantidade_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantidade*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Selecione*";
            // 
            // comboBox1Maquina
            // 
            this.comboBox1Maquina.FormattingEnabled = true;
            this.comboBox1Maquina.Location = new System.Drawing.Point(6, 37);
            this.comboBox1Maquina.Name = "comboBox1Maquina";
            this.comboBox1Maquina.Size = new System.Drawing.Size(174, 21);
            this.comboBox1Maquina.TabIndex = 0;
            this.comboBox1Maquina.SelectedIndexChanged += new System.EventHandler(this.comboBox1Maquina_SelectedIndexChanged);
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Location = new System.Drawing.Point(211, 20);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerData.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data*";
            // 
            // textBoxNomeVendedor
            // 
            this.textBoxNomeVendedor.Location = new System.Drawing.Point(9, 46);
            this.textBoxNomeVendedor.Name = "textBoxNomeVendedor";
            this.textBoxNomeVendedor.Size = new System.Drawing.Size(179, 20);
            this.textBoxNomeVendedor.TabIndex = 2;
            this.textBoxNomeVendedor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBoxVendedor
            // 
            this.comboBoxVendedor.FormattingEnabled = true;
            this.comboBoxVendedor.Location = new System.Drawing.Point(9, 19);
            this.comboBoxVendedor.Name = "comboBoxVendedor";
            this.comboBoxVendedor.Size = new System.Drawing.Size(179, 21);
            this.comboBoxVendedor.TabIndex = 1;
            this.comboBoxVendedor.SelectedIndexChanged += new System.EventHandler(this.comboBoxVendedor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funcionário*";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(500, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(561, 450);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.textBoxBuscarCliente);
            this.tabPage2.Controls.Add(this.buttonNovoCliente);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.textBoxNomeCliente);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.listViewCliente);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(553, 424);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Dados do Comprador";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Selecione*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Buscar";
            // 
            // textBoxBuscarCliente
            // 
            this.textBoxBuscarCliente.Location = new System.Drawing.Point(62, 3);
            this.textBoxBuscarCliente.Name = "textBoxBuscarCliente";
            this.textBoxBuscarCliente.Size = new System.Drawing.Size(332, 20);
            this.textBoxBuscarCliente.TabIndex = 6;
            this.textBoxBuscarCliente.TextChanged += new System.EventHandler(this.textBoxBuscarCliente_TextChanged);
            // 
            // buttonNovoCliente
            // 
            this.buttonNovoCliente.FlatAppearance.BorderSize = 0;
            this.buttonNovoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNovoCliente.Location = new System.Drawing.Point(436, 17);
            this.buttonNovoCliente.Name = "buttonNovoCliente";
            this.buttonNovoCliente.Size = new System.Drawing.Size(100, 23);
            this.buttonNovoCliente.TabIndex = 5;
            this.buttonNovoCliente.Text = "Novo Cliente";
            this.buttonNovoCliente.UseVisualStyleBackColor = true;
            this.buttonNovoCliente.Click += new System.EventHandler(this.buttonNovoCliente_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(321, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 39);
            this.label8.TabIndex = 4;
            this.label8.Text = "Gerenciamento de Máquinas Agrícolas\r\nSIGMA\r\nVersão 1.0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxEstadoEn);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.textBoxCidadeEnt);
            this.groupBox3.Controls.Add(this.labelCidade);
            this.groupBox3.Controls.Add(this.textBoxEnderecoEnt);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(20, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(503, 111);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Endereço de Entrega";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // comboBoxEstadoEn
            // 
            this.comboBoxEstadoEn.FormattingEnabled = true;
            this.comboBoxEstadoEn.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas\t",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais ",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo ",
            "Sergipe",
            "Tocantins"});
            this.comboBoxEstadoEn.Location = new System.Drawing.Point(326, 74);
            this.comboBoxEstadoEn.Name = "comboBoxEstadoEn";
            this.comboBoxEstadoEn.Size = new System.Drawing.Size(155, 21);
            this.comboBoxEstadoEn.TabIndex = 5;
            this.comboBoxEstadoEn.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstadoEn_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(323, 58);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Estado*";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // textBoxCidadeEnt
            // 
            this.textBoxCidadeEnt.Location = new System.Drawing.Point(16, 75);
            this.textBoxCidadeEnt.Name = "textBoxCidadeEnt";
            this.textBoxCidadeEnt.Size = new System.Drawing.Size(270, 20);
            this.textBoxCidadeEnt.TabIndex = 3;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(17, 59);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(44, 13);
            this.labelCidade.TabIndex = 2;
            this.labelCidade.Text = "Cidade*";
            // 
            // textBoxEnderecoEnt
            // 
            this.textBoxEnderecoEnt.Location = new System.Drawing.Point(16, 33);
            this.textBoxEnderecoEnt.Name = "textBoxEnderecoEnt";
            this.textBoxEnderecoEnt.Size = new System.Drawing.Size(481, 20);
            this.textBoxEnderecoEnt.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Endereço*";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.Location = new System.Drawing.Point(24, 162);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.Size = new System.Drawing.Size(499, 20);
            this.textBoxNomeCliente.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 146);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Nome do Cliente selecionado";
            // 
            // listViewCliente
            // 
            this.listViewCliente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewCliente.GridLines = true;
            this.listViewCliente.Location = new System.Drawing.Point(19, 46);
            this.listViewCliente.Name = "listViewCliente";
            this.listViewCliente.Size = new System.Drawing.Size(504, 90);
            this.listViewCliente.TabIndex = 0;
            this.listViewCliente.UseCompatibleStateImageBehavior = false;
            this.listViewCliente.View = System.Windows.Forms.View.Details;
            this.listViewCliente.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 356;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cidade";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(998, 519);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "SIGMA 1.0";
            // 
            // buttonSair
            // 
            this.buttonSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Image = global::Projeto_TCD.Properties.Resources.Voltar2;
            this.buttonSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSair.Location = new System.Drawing.Point(341, 477);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 44);
            this.buttonSair.TabIndex = 7;
            this.buttonSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Image = global::Projeto_TCD.Properties.Resources.Cancelar2;
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCancelar.Location = new System.Drawing.Point(260, 477);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 44);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExcluir.FlatAppearance.BorderSize = 0;
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluir.Image = global::Projeto_TCD.Properties.Resources.Excluir;
            this.buttonExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExcluir.Location = new System.Drawing.Point(179, 477);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 44);
            this.buttonExcluir.TabIndex = 5;
            this.buttonExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAlterar.FlatAppearance.BorderSize = 0;
            this.buttonAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlterar.Image = global::Projeto_TCD.Properties.Resources.Alterar1;
            this.buttonAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAlterar.Location = new System.Drawing.Point(97, 477);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 44);
            this.buttonAlterar.TabIndex = 4;
            this.buttonAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Projeto_TCD.Properties.Resources.Adicionar1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(16, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 3;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1073, 545);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Vendas             SIGMA Versão 1.0";
            this.Load += new System.EventHandler(this.FormVenda_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantidade)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNomeVendedor;
        private System.Windows.Forms.ComboBox comboBoxVendedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1Maquina;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LABE;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDetMaq;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxTransportadora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFrete;
        private System.Windows.Forms.Label LABEL9;
        private System.Windows.Forms.TextBox textBoxCustoTotal;
        private System.Windows.Forms.Button buttonDesconto;
        private System.Windows.Forms.ComboBox comboBoxEstCompra;
        private System.Windows.Forms.TextBox textBoxCidCompra;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listViewCliente;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxEnderecoEnt;
        private System.Windows.Forms.TextBox textBoxCidadeEnt;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.ComboBox comboBoxEstadoEn;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBoxDesconto;
        private System.Windows.Forms.Button buttonDes;
        private System.Windows.Forms.TextBox textBoxBuscarCliente;
        private System.Windows.Forms.Button buttonNovoCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
    }
}