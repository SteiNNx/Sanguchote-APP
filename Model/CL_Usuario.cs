using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CL_Usuario
    {
        public int Id_usuario { get; set; }
        public string User_ { get; set; }
        public string Password{ get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Tipo_Usuario { get; set; }

        public CL_Usuario()
        {

        }
    }
}
