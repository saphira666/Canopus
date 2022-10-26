using Canoppus.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canoppus.DAL
{
    public class TarefaDAL:Conexao
    {
        //cadastrar
    public void Cadastrar(TarefaDTO obj)
        {
            try
            {
                Conectar();
                cmd = new MySqlCommand("INSERT INTO Tarefa (nomeTarefa,descricaoTarefa,prazoTarefa,statusTarefa,responsavelTarefaIdUsuario) VALUES (@v1,@v2,@v3,@v4,@v5)", conn);
                cmd.Parameters.AddWithValue("@v1", obj.nomeTarefa);
                cmd.Parameters.AddWithValue("@v2", obj.descricaoTarefa);
                cmd.Parameters.AddWithValue("@v3", obj.prazoTarefa);
                cmd.Parameters.AddWithValue("@v4", obj.statusTarefa);
                cmd.Parameters.AddWithValue("@v5", obj.responsavelTarefaIdUsuario);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao cadastrar !!" + ex.Message);

            }
            finally
            {
                Desconectar();
            }

        }

        //carrega cBox
        public List<UsuarioDTO> ListarT()
        {
            try
            {
                Conectar();
                cmd = new MySqlCommand("SELECT IdUsuario,NomeUsuario FROM Usuario", conn);
                dr = cmd.ExecuteReader();
                List<UsuarioDTO> Lista = new List<UsuarioDTO>(); // lista vazia
                while (dr.Read())
                {
                    UsuarioDTO obj = new UsuarioDTO();
                    obj.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    obj.NomeUsuario = dr["NomeUsuario"].ToString();
                    Lista.Add(obj);

                }
                return Lista;

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao listar !!" + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }


    }
}
