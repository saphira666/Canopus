using Canoppus.BLL;
using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canoppus.UI
{
    public partial class FrmRelatorio : Form
    {
        public FrmRelatorio()
        {
            InitializeComponent();
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {

            dgv1.BackgroundColor = Color.WhiteSmoke;
        }

        private void btnStartgv_Click(object sender, EventArgs e)
        {
            UsuarioBLL objModelo = new UsuarioBLL();
            dgv1.DataSource = objModelo.ListarUsuario();

            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            dgv1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dgv1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = lblTitulo.Text;
            printer.PageNumbers = true;
            printer.PorportionalColumns = true;
            printer.Footer = DateTime.Now.ToString();
            printer.PrintDataGridView(dgv1);
        }
    }
}
