using Canoppus.BLL;
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
    public partial class MDIAdm : Form
    {
        public MDIAdm()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sua sessão será encerrada !!", "Atenção", MessageBoxButtons.OK);
            Application.Exit();
        }

        private void cadastroUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrar obj = new FrmCadastrar();
            obj.ShowDialog();
        }

        private void editarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditar obj = new FrmEditar();
            obj.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmCadastrar obj = new FrmCadastrar();
            obj.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmEditar obj = new FrmEditar();
            obj.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FrmExcluir obj = new FrmExcluir();
            obj.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sua sessão será encerrada !!", "Atenção", MessageBoxButtons.OK);
            Application.Exit();
        }

        private void MDIAdm_Load(object sender, EventArgs e)
        {
            lblSession.Text = "Seja bem vindo " + Session.nomeUsuario + " ao sistema Canopus!! início de sua seção: " + DateTime.Now.ToString();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            FrmRelatorio obj = new FrmRelatorio();
            obj.ShowDialog();
        }
    }
}
