using Canoppus.BLL;
using Canoppus.DTO;
using Canoppus.UI.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canoppus.UI
{
    public partial class FrmExcluir : Form
    {
        public FrmExcluir()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Deseja mesmo excluir o Registro?", "ATENÇÃO!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //manipulando o valor escolhido no messagebox
            if (msg == DialogResult.Yes)
            {
                UsuarioBLL objExcluiBLL = new UsuarioBLL();//metodo
                int codigo = Convert.ToInt32(txtId.Text);
                objExcluiBLL.ExcluirUsuario(codigo);
                //Limpar();
                MessageBox.Show("Usuário eliminado com sucesso !!", "Sucesso", MessageBoxButtons.OK);
            }
            else if (msg == DialogResult.No)
            {
                Limpar.ClearControl(this);
            }
        }



        //pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Digita um Id !!", "Atenção", MessageBoxButtons.OK);
                txtId.Focus();
                return;

            }

            //layout
            gpPrincipal.Visible = true;
            gpPrincipal.Enabled = false;


            //criando variaveis e chamando metodos
            int codigo = Convert.ToInt32(txtId.Text);
            UsuarioDTO objPesquisa = new UsuarioDTO();//modelo
            UsuarioBLL objPesqBLL = new UsuarioBLL();//metodo
            objPesquisa = objPesqBLL.SelecionaUsuario(codigo);

            if (objPesquisa != null)
            {
                //habilitando componentes
                txtId.Text = objPesquisa.IdUsuario.ToString();
                txtNome.Text = objPesquisa.NomeUsuario;
                txtSenha.Text = objPesquisa.SenhaUsuario;
                txtCpf.Text = objPesquisa.CpfUsuario;
                txtData.Text = objPesquisa.DtNascUsuario;
                if (objPesquisa.TipoUsuario_IdTipoUsuario == "1")
                {
                    lblTpUsuario.Text = "Administrador";
                }
                else
                {
                    lblTpUsuario.Text = "Outros";
                }

                pcb1.ImageLocation = objPesquisa.UrlImagemUsuario;

            }
            else
            {
                MessageBox.Show("Não rolou a busca!! ");

                return;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
