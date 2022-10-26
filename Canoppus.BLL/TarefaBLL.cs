using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Canoppus.DAL;
using Canoppus.DTO;

namespace Canoppus.BLL
{
    public class TarefaBLL
    {
        TarefaDAL objBLL = new TarefaDAL();
        //cadastrar tarefa
        public void cadastraTarefa(TarefaDTO objCad)
        {
            objBLL.Cadastrar(objCad);
        }

        //cBox
        public List<UsuarioDTO> ListarUsuario()
        {
            return objBLL.ListarT();
        }


    }
}
