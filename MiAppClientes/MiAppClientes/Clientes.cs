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

namespace MiAppClientes
{
    public partial class Clientes : Form
    {

        CategoriaCone cate = new CategoriaCone();

        private ClientesConexion ClienteActual;

        public Clientes()
        {
            InitializeComponent();
            ClientesConexion.InitializeDB();
        }

        private void LoadAll()
        {
            List<ClientesConexion> users = ClientesConexion.GetUsers();

            lvUsers.Items.Clear();

            foreach (ClientesConexion u in users)
            {

                ListViewItem item = new ListViewItem(new String[] { u.Id.ToString(), u.Nombre, u.Apellidos, u.Telefono.ToString(), u.Correo });
                item.Tag = u;

                lvUsers.Items.Add(item);

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void btnAgregarClie_Click(object sender, EventArgs e)
        {
            try
            {
                int cate = (int)cbxCategoria.SelectedValue;

                String N = txtNombre.Text;
                String A = txtApellido.Text;
                int T = int.Parse(txtTelefono.Text);
                String C = txtCorreo.Text;

                if (String.IsNullOrEmpty(N) || String.IsNullOrEmpty(A) || String.IsNullOrEmpty(C))
                {
                    MessageBox.Show("Por favor, introduzca valores, los campos no pueden estar vacios.");
                    return;
                }
                else
                {
                    MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtCorreo.Clear();
                    txtTelefono.Clear();
                }

                ClienteActual = ClientesConexion.Insert(N, A, T, C);

                LoadAll();
            }
            catch (System.OverflowException)
            {
                
            }
        }

        private void btnMostrarClie_Click(object sender, EventArgs e)
        {
            {
                LoadAll();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditarClie_Click(object sender, EventArgs e)
        {
            String N = txtNombre.Text;
            String A = txtApellido.Text;
            int T = int.Parse(txtTelefono.Text);
            String C = txtCorreo.Text;

            if (String.IsNullOrEmpty(N) || String.IsNullOrEmpty(A) || String.IsNullOrEmpty(C))
            {
                MessageBox.Show("Seleccione un usuario para actualizar sus datos.");
                return;
            }
            else
            {
                MessageBox.Show("Cliente Modificado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Clear();
                txtApellido.Clear();
                txtCorreo.Clear();
                txtTelefono.Clear();
            }

            ClienteActual.Update(N, A, T, C);

            LoadAll();
        }

        private void btnEliminarClie_Click(object sender, EventArgs e)
        {
            if (ClienteActual == null)
            {
                MessageBox.Show("Por favor, seleccione un usuario para borrar.");
                return;
            }
            else
            {
                MessageBox.Show("Cliente Modificado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Clear();
                txtApellido.Clear();
                txtCorreo.Clear();
                txtTelefono.Clear();
            }

            ClienteActual.Delete();

            LoadAll();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvUsers.SelectedItems.Count > 0)
            {

                ListViewItem item = lvUsers.SelectedItems[0];
                ClienteActual = (ClientesConexion)item.Tag;

                int id = ClienteActual.Id;
                String N = ClienteActual.Nombre;
                String A = ClienteActual.Apellidos;
                int T = ClienteActual.Telefono;
                String C = ClienteActual.Correo;

                txtNombre.Text = N;
                txtApellido.Text = A;
                txtTelefono.Text = T.ToString();
                txtCorreo.Text = C;
            }
        }

        private void lvUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvUsers.SelectedItems.Count > 0)
            {
                ListViewItem item = lvUsers.SelectedItems[0];
                ClienteActual = (ClientesConexion)item.Tag;

                int id = ClienteActual.Id;
                String N = ClienteActual.Nombre;
                String A = ClienteActual.Apellidos;
                int T = ClienteActual.Telefono;
                String C = ClienteActual.Correo;

                txtNombre.Text = N;
                txtApellido.Text = A;
                txtTelefono.Text = T.ToString();
                txtCorreo.Text = C;


            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
