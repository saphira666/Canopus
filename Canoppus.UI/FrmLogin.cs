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

namespace Canoppus.UI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                //pegando informação digitada pelo usuario
                string objUsuario = txtUsuario.Text;
                string objSenha = txtSenha.Text;

                //instanciando objeto DTO
                UsuarioAutenticaDTO objModelo = new UsuarioAutenticaDTO();
                UsuarioBLL objValida = new UsuarioBLL();
                objModelo = objValida.AutenticaUsuario(objUsuario, objSenha);
                if (objModelo != null)
                {
                    switch (objModelo.TipoTipoUsuario_IdTipoUsuario)
                    {
                        case "1":
                            Session.nomeUsuario = txtUsuario.Text.Trim();
                            MDIAdm obj = new MDIAdm();
                            obj.Show();
                            this.Visible = false;   
                            break;
                        case "2":
                            Session.nomeUsuario = txtUsuario.Text.Trim();
                            MDIOutros obj2 = new MDIOutros();
                            obj2.Show();
                            this.Visible = false;
                            break;

                    }
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Usuario não cadastrado!! " + ex.Message);
            }
        }
    }
}
