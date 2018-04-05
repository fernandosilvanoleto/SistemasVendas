namespace Projeto_TCD
{
    partial class FormTelaGerente
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
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.máquinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.máquinaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buttonTerminarSess = new System.Windows.Forms.Button();
            this.buttonSistema = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.máquinaToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastramento";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = global::Projeto_TCD.Properties.Resources.Login2;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // máquinaToolStripMenuItem
            // 
            this.máquinaToolStripMenuItem.Image = global::Projeto_TCD.Properties.Resources.Caminhao;
            this.máquinaToolStripMenuItem.Name = "máquinaToolStripMenuItem";
            this.máquinaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.máquinaToolStripMenuItem.Text = "Máquina";
            this.máquinaToolStripMenuItem.Click += new System.EventHandler(this.máquinaToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novasToolStripMenuItem,
            this.transferênciasToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.vendasToolStripMenuItem.Text = "Atividades";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // novasToolStripMenuItem
            // 
            this.novasToolStripMenuItem.Image = global::Projeto_TCD.Properties.Resources.Realizar_Venda;
            this.novasToolStripMenuItem.Name = "novasToolStripMenuItem";
            this.novasToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.novasToolStripMenuItem.Text = "Vendas";
            this.novasToolStripMenuItem.Click += new System.EventHandler(this.novasToolStripMenuItem_Click);
            // 
            // transferênciasToolStripMenuItem
            // 
            this.transferênciasToolStripMenuItem.Image = global::Projeto_TCD.Properties.Resources.Chave1;
            this.transferênciasToolStripMenuItem.Name = "transferênciasToolStripMenuItem";
            this.transferênciasToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.transferênciasToolStripMenuItem.Text = "Transferências";
            this.transferênciasToolStripMenuItem.Click += new System.EventHandler(this.transferênciasToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.máquinaToolStripMenuItem1,
            this.vendasToolStripMenuItem1});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            this.relatóriosToolStripMenuItem.Click += new System.EventHandler(this.relatóriosToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Image = global::Projeto_TCD.Properties.Resources.Pessoas1;
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // máquinaToolStripMenuItem1
            // 
            this.máquinaToolStripMenuItem1.Image = global::Projeto_TCD.Properties.Resources.Ver_Maquina;
            this.máquinaToolStripMenuItem1.Name = "máquinaToolStripMenuItem1";
            this.máquinaToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.máquinaToolStripMenuItem1.Text = "Máquina";
            this.máquinaToolStripMenuItem1.Click += new System.EventHandler(this.máquinaToolStripMenuItem1_Click);
            // 
            // vendasToolStripMenuItem1
            // 
            this.vendasToolStripMenuItem1.Image = global::Projeto_TCD.Properties.Resources.Ver_Venda;
            this.vendasToolStripMenuItem1.Name = "vendasToolStripMenuItem1";
            this.vendasToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.vendasToolStripMenuItem1.Text = "Vendas";
            this.vendasToolStripMenuItem1.Click += new System.EventHandler(this.vendasToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(714, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buttonTerminarSess
            // 
            this.buttonTerminarSess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTerminarSess.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.buttonTerminarSess.FlatAppearance.BorderSize = 0;
            this.buttonTerminarSess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTerminarSess.Image = global::Projeto_TCD.Properties.Resources.Fechar1;
            this.buttonTerminarSess.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTerminarSess.Location = new System.Drawing.Point(633, 89);
            this.buttonTerminarSess.Name = "buttonTerminarSess";
            this.buttonTerminarSess.Size = new System.Drawing.Size(81, 83);
            this.buttonTerminarSess.TabIndex = 1;
            this.buttonTerminarSess.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTerminarSess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonTerminarSess.UseVisualStyleBackColor = true;
            this.buttonTerminarSess.UseWaitCursor = true;
            this.buttonTerminarSess.Click += new System.EventHandler(this.buttonTerminarSess_Click);
            // 
            // buttonSistema
            // 
            this.buttonSistema.FlatAppearance.BorderSize = 0;
            this.buttonSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSistema.Location = new System.Drawing.Point(350, 161);
            this.buttonSistema.Name = "buttonSistema";
            this.buttonSistema.Size = new System.Drawing.Size(132, 57);
            this.buttonSistema.TabIndex = 2;
            this.buttonSistema.Text = "Sobre o Sistema";
            this.buttonSistema.UseVisualStyleBackColor = true;
            this.buttonSistema.Click += new System.EventHandler(this.buttonSistema_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(488, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 39);
            this.label8.TabIndex = 5;
            this.label8.Text = "Gerenciamento de Máquinas Agrícolas\r\nSIGMA\r\nVersão 1.0";
            // 
            // FormTelaGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(714, 230);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonSistema);
            this.Controls.Add(this.buttonTerminarSess);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTelaGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Área de Trabalho do Gerente";
            this.Load += new System.EventHandler(this.FormTelaGerente_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTerminarSess;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem máquinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem máquinaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button buttonSistema;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem transferênciasToolStripMenuItem;
    }
}