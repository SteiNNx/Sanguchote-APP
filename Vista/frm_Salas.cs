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
            DataGridViewButtonColumn btnPedido = new DataGridViewButtonColumn();
            dgv_pedidos.Columns.Add(btnPedido);
            btnPedido.HeaderText = "Pedido";
            btnPedido.Text = "Pedido";
            btnPedido.Name = "btnPedido";
            btnPedido.UseColumnTextForButtonValue = true;
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
            if (Util.dataSala == null)
            {
                aux_data = new DataTable();
                aux_data.Columns.Add("N° Sala");
                aux_data.Columns.Add("Pedido N°");
            }
            else
            {
                aux_data = Util.dataSala;
            }
            DataRow dr = aux_data.NewRow();
            dr["N° Sala"] = cbb_sala.Text;
            dr["Pedido N°"] = Util.getContador();
            aux_data.Rows.Add(dr);
            Util.dataSala = aux_data;
            BindingSource bs_datos = new BindingSource();
            bs_datos.DataSource = aux_data;
            dgv_pedidos.DataSource = bs_datos;
        }

        private void dgv_pedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (dgv_pedidos.Rows[e.RowIndex].Cells[2].Value.ToString() != "")
                {
                    int id = Convert.ToInt32(dgv_pedidos.Rows[e.RowIndex].Cells[2].Value.ToString());
                    this.Close();
                    frm_Pedido ped = new frm_Pedido();
                    ped.TopLevel = false;

                    
                    ped.Show();
                }
            }
        }
        
    }
}
