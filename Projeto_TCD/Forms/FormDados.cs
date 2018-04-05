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
    public partial class FormDados : Form
    {
        public FormDados()
        {
            InitializeComponent();
        }

        private void FormDados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DatabaseBancosDataSetGeral.Vendas' table. You can move, or remove it, as needed.
            this.VendasTableAdapter.Fill(this.DatabaseBancosDataSetGeral.Vendas);

            this.reportViewer1.RefreshReport();
        }
    }
}
