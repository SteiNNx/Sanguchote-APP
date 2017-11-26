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
            insertarPanel(new frm_Pedido());
        }

        private void btn_pedido_Click(object sender, EventArgs e)
        {
            insertarPanel(new frm_Salas());
        }

        private void insertarPanel(Form nuevo_forms)
        {
            Panel_Datos.Controls.Clear();
            nuevo_forms.TopLevel = false;
            Panel_Datos.Controls.Add(nuevo_forms);
            nuevo_forms.Show();
        }

        private void btn_compras_Click(object sender, EventArgs e)
        {
            insertarPanel(new frm_ListarCompra());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertarPanel(new frm_ListarComprasOracle());
        }
    }
}
