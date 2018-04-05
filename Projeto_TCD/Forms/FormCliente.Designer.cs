namespace Projeto_TCD.Forms
{
    partial class FormCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.textBoxRG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBoxDTNasc = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.textBoxComplemento = new System.Windows.Forms.TextBox();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxRua = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome *";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(77, 24);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(478, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.comboBoxTipo.Location = new System.Drawing.Point(77, 61);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF *";
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Location = new System.Drawing.Point(250, 61);
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(155, 20);
            this.textBoxCPF.TabIndex = 5;
            // 
            // textBoxRG
            // 
            this.textBoxRG.Location = new System.Drawing.Point(455, 61);
            this.textBoxRG.Name = "textBoxRG";
            this.textBoxRG.Size = new System.Drawing.Size(100, 20);
            this.textBoxRG.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "RG *";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(77, 95);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(478, 20);
            this.textBoxEmail.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data de Nascimento *";
            // 
            // maskedTextBoxDTNasc
            // 
            this.maskedTextBoxDTNasc.Location = new System.Drawing.Point(144, 135);
            this.maskedTextBoxDTNasc.Mask = "00/00/0000";
            this.maskedTextBoxDTNasc.Name = "maskedTextBoxDTNasc";
            this.maskedTextBoxDTNasc.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxDTNasc.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sexo *";
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.comboBoxSexo.Location = new System.Drawing.Point(302, 134);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSexo.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBoxTelefone);
            this.groupBox1.Controls.Add(this.comboBoxEstado);
            this.groupBox1.Controls.Add(this.textBoxCidade);
            this.groupBox1.Controls.Add(this.textBoxComplemento);
            this.groupBox1.Controls.Add(this.textBoxBairro);
            this.groupBox1.Controls.Add(this.textBoxNumero);
            this.groupBox1.Controls.Add(this.textBoxRua);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(34, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 149);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço Particular";
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(56, 118);
            this.maskedTextBoxTelefone.Mask = "(00)00000000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxTelefone.TabIndex = 15;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
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
            this.comboBoxEstado.Location = new System.Drawing.Point(372, 94);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(135, 21);
            this.comboBoxEstado.TabIndex = 14;
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(50, 95);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(293, 20);
            this.textBoxCidade.TabIndex = 13;
            // 
            // textBoxComplemento
            // 
            this.textBoxComplemento.Location = new System.Drawing.Point(77, 72);
            this.textBoxComplemento.Name = "textBoxComplemento";
            this.textBoxComplemento.Size = new System.Drawing.Size(430, 20);
            this.textBoxComplemento.TabIndex = 12;
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Location = new System.Drawing.Point(43, 48);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(464, 20);
            this.textBoxBairro.TabIndex = 10;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(407, 25);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumero.TabIndex = 9;
            // 
            // textBoxRua
            // 
            this.textBoxRua.Location = new System.Drawing.Point(34, 25);
            this.textBoxRua.Name = "textBoxRua";
            this.textBoxRua.Size = new System.Drawing.Size(320, 20);
            this.textBoxRua.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Telefone*";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(349, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "UF*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Cidade*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Complemento*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Bairro*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(354, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Número*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Rua*";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Projeto_TCD.Properties.Resources.Voltar2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(415, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 19;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Image = global::Projeto_TCD.Properties.Resources.Cancelar2;
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCancelar.Location = new System.Drawing.Point(313, 343);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 44);
            this.buttonCancelar.TabIndex = 18;
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
            this.buttonExcluir.Location = new System.Drawing.Point(217, 343);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 44);
            this.buttonExcluir.TabIndex = 17;
            this.buttonExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalvar.FlatAppearance.BorderSize = 0;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Image = global::Projeto_TCD.Properties.Resources.Alterar1;
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSalvar.Location = new System.Drawing.Point(123, 343);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 44);
            this.buttonSalvar.TabIndex = 16;
            this.buttonSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.buttonCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCadastrar.FlatAppearance.BorderSize = 0;
            this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrar.Image = global::Projeto_TCD.Properties.Resources.Adicionar1;
            this.buttonCadastrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCadastrar.Location = new System.Drawing.Point(34, 343);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 44);
            this.buttonCadastrar.TabIndex = 15;
            this.buttonCadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(367, 409);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(226, 39);
            this.label11.TabIndex = 20;
            this.label11.Text = "Gerenciamento de Máquinas Agrícolas\r\nSIGMA\r\nVersão 1.0";
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 448);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxSexo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maskedTextBoxDTNasc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRG);
            this.Controls.Add(this.textBoxCPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCPF;
        private System.Windows.Forms.TextBox textBoxRG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDTNasc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSexo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.TextBox textBoxComplemento;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.TextBox textBoxRua;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label11;
    }
}