using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace MiAppClientes
{
    public class ConexionBD
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=clientes; Uid=root; pwd=GILGAMESH117;");

            conectar.Open();
            return conectar;
        }
    }
}
