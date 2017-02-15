using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiAppClientes
{
    class CategoriaMetodos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
       
        public CategoriaMetodos() { }

        public CategoriaMetodos(int pId, string pNombre)
             
        {
            this.Id = pId;
            this.Nombre = pNombre;
        
        }

    }
}
