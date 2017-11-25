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
    public partial class frm_ListarCompra : Form
    {
        ServiceReference1.Service1Client serv = new ServiceReference1.Service1Client();
        BindingSource bs_datos = new BindingSource(); BindingSource bs_datos2 = new BindingSource();


        public frm_ListarCompra()
        {
            InitializeComponent();
            LlenarGridCompra();
            dgv_listadoCompras.DataSource = bs_datos;
            DataGridViewButtonColumn btnDetalle = new DataGridViewButtonColumn();
            dgv_listadoCompras.Columns.Add(btnDetalle);
            btnDetalle.HeaderText = "Detalle";
            btnDetalle.Text = "Detalle";
            btnDetalle.Name = "btnDetalle";
            btnDetalle.UseColumnTextForButtonValue = true;
            dgv_listadoDetalleCompra.DataSource = bs_datos2;
        }

        private void LlenarGridCompra()
        {
            DataTable aux_tab_compra = new DataTable();
            aux_tab_compra.Columns.Add("ID");
            aux_tab_compra.Columns.Add("Nombre Usuario");
            aux_tab_compra.Columns.Add("Fecha Compra");
            aux_tab_compra.Columns.Add("Total Pago");
            foreach (CL_Compra item in serv.listaCompras())
            {
                var values = new object[aux_tab_compra.Columns.Count];
                for (int i = 0; i < aux_tab_compra.Columns.Count; i++)
                {
                    String nom_column = "";
                    if (aux_tab_compra.Columns[i].ColumnName.Equals("ID")) { nom_column = item.Id_compra.ToString(); }
                    if (aux_tab_compra.Columns[i].ColumnName.Equals("Nombre Usuario")) { nom_column = item.Usuario.Nombre + " " + item.Usuario.Apellido; }
                    if (aux_tab_compra.Columns[i].ColumnName.Equals("Fecha Compra")) { nom_column = item.Fecha_compra; }
                    if (aux_tab_compra.Columns[i].ColumnName.Equals("Total Pago")) { nom_column = item.Total_Pago.ToString(); }
                    aux_tab_compra.Columns[i].ReadOnly = true;
                    values[i] = nom_column;
                }
                aux_tab_compra.Rows.Add(values);
            }
            bs_datos.DataSource = aux_tab_compra;
        }

        private void dgv_listadoCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (dgv_listadoCompras.Rows[e.RowIndex].Cells[1].Value.ToString() != "")
                {
                    int id = Convert.ToInt32(dgv_listadoCompras.Rows[e.RowIndex].Cells[1].Value.ToString());
                    LlenarGridDetalleCompra(id);
                }
            }
        }

        private void LlenarGridDetalleCompra(int id)
        {
            DataTable aux_tab_det = new DataTable();
            aux_tab_det.Columns.Add("Producto");
            aux_tab_det.Columns.Add("Precio");
            aux_tab_det.Columns.Add("Cantidad");
            foreach (CL_DetalleCompra item in serv.listaDetalleCompraXIdCompra(id))
            {
                var values = new object[aux_tab_det.Columns.Count];
                for (int i = 0; i < aux_tab_det.Columns.Count; i++)
                {
                    String nom_column = "";
                    if (aux_tab_det.Columns[i].ColumnName.Equals("Producto")) { nom_column = item.Producto.Nombre_producto; }
                    if (aux_tab_det.Columns[i].ColumnName.Equals("Precio")) { nom_column = item.Producto.Precio.ToString(); }
                    if (aux_tab_det.Columns[i].ColumnName.Equals("Cantidad")) { nom_column = item.Cantidad.ToString(); }
                    aux_tab_det.Columns[i].ReadOnly = true;
                    values[i] = nom_column;
                }
                aux_tab_det.Rows.Add(values);

            }
            bs_datos2.DataSource = aux_tab_det;
        }
    }
}

