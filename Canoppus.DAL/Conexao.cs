using MySql.Data.MySqlClient;// inserido manualmente
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canoppus.DAL
{
    public class Conexao
    {
        //variaveis
        protected MySqlConnection conn;
        protected MySqlCommand cmd;
        protected MySqlDataReader dr;

        //métodos
        public void Conectar() 
        {
            try
            {
                conn = new MySqlConnection("Data Source = localhost ; Initial Catalog = CanoppusDB ; uid = root ");
                conn.Open();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        
        }

        public void Desconectar()
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    }
}
