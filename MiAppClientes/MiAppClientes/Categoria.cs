using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiAppClientes
{
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 FormP = new Form1();
            FormP.Show();
            Categoria categoria = new Categoria();
            categoria.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategoriaMetodos pCategoria = new CategoriaMetodos();
            pCategoria.Nombre = txtNombreCategoria.Text.Trim();

            int resultado = CategoriaCone.Agregar(pCategoria);
            if (resultado > 0)
            {
                MessageBox.Show("Categoria Guardada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
