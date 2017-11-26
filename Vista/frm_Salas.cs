using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Model;

namespace Vista
{
    public partial class frm_Salas : Form
    {
        ServiceReference1.Service1Client serv = new ServiceReference1.Service1Client();
        DataTable aux_data;

        public frm_Salas()
        {
            InitializeComponent();
            llenarCombobox();
            if (Util.dataSala != null)
            {
                llenarGrid();
            }
        }

        private void llenarGrid()
        {
            aux_data = Util.dataSala;
            BindingSource bs_datos = new BindingSource();
            bs_datos.DataSource = aux_data;
            dgv_pedidos.DataSource = bs_datos;
        }

        private void llenarCombobox()
        {
            var dicSalas = new Dictionary<string, string>();
            dicSalas.Add("Sala 1", "Sala 1");
            dicSalas.Add("Sala 2", "Sala 2");
            dicSalas.Add("Sala 3", "Sala 3");
            cbb_sala.DataSource = new BindingSource(dicSalas, null);
            cbb_sala.DisplayMember = "Value";
            cbb_sala.ValueMember = "Key";
        }

        private void btn_pedido_Click(object sender, EventArgs e)
        {

        }
    }
}
