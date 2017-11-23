using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CL_Compra
    {
        public int Id_compra{ get; set; }
        public CL_Usuario Usuario{ get; set; }
        public string Fecha_compra { get; set; }
        public int Total_Pago { get; set; }

        public CL_Compra()
        {

        }
    }
}
