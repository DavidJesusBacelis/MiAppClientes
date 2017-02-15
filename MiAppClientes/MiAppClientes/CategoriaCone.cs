using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MiAppClientes
{
    class CategoriaCone

    {

        public static int Agregar(CategoriaMetodos pCategoria)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into categorias (nombre) values ('{0}')",
                pCategoria.Nombre), ConexionBD.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }


        public ArrayList getColumnas(String categorias)
        {
            MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; database=clientes; Uid=root; pwd=GILGAMESH117;");
            MySqlCommand cm = new MySqlCommand("SELECT * FROM " + categorias + " LIMIT 0,0", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(cm);
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            ArrayList columnas = new ArrayList();
            for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
            {
                columnas.Add(ds.Tables[0].Columns[i].ColumnName);
            }
            return columnas;
        }

    }
}
