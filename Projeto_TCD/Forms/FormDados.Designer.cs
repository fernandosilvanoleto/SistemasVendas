namespace Projeto_TCD.Forms
{
    partial class FormDados
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.VendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatabaseBancosDataSetGeral = new Projeto_TCD.DatabaseBancosDataSetGeral();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VendasTableAdapter = new Projeto_TCD.DatabaseBancosDataSetGeralTableAdapters.VendasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseBancosDataSetGeral)).BeginInit();
            this.SuspendLayout();
            // 
            // VendasBindingSource
            // 
            this.VendasBindingSource.DataMember = "Vendas";
            this.VendasBindingSource.DataSource = this.DatabaseBancosDataSetGeral;
            // 
            // DatabaseBancosDataSetGeral
            // 
            this.DatabaseBancosDataSetGeral.DataSetName = "DatabaseBancosDataSetGeral";
            this.DatabaseBancosDataSetGeral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetDados";
            reportDataSource1.Value = this.VendasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto_TCD.ReportDados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(647, 356);
            this.reportViewer1.TabIndex = 0;
            // 
            // VendasTableAdapter
            // 
            this.VendasTableAdapter.ClearBeforeFill = true;
            // 
            // FormDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 356);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormDados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseBancosDataSetGeral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VendasBindingSource;
        private DatabaseBancosDataSetGeral DatabaseBancosDataSetGeral;
        private DatabaseBancosDataSetGeralTableAdapters.VendasTableAdapter VendasTableAdapter;
    }
}