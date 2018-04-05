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
    public partial class FormListaMaquina : Form
    {
        public FormListaMaquina()
        {
            InitializeComponent();
        }

        private void FormListaMaquina_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DatabaseBancosDataSetGeral.Maquina' table. You can move, or remove it, as needed.
            this.MaquinaTableAdapter.Fill(this.DatabaseBancosDataSetGeral.Maquina);

            this.reportViewer1.RefreshReport();
        }
    }
}
