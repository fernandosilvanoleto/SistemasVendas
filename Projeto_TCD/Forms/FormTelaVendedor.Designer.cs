namespace Projeto_TCD
{
    partial class FormTelaVendedor
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSistema = new System.Windows.Forms.Button();
            this.buttonVerVendas = new System.Windows.Forms.Button();
            this.buttonVerCliente = new System.Windows.Forms.Button();
            this.buttonVendas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(573, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 39);
            this.label8.TabIndex = 7;
            this.label8.Text = "Gerenciamento de Máquinas Agrícolas\r\nSIGMA\r\nVersão 1.0";
            // 
            // buttonSistema
            // 
            this.buttonSistema.FlatAppearance.BorderSize = 0;
            this.buttonSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSistema.Image = global::Projeto_TCD.Properties.Resources.Sistema;
            this.buttonSistema.Location = new System.Drawing.Point(669, 54);
            this.buttonSistema.Name = "buttonSistema";
            this.buttonSistema.Size = new System.Drawing.Size(130, 132);
            this.buttonSistema.TabIndex = 6;
            this.buttonSistema.UseVisualStyleBackColor = true;
            this.buttonSistema.Click += new System.EventHandler(this.buttonSistema_Click);
            // 
            // buttonVerVendas
            // 
            this.buttonVerVendas.FlatAppearance.BorderSize = 0;
            this.buttonVerVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVerVendas.Image = global::Projeto_TCD.Properties.Resources.Carrinho;
            this.buttonVerVendas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonVerVendas.Location = new System.Drawing.Point(499, 54);
            this.buttonVerVendas.Name = "buttonVerVendas";
            this.buttonVerVendas.Size = new System.Drawing.Size(130, 132);
            this.buttonVerVendas.TabIndex = 5;
            this.buttonVerVendas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonVerVendas.UseVisualStyleBackColor = true;
            this.buttonVerVendas.Click += new System.EventHandler(this.buttonVerVendas_Click);
            // 
            // buttonVerCliente
            // 
            this.buttonVerCliente.FlatAppearance.BorderSize = 0;
            this.buttonVerCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVerCliente.Image = global::Projeto_TCD.Properties.Resources.Ver_Cliente;
            this.buttonVerCliente.Location = new System.Drawing.Point(332, 54);
            this.buttonVerCliente.Name = "buttonVerCliente";
            this.buttonVerCliente.Size = new System.Drawing.Size(130, 132);
            this.buttonVerCliente.TabIndex = 4;
            this.buttonVerCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonVerCliente.UseVisualStyleBackColor = true;
            this.buttonVerCliente.Click += new System.EventHandler(this.buttonVerCliente_Click);
            // 
            // buttonVendas
            // 
            this.buttonVendas.FlatAppearance.BorderSize = 0;
            this.buttonVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVendas.Image = global::Projeto_TCD.Properties.Resources.Vendas_1;
            this.buttonVendas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonVendas.Location = new System.Drawing.Point(174, 54);
            this.buttonVendas.Name = "buttonVendas";
            this.buttonVendas.Size = new System.Drawing.Size(130, 132);
            this.buttonVendas.TabIndex = 3;
            this.buttonVendas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonVendas.UseVisualStyleBackColor = true;
            this.buttonVendas.Click += new System.EventHandler(this.buttonVendas_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Projeto_TCD.Properties.Resources.AdicionarPessoas;
            this.button1.Location = new System.Drawing.Point(23, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 132);
            this.button1.TabIndex = 2;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.Image = global::Projeto_TCD.Properties.Resources.Fechar;
            this.buttonSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSair.Location = new System.Drawing.Point(709, 191);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(90, 85);
            this.buttonSair.TabIndex = 1;
            this.buttonSair.Text = "Sair";
            this.buttonSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // FormTelaVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 347);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonSistema);
            this.Controls.Add(this.buttonVerVendas);
            this.Controls.Add(this.buttonVerCliente);
            this.Controls.Add(this.buttonVendas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTelaVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bem - vindo, Vendedor(a)";
            this.Load += new System.EventHandler(this.FormTelaVendedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonVendas;
        private System.Windows.Forms.Button buttonVerCliente;
        private System.Windows.Forms.Button buttonVerVendas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonSistema;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTip1;


    }
}