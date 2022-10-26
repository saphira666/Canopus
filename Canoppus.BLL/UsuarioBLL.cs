using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Canoppus.DAL;
using Canoppus.DTO;

namespace Canoppus.BLL
{
    public class UsuarioBLL
    {
        UsuarioDAL objBLL = new UsuarioDAL();

        //cadastrar BLL
        public void CadastrarUsuario(UsuarioDTO objCadUser) 
        {
            objBLL.Cadastrar(objCadUser);
        }

        //autenticar
        public UsuarioAutenticaDTO AutenticaUsuario(string objNome, string objSenha) 
        {
            UsuarioAutenticaDTO user = objBLL.Autentica(objNome, objSenha);

            if (user != null)
            {
                return user;
            }
            else
            {
                throw new Exception("Deu problema!!");
            }

        }


        //selecionar
        public UsuarioDTO SelecionaUsuario(int objModelo)
        {
            return objBLL.SelecionabyId(objModelo);
        }


        //editar
        public void EditaUsuario(UsuarioDTO objModelo)
        {
            objBLL.Editar(objModelo);
        }


        //excluir
        public void ExcluirUsuario(int objExclui) 
        {
            objBLL.Excluir(objExclui);
        }


        //listar
        public List<UsuarioListDTO> ListarUsuario()
        {
            return objBLL.Listar();
        }

    }
}
