using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Canoppus.DTO;//
using MySql.Data.MySqlClient;//


namespace Canoppus.DAL
{
    public class UsuarioDAL:Conexao
    {
        //cadastrar
        public void Cadastrar(UsuarioDTO objCad) 
        {
            try
            {
                Conectar();
                cmd = new MySqlCommand("INSERT INTO Usuario (NomeUsuario,SenhaUsuario,CpfUsuario,DtNascUsuario,UrlImagemUsuario,TipoUsuario_IdTipoUsuario) VALUES (@v1,@v2,@v3,@v4,@v5,@v6)", conn);
                cmd.Parameters.AddWithValue("@v1", objCad.NomeUsuario);
                cmd.Parameters.AddWithValue("@v2", objCad.SenhaUsuario);
                cmd.Parameters.AddWithValue("@v3", objCad.CpfUsuario);
                cmd.Parameters.AddWithValue("@v4", objCad.DtNascUsuario);
                cmd.Parameters.AddWithValue("@v5", objCad.UrlImagemUsuario);
                cmd.Parameters.AddWithValue("@v6", objCad.TipoUsuario_IdTipoUsuario);
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


        //excluir
        public void Excluir(int objDel)
        {
            try
            {
                Conectar();
                cmd = new MySqlCommand("DELETE FROM Usuario WHERE IdUsuario = @v1",conn);
                cmd.Parameters.AddWithValue("@v1",objDel);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao excluir registro !!" + ex.Message);
            }
            finally
            {
                Desconectar();
            }

        }


        //editar
        public void Editar(UsuarioDTO objUpdate)
        {
            try
            {
                Conectar();
                cmd = new MySqlCommand("UPDATE Usuario SET NomeUsuario=@v2, SenhaUsuario=@v3, CpfUsuario=@v4, DtNascUsuario=@v5, UrlImagemUsuario=@v6, TipoUsuario_IdTipoUsuario=@v7 WHERE IdUsuario=@v1", conn);
                cmd.Parameters.AddWithValue("@v2", objUpdate.NomeUsuario);
                cmd.Parameters.AddWithValue("@v3", objUpdate.SenhaUsuario);
                cmd.Parameters.AddWithValue("@v4", objUpdate.CpfUsuario);
                cmd.Parameters.AddWithValue("@v5", objUpdate.DtNascUsuario);
                cmd.Parameters.AddWithValue("@v6", objUpdate.UrlImagemUsuario);
                cmd.Parameters.AddWithValue("@v7", objUpdate.TipoUsuario_IdTipoUsuario);
                cmd.Parameters.AddWithValue("@v1", objUpdate.IdUsuario);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao editar o registro !!" + ex.Message);
            }
            finally 
            {
                Desconectar();
            }
        
        }


        //listar
        public List<UsuarioListDTO> Listar() 
        {
            try
            {
                Conectar();
                cmd= new MySqlCommand("SELECT IdUsuario, NomeUsuario, SenhaUsuario,CpfUsuario,DtNascUsuario,UrlImagemUsuario,DescricaoTipoUsuario FROM Usuario JOIN TipoUsuario on TipoUsuario_IdTipoUsuario = IdTipoUsuario", conn);
                dr = cmd.ExecuteReader();
                List<UsuarioListDTO> Lista = new List<UsuarioListDTO>(); // lista vazia
                while (dr.Read())
                {
                    UsuarioListDTO obj = new UsuarioListDTO();
                    obj.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    obj.NomeUsuario = dr["NomeUsuario"].ToString();
                    obj.SenhaUsuario = dr["SenhaUsuario"].ToString();
                    obj.CpfUsuario = dr["CpfUsuario"].ToString();
                    obj.DtNascUsuario = dr["DtNascUsuario"].ToString();
                    obj.UrlImagemUsuario = dr["UrlImagemUsuario"].ToString();
                    obj.DescricaoTipoUsuario = dr["DescricaoTipoUsuario"].ToString();
                    Lista.Add(obj);

                }
                return Lista;

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao listar !!"+ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }


        //autenticar
        public UsuarioAutenticaDTO Autentica(string objNome, string objSenha)
        {
            try
            {
                Conectar();
                cmd = new MySqlCommand("SELECT NomeUsuario, SenhaUsuario, TipoUsuario_IdTipoUsuario FROM Usuario WHERE NomeUsuario=@v2 AND SenhaUsuario=@v3", conn);
                cmd.Parameters.AddWithValue("v2", objNome);
                cmd.Parameters.AddWithValue("v3", objSenha);
                dr = cmd.ExecuteReader();

                UsuarioAutenticaDTO obj = null;
                if (dr.Read())
                {
                    obj = new UsuarioAutenticaDTO();
                    obj.NomeUsuario = dr["NomeUsuario"].ToString();
                    obj.SenhaUsuario = dr["SenhaUsuario"].ToString();
                    obj.TipoTipoUsuario_IdTipoUsuario = dr["TipoUsuario_IdTipoUsuario"].ToString();
                }
                return obj;
            }
            catch (Exception ex)
            {

                throw new Exception("Usuario não cadastrado !!"+ex.Message);
            }
            finally 
            {
                Desconectar();
            }

        }


        //pesquisar
        public UsuarioDTO SelecionabyId(int objSeleciona) 
        {
            try
            {
                Conectar();
                cmd = new MySqlCommand("SELECT * FROM Usuario WHERE IdUsuario=@v7", conn);
                cmd.Parameters.AddWithValue("@v7", objSeleciona);
                dr = cmd.ExecuteReader();

                UsuarioDTO obj = null;

                if (dr.Read())
                {
                    obj = new UsuarioDTO();
                    obj.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    obj.NomeUsuario = dr["NomeUsuario"].ToString();
                    obj.SenhaUsuario = dr["SenhaUsuario"].ToString();
                    obj.CpfUsuario = dr["CpfUsuario"].ToString();
                    obj.DtNascUsuario = dr["DtNascUsuario"].ToString();
                    obj.UrlImagemUsuario = dr["UrlImagemUsuario"].ToString();
                    obj.TipoUsuario_IdTipoUsuario = dr["TipoUsuario_IdTipoUsuario"].ToString();
                }
                return obj;

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao selecionar !!"+ex.Message);
            }
        
        }

    }
}
