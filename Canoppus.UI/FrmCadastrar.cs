using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Canoppus.DTO;
using Canoppus.BLL;
using System.IO;
using Canoppus.UI.Utilitarios;

namespace Canoppus.UI
{
    public partial class FrmCadastrar : Form
    {
        public FrmCadastrar()
        {
            InitializeComponent();
        }

        private void FrmCadastrar_Load(object sender, EventArgs e)
        {
            Limpar.ClearControl(this);
        }



        //limpar
       

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
                gb1.BackColor = DefaultBackColor;
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

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            if (ValidaForm())
            {

                UsuarioDTO objCad = new UsuarioDTO();

                objCad.NomeUsuario = txtNome.Text;
                objCad.SenhaUsuario = txtSenha.Text;


                //ajustando o cpf
                long cpf = Convert.ToInt64(txtCpf.Text);
                objCad.CpfUsuario = cpf.ToString(@"000\.000\.000\-00");



                //ajustando a data
                DateTime dt = DateTime.Parse(txtData.Text);
                objCad.DtNascUsuario = dt.ToString("yyyy/MM/dd");


                //salvando a URL da imagem
                string nomeImg = txtNome.Text + ".jpg";
                string pasta = @"C:\Users\wil.rrsilva\source\repos\Canoppus\Canoppus.UI\Imagens\";
                string caminhoImg = Path.Combine(pasta, nomeImg);
                objCad.UrlImagemUsuario = caminhoImg;

                //salvando na pasta
                Image a = pcb1.Image;
                a.Save(caminhoImg);


                //checando tipo de usuario
                if (rb1.Checked)
                {
                    objCad.TipoUsuario_IdTipoUsuario = "1";
                }
                else if (rb2.Checked)
                {
                    objCad.TipoUsuario_IdTipoUsuario = "2";
                }

                UsuarioBLL objCadastra = new UsuarioBLL();
                objCadastra.CadastrarUsuario(objCad);
                Limpar.ClearControl(this);

                MessageBox.Show("Usuário " + objCad.NomeUsuario + " cadastrado com sucesso!!");
            }
        }

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar.ClearControl(this);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
           this.Close();
        }

       
    }
}
