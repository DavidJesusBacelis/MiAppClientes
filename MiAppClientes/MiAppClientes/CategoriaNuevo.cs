using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace MiAppClientes
{
    class CategoriaNuevo
    {
        
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=clientes; Uid=root; pwd=GILGAMESH117;");

        public void llenarCombo(ComboBox combo)
        {
            MySqlCommand cate = new MySqlCommand("SELECT id, nombre FROM categoria ORDER BY id", conectar);
            MySqlDataAdapter es = new MySqlDataAdapter(cate);
            DataTable dt = new DataTable();
            es.Fill(dt);

            combo.ValueMember = "id";
            combo.DisplayMember = "nombre";
            combo.DataSource = dt;
        }
    }
    
}
