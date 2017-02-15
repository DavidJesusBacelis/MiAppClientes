using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MiAppClientes
{
    class ClientesConexion
    {
        //database stuff
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "clientes";
        private const String UID = "root";
        private const String PASSWORD = "GILGAMESH117";
        private static MySqlConnection dbConn;

        // User class stuff
        public int Id { get; private set; }

        public String Nombre { get; private set; }

        public String Apellidos { get; private set; }

        public int Telefono { get; private set; }

        public String Correo { get; private set; }

        private ClientesConexion(int id, String N, String A, int T, String C)
        {
            Id = id;
            Nombre = N;
            Apellidos = A;
            Telefono = T;
            Correo = C;
        }

        public static void InitializeDB()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.UserID = UID;
            builder.Password = PASSWORD;
            builder.Database = DATABASE;

            String connString = builder.ToString();

            builder = null;

            Console.WriteLine(connString);

            dbConn = new MySqlConnection(connString);

            Application.ApplicationExit += (sender, args) => {
                if (dbConn != null)
                {
                    dbConn.Dispose();
                    dbConn = null;
                }
            };
        }

        public static List<ClientesConexion> GetUsers()
        {
            List<ClientesConexion> client = new List<ClientesConexion>();

            String query = "SELECT * FROM cliente";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["id"];
                String Nombre = reader["nombre"].ToString();
                String Apellidos = reader["apellidos"].ToString();
                int Telefono = (int)reader["telefono"];
                String Correo = reader["correo_electronico"].ToString();
                ClientesConexion Clie = new ClientesConexion(id, Nombre, Apellidos, Telefono, Correo);

                client.Add(Clie);
            }

            reader.Close();

            dbConn.Close();

            return client;
        }

        public static ClientesConexion Insert(String N, String A, int T, String C)
        {
            String query = string.Format("INSERT INTO cliente(nombre, apellidos, telefono, correo_electronico) VALUES ('{0}', '{1}', '{2}', '{3}')", N, A, T, C);

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            cmd.ExecuteNonQuery();
            int id = (int)cmd.LastInsertedId;

            ClientesConexion user = new ClientesConexion(id, N, A, T, C);

            dbConn.Close();

            return user;

        }
        public void Update(string N, string A, int T, string C)
        {
            String query = string.Format("UPDATE cliente SET nombre='{0}', apellidos='{1}', telefono='{2}', correo_electronico='{3}'  WHERE Id={4}", N, A, T, C, Id);

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            cmd.ExecuteNonQuery();

            dbConn.Close();
        }

        public void Delete()
        {
            String query = string.Format("DELETE FROM cliente WHERE ID={0}", Id);

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            cmd.ExecuteNonQuery();

            dbConn.Close();
        }
    }
}
