using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canoppus.DTO
{
    public class UsuarioListDTO
    {
        //propriedades da classe
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        public string CpfUsuario { get; set; }
        public string DtNascUsuario { get; set; }
        public string UrlImagemUsuario { get; set; }
        public string DescricaoTipoUsuario { get; set; }
    }
}
