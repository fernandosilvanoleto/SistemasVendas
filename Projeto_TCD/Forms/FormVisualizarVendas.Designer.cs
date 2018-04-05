namespace Projeto_TCD
{
    partial class FormVisualizarVendas
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
            this.listViewRelatorios = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.databaseBancosDataSet = new Projeto_TCD.DatabaseBancosDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Projeto_TCD.DatabaseBancosDataSetTableAdapters.ClienteTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonVendaPorEst = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.databaseBancosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewRelatorios
            // 
            this.listViewRelatorios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listViewRelatorios.GridLines = true;
            this.listViewRelatorios.Location = new System.Drawing.Point(2, 12);
            this.listViewRelatorios.Name = "listViewRelatorios";
            this.listViewRelatorios.Size = new System.Drawing.Size(900, 381);
            this.listViewRelatorios.TabIndex = 0;
            this.listViewRelatorios.UseCompatibleStateImageBehavior = false;
            this.listViewRelatorios.View = System.Windows.Forms.View.Details;
            this.listViewRelatorios.SelectedIndexChanged += new System.EventHandler(this.listViewRelatorios_SelectedIndexChanged);
            this.listViewRelatorios.DoubleClick += new System.EventHandler(this.listViewRelatorios_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Código Cliente";
            this.columnHeader2.Width = 83;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nome do cliente";
            this.columnHeader6.Width = 188;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Máquina";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Marca";
            this.columnHeader8.Width = 84;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Custo Total";
            this.columnHeader9.Width = 98;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Data";
            this.columnHeader10.Width = 171;
            // 
            // databaseBancosDataSet
            // 
            this.databaseBancosDataSet.DataSetName = "DatabaseBancosDataSet";
            this.databaseBancosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.databaseBancosDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(651, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 39);
            this.label8.TabIndex = 7;
            this.label8.Text = "Gerenciamento de Máquinas Agrícolas\r\nSIGMA\r\nVersão 1.0";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Projeto_TCD.Properties.Resources.analise2;
            this.button1.Location = new System.Drawing.Point(244, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 59);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonVendaPorEst
            // 
            this.buttonVendaPorEst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVendaPorEst.FlatAppearance.BorderSize = 0;
            this.buttonVendaPorEst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVendaPorEst.Image = global::Projeto_TCD.Properties.Resources.Analise1;
            this.buttonVendaPorEst.Location = new System.Drawing.Point(91, 404);
            this.buttonVendaPorEst.Name = "buttonVendaPorEst";
            this.buttonVendaPorEst.Size = new System.Drawing.Size(101, 59);
            this.buttonVendaPorEst.TabIndex = 3;
            this.buttonVendaPorEst.UseVisualStyleBackColor = true;
            this.buttonVendaPorEst.Click += new System.EventHandler(this.buttonVendaPorEst_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Image = global::Projeto_TCD.Properties.Resources.Voltar2;
            this.buttonSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSair.Location = new System.Drawing.Point(396, 408);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 55);
            this.buttonSair.TabIndex = 2;
            this.buttonSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // FormVisualizarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 483);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonVendaPorEst);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.listViewRelatorios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVisualizarVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relátorios de Vendas";
            this.Load += new System.EventHandler(this.FormVisualizarVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseBancosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewRelatorios;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button buttonSair;
        private DatabaseBancosDataSet databaseBancosDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DatabaseBancosDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Button buttonVendaPorEst;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}