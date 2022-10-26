using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canoppus.DTO
{
    public class TarefaDTO
    {
        public int idTarefa { get; set; }
        public string nomeTarefa { get; set; }
        public string descricaoTarefa { get; set; }
        public string prazoTarefa { get; set; }
        public string statusTarefa { get; set; }
        public string responsavelTarefaIdUsuario { get; set; }
    }
}
