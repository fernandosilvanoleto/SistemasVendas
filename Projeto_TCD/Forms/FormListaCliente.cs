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
    public partial class FormListaCliente : Form
    {
        public FormListaCliente()
        {
            InitializeComponent();
        }

        private void FormListaCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DatabaseBancosDataSetGeral.Cliente' table. You can move, or remove it, as needed.
            this.ClienteTableAdapter.Fill(this.DatabaseBancosDataSetGeral.Cliente);

            this.reportViewer1.RefreshReport();
        }
    }
}
