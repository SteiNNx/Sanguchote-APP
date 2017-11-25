using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
        }


        private void LlamarMenuCRUD(string nombreBoton)
        {
            /*Panel_Datos.Controls.Clear();
            MenuCRUD menu = new MenuCRUD(nombreBoton)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill

            };
            Panel_Datos.Controls.Add(menu);
            menu.Show();*/
        }

        private void btn_pedido_Click(object sender, EventArgs e)
        {
            Panel_Datos.Controls.Clear();
            frm_Pedido ped = new frm_Pedido();
            ped.TopLevel = false;
            Panel_Datos.Controls.Add(ped);
            ped.Show();
        }
    }
}
