namespace Projeto_TCD
{
    partial class FormMaquina
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.textBoxNomeMarca = new System.Windows.Forms.TextBox();
            this.textBoxNomeMaquina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownAnoFab = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonTrator = new System.Windows.Forms.RadioButton();
            this.radioButtonColheitadeira = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDownPeso = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxCombustivel = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxPotencia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxMotor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnoFab)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome da Marca*";
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(66, 12);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(160, 21);
            this.comboBoxMarca.TabIndex = 2;
            this.comboBoxMarca.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarca_SelectedIndexChanged);
            // 
            // textBoxNomeMarca
            // 
            this.textBoxNomeMarca.Location = new System.Drawing.Point(326, 12);
            this.textBoxNomeMarca.Name = "textBoxNomeMarca";
            this.textBoxNomeMarca.Size = new System.Drawing.Size(139, 20);
            this.textBoxNomeMarca.TabIndex = 3;
            // 
            // textBoxNomeMaquina
            // 
            this.textBoxNomeMaquina.Location = new System.Drawing.Point(125, 46);
            this.textBoxNomeMaquina.Name = "textBoxNomeMaquina";
            this.textBoxNomeMaquina.Size = new System.Drawing.Size(340, 20);
            this.textBoxNomeMaquina.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome da Máquina*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ano de Fabricação*";
            // 
            // numericUpDownAnoFab
            // 
            this.numericUpDownAnoFab.Location = new System.Drawing.Point(239, 92);
            this.numericUpDownAnoFab.Maximum = new decimal(new int[] {
            20000000,
            0,
            0,
            0});
            this.numericUpDownAnoFab.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownAnoFab.Name = "numericUpDownAnoFab";
            this.numericUpDownAnoFab.Size = new System.Drawing.Size(73, 20);
            this.numericUpDownAnoFab.TabIndex = 7;
            this.numericUpDownAnoFab.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Modelo*";
            // 
            // radioButtonTrator
            // 
            this.radioButtonTrator.AutoSize = true;
            this.radioButtonTrator.Location = new System.Drawing.Point(28, 92);
            this.radioButtonTrator.Name = "radioButtonTrator";
            this.radioButtonTrator.Size = new System.Drawing.Size(53, 17);
            this.radioButtonTrator.TabIndex = 9;
            this.radioButtonTrator.TabStop = true;
            this.radioButtonTrator.Text = "Trator";
            this.radioButtonTrator.UseVisualStyleBackColor = true;
            // 
            // radioButtonColheitadeira
            // 
            this.radioButtonColheitadeira.AutoSize = true;
            this.radioButtonColheitadeira.Location = new System.Drawing.Point(87, 92);
            this.radioButtonColheitadeira.Name = "radioButtonColheitadeira";
            this.radioButtonColheitadeira.Size = new System.Drawing.Size(86, 17);
            this.radioButtonColheitadeira.TabIndex = 10;
            this.radioButtonColheitadeira.TabStop = true;
            this.radioButtonColheitadeira.Text = "Colheitadeira";
            this.radioButtonColheitadeira.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Motor*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxValor);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.numericUpDownPeso);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.comboBoxCombustivel);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxPotencia);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxMotor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(22, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 149);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações Técnicas";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(65, 116);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(220, 20);
            this.textBoxValor.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 119);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Valor* : R$";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(186, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "por KG";
            // 
            // numericUpDownPeso
            // 
            this.numericUpDownPeso.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPeso.Location = new System.Drawing.Point(86, 87);
            this.numericUpDownPeso.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownPeso.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPeso.Name = "numericUpDownPeso";
            this.numericUpDownPeso.Size = new System.Drawing.Size(94, 20);
            this.numericUpDownPeso.TabIndex = 24;
            this.numericUpDownPeso.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Peso Máquina*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(214, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Cor*";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Azul",
            "Amarelo",
            "Branco",
            "Cinza",
            "Laranja",
            "Verde",
            "Vermelho",
            "Prata",
            "Preto"});
            this.comboBox1.Location = new System.Drawing.Point(246, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // comboBoxCombustivel
            // 
            this.comboBoxCombustivel.FormattingEnabled = true;
            this.comboBoxCombustivel.Items.AddRange(new object[] {
            "Gasolina",
            "Diesel",
            "Gás Natural",
            "Biodiesel",
            "Etanol"});
            this.comboBoxCombustivel.Location = new System.Drawing.Point(78, 52);
            this.comboBoxCombustivel.Name = "comboBoxCombustivel";
            this.comboBoxCombustivel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCombustivel.TabIndex = 18;
            this.comboBoxCombustivel.SelectedIndexChanged += new System.EventHandler(this.comboBoxCombustivel_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Combustível*";
            // 
            // textBoxPotencia
            // 
            this.textBoxPotencia.Location = new System.Drawing.Point(271, 19);
            this.textBoxPotencia.Name = "textBoxPotencia";
            this.textBoxPotencia.Size = new System.Drawing.Size(143, 20);
            this.textBoxPotencia.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(214, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Potência*";
            // 
            // textBoxMotor
            // 
            this.textBoxMotor.Location = new System.Drawing.Point(44, 22);
            this.textBoxMotor.Name = "textBoxMotor";
            this.textBoxMotor.Size = new System.Drawing.Size(164, 20);
            this.textBoxMotor.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Projeto_TCD.Properties.Resources.Adicionar1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(22, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 19;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalvar.FlatAppearance.BorderSize = 0;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Image = global::Projeto_TCD.Properties.Resources.Alterar1;
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSalvar.Location = new System.Drawing.Point(103, 298);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 44);
            this.buttonSalvar.TabIndex = 20;
            this.buttonSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Projeto_TCD.Properties.Resources.Excluir;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(184, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 44);
            this.button2.TabIndex = 23;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Image = global::Projeto_TCD.Properties.Resources.Voltar2;
            this.buttonSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSair.Location = new System.Drawing.Point(345, 298);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 44);
            this.buttonSair.TabIndex = 24;
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
            this.buttonCancelar.Location = new System.Drawing.Point(264, 298);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 44);
            this.buttonCancelar.TabIndex = 21;
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(312, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 39);
            this.label8.TabIndex = 25;
            this.label8.Text = "Gerenciamento de Máquinas Agrícolas\r\nSIGMA\r\nVersão 1.0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 28;
            // 
            // FormMaquina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 434);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButtonColheitadeira);
            this.Controls.Add(this.radioButtonTrator);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownAnoFab);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNomeMaquina);
            this.Controls.Add(this.textBoxNomeMarca);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMaquina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Máquina:";
            this.Load += new System.EventHandler(this.FormMaquina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnoFab)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.TextBox textBoxNomeMarca;
        private System.Windows.Forms.TextBox textBoxNomeMaquina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownAnoFab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonTrator;
        private System.Windows.Forms.RadioButton radioButtonColheitadeira;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxCombustivel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxPotencia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxMotor;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericUpDownPeso;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}