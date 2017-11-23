using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CL_DetalleCompra
    {
        public CL_Producto Producto { get; set; }
        public CL_Usuario Usuario { get; set; }
        public int Cantidad{ get; set; }

        public CL_DetalleCompra()
        {

        }
    }
}
