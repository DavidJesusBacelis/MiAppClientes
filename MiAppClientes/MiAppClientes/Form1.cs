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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectCat_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCrearCat_Click(object sender, EventArgs e)
        {
            
            Categoria categoria = new Categoria();
            categoria.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            cliente.Show();
        }
    }
}
