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
    public partial class MDIOutros : Form
    {
        public MDIOutros()
        {
            InitializeComponent();
        }

        private void MDIOutros_Load(object sender, EventArgs e)
        {
            lblSession.Text = "Seja bem vindo " + Session.nomeUsuario + " ao sistema Canoppus!! início de sua seção: " + DateTime.Now.ToString();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorio obj = new FrmRelatorio();
            obj.ShowDialog();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sua sessão será encerrada !!","Atenção", MessageBoxButtons.OK);
            Application.Exit();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sua sessão será encerrada !!", "Atenção", MessageBoxButtons.OK);
            Application.Exit();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            FrmRelatorio obj = new FrmRelatorio();
            obj.ShowDialog();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }
    }
}
