using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiAppClientes
{
    class validar
    {
        public static void SoloNumeros(KeyPressEventArgs pE)
        {
            string especial = System.Convert.ToString(pE.KeyChar);

            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (especial.Equals("-"))
            {
                pE.Handled = false;
            }
            else if (especial.Equals("."))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }
    }
}
