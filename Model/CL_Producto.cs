using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CL_Producto
    {
        public int Id_producto { get; set; }
        public string Nombre_producto { get; set; }
        public int Stock { get; set; }
        public string Url_imagen { get; set; }
        public int Precio { get; set; }
        public CL_Producto()
        {

        }
    }
}
