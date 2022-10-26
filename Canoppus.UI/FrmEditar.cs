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
    public partial class FrmEditar : Form
    {
        public FrmEditar()
        {
            InitializeComponent();
        }

        private void FrmEditar_Load(object sender, EventArgs e)
        {
           gpPrincipal.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Digita um Id !!", "Atenção", MessageBoxButtons.OK);
                txtId.Focus();
                return;

            }

            //layout

            btnEditar.Enabled = true;

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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gpPrincipal.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar.ClearControl(this);
        }


       
        private bool ValidaForm()
        {
            bool FrmValido;

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                txtNome.BackColor = Color.Red;
                MessageBox.Show("Digita a porra do nome", "Se liga", MessageBoxButtons.OK);
                txtNome.BackColor = DefaultBackColor;
                txtNome.Focus();
                FrmValido = false;
            }
            else if (string.IsNullOrEmpty(txtSenha.Text))
            {
                txtSenha.BackColor = Color.Red;
                MessageBox.Show("Digita a porra da senha", "Se liga", MessageBoxButtons.OK);
                txtSenha.BackColor = DefaultBackColor;
                txtSenha.Focus();
                FrmValido = false;
            }
            else if (string.IsNullOrEmpty(txtCpf.Text) || txtCpf.Text.Length < 11)
            {
                txtCpf.BackColor = Color.Red;
                MessageBox.Show("Digita a porra do cpf", "Se liga", MessageBoxButtons.OK);
                txtCpf.BackColor = DefaultBackColor;
                txtCpf.Focus();
                FrmValido = false;
            }
            else if (string.IsNullOrEmpty(txtData.Text) || txtData.Text.Length < 10)
            {
                txtData.BackColor = Color.Red;
                MessageBox.Show("Digita a porra da data", "Se liga", MessageBoxButtons.OK);
                txtData.BackColor = DefaultBackColor;
                txtData.Focus();
                FrmValido = false;
            }
            else if (!rb1.Checked && !rb2.Checked)
            {
                gb1.BackColor = Color.Red;
                MessageBox.Show("Escolhe a porra do tipo do usuário", "Se liga", MessageBoxButtons.OK);
                gb1.BackColor = Color.DarkGray;
                gb1.Focus();
                FrmValido = false;

            }
            else if (pcb1.Image == null)
            {
                pcb1.BackColor = Color.Red;
                MessageBox.Show("Escolhe a porra da imagem", "Se liga", MessageBoxButtons.OK);
                pcb1.BackColor = DefaultBackColor;
                btnImagem.Focus();
                FrmValido = false;
            }
            else
            {
                FrmValido = true;
            }
            return FrmValido;

        }

        //carregar imagem
        private void btnImagem_Click(object sender, EventArgs e)
        {

            //carregando a imagem
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens |*.bmp;*.jpg;*.png;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string img = dialog.FileName.ToString();
                pcb1.ImageLocation = img;

            }
        }

        //btn salvar edicao
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (ValidaForm())
            {
                UsuarioDTO objPesquisa = new UsuarioDTO();//modelo
                objPesquisa.IdUsuario = Convert.ToInt32(txtId.Text);
                objPesquisa.NomeUsuario = txtNome.Text;
                objPesquisa.SenhaUsuario = txtSenha.Text;


                //ajustando o cpf
                long cpf = Convert.ToInt64(txtCpf.Text);
                objPesquisa.CpfUsuario = cpf.ToString(@"000\.000\.000\-00");



                //ajustando a data
                DateTime dt = DateTime.Parse(txtData.Text);
                objPesquisa.DtNascUsuario = dt.ToString("yyyy/MM/dd");


                //salvando a URL da imagem
                string nomeImg = txtNome.Text + ".jpg";
                string pasta = @"C:\Users\wil.rrsilva\source\repos\Canoppus\Canoppus.UI\Imagens\";
                string caminhoImg = Path.Combine(pasta, nomeImg);
                objPesquisa.UrlImagemUsuario = caminhoImg;

                //salvando na pasta
                Image a = pcb1.Image;
                a.Save(caminhoImg);


                //checando tipo de usuario
                if (rb1.Checked)
                {
                    objPesquisa.TipoUsuario_IdTipoUsuario = "1";
                }
                else if (rb2.Checked)
                {
                    objPesquisa.TipoUsuario_IdTipoUsuario = "2";
                }

                UsuarioBLL objEdita = new UsuarioBLL();
                objEdita.EditaUsuario(objPesquisa);
                Limpar.ClearControl(this);

                MessageBox.Show("Usuário " + objPesquisa.NomeUsuario + " editado com sucesso!!");
            }

        }
       
    }
}
