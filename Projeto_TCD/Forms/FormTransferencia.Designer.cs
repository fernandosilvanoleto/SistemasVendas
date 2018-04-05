namespace Projeto_TCD.Forms
{
    partial class FormTransferencia
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonRecuperar = new System.Windows.Forms.Button();
            this.buttonTransferir = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 115);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(661, 274);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            this.columnHeader1.Width = 55;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 152;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Marca";
            this.columnHeader3.Width = 153;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Estado";
            this.columnHeader4.Width = 156;
            // 
            // buttonRecuperar
            // 
            this.buttonRecuperar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRecuperar.FlatAppearance.BorderSize = 0;
            this.buttonRecuperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecuperar.Image = global::Projeto_TCD.Properties.Resources.VoltarT;
            this.buttonRecuperar.Location = new System.Drawing.Point(699, 395);
            this.buttonRecuperar.Name = "buttonRecuperar";
            this.buttonRecuperar.Size = new System.Drawing.Size(75, 50);
            this.buttonRecuperar.TabIndex = 2;
            this.buttonRecuperar.UseVisualStyleBackColor = true;
            this.buttonRecuperar.Click += new System.EventHandler(this.buttonRecuperar_Click);
            // 
            // buttonTransferir
            // 
            this.buttonTransferir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTransferir.FlatAppearance.BorderSize = 0;
            this.buttonTransferir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransferir.Image = global::Projeto_TCD.Properties.Resources.Transferir;
            this.buttonTransferir.Location = new System.Drawing.Point(598, 395);
            this.buttonTransferir.Name = "buttonTransferir";
            this.buttonTransferir.Size = new System.Drawing.Size(75, 50);
            this.buttonTransferir.TabIndex = 1;
            this.buttonTransferir.UseVisualStyleBackColor = true;
            this.buttonTransferir.Click += new System.EventHandler(this.buttonTransferir_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(689, 115);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(661, 274);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Código";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nome";
            this.columnHeader6.Width = 212;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Marca";
            this.columnHeader7.Width = 228;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Estado";
            this.columnHeader8.Width = 149;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Projeto_TCD.Properties.Resources.Voltar2;
            this.button1.Location = new System.Drawing.Point(1263, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 49);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(502, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 35);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Transferência de Máquina";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1124, 484);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 39);
            this.label8.TabIndex = 6;
            this.label8.Text = "Gerenciamento de Máquinas Agrícolas\r\nSIGMA\r\nVersão 1.0";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Máquinas disponíveis para vendas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(972, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Máquinas transferidas";
            // 
            // FormTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 525);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.buttonRecuperar);
            this.Controls.Add(this.buttonTransferir);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTransferencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferencia de Máquina";
            this.Load += new System.EventHandler(this.FormTransferencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonTransferir;
        private System.Windows.Forms.Button buttonRecuperar;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}