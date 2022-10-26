using Canoppus.BLL;
using Canoppus.DTO;
using Canoppus.UI.Utilitarios;
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
    public partial class FrmCadastrarTarefa : Form
    {
        public FrmCadastrarTarefa()
        {
            InitializeComponent();
        }

        private void FrmCadastrarTarefa_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //carregando o valor selecionado no cBox1
        private void cBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            cBox1.ValueMember = "IdUsuario";
            //lblResult.Text = cBox1.SelectedValue.ToString();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TarefaDTO objCad = new TarefaDTO();
            objCad.nomeTarefa = txtNomeTarefa.Text;
            objCad.descricaoTarefa = txtDescricaoTarefa.Text;

            DateTime dt = DateTime.Parse(txtPrazoTarefa.Text);
            objCad.prazoTarefa = dt.ToString("yyyy/MM/dd");

            //checando status
            if (rb1.Checked)
            {
                objCad.statusTarefa = "Ativo";
            }
            else if (rb2.Checked)
            {
                objCad.statusTarefa = "Inativo";
            }

            //carregando responsavelTarefa
            objCad.responsavelTarefaIdUsuario = cBox1.SelectedValue.ToString();


            TarefaBLL objCadastra = new TarefaBLL();
            objCadastra.cadastraTarefa(objCad);
            Limpar.ClearControl(this);

            MessageBox.Show("Tarefa " + objCad.nomeTarefa + " cadastrada com sucesso!!");

        }

        private void btnCarrega_Click(object sender, EventArgs e)
        {
            TarefaBLL obj = new TarefaBLL();
            cBox1.Items.Clear();
            cBox1.DisplayMember = "NomeUsuario";
            cBox1.DataSource = obj.ListarUsuario().ToList();

            //carrega diferença entre datas
            DateTime dt1 = DateTime.Parse(txtPrazoTarefa.Text);

            DateTime dt = new DateTime();

            dt = DateTime.Now;
            if (txtPrazoTarefa.Text != string.Empty)
            {
                TimeSpan result = dt1-dt;
                lblResult.Text = result.ToString("dd")+" dias";
            }
        }


    }
}
