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
    public partial class frm_Pedido : Form
    {
        ServiceReference1.Service1Client serv = new ServiceReference1.Service1Client();
        DataTable aux_data;
        public frm_Pedido()
        {
            InitializeComponent();

            llenarCombobox();
            llenarCampos();
        }

        private void llenarCampos()
        {
            CL_Producto pro;
            if (cbb_producto.SelectedIndex==0)
            {
                pro = serv.listaProductos().Where(x => x.Nombre_producto == "Completo Normal").First();
            }
            else
            {
                pro = serv.listaProductos().Where(x => x.Nombre_producto == cbb_producto.Text).First();
            }

            lbl_precio.Text = pro.Precio.ToString();
            lbl_stock.Text = pro.Stock.ToString();
            var dicCantidad = new Dictionary<int, string>();
            for (int i = 1; i < Convert.ToInt32(lbl_stock.Text) + 1; i++)
            {
                dicCantidad.Add(i, Convert.ToString(i));
            }
            ccb_cantidad.DataSource = new BindingSource(dicCantidad, null);
            ccb_cantidad.DisplayMember = "Value";
            ccb_cantidad.ValueMember = "Key";
        }

        private void llenarCombobox()
        {
            var dicProducto = new Dictionary<int, string>();
            foreach (CL_Producto tip in serv.listaProductos())
            {
                dicProducto.Add(tip.Id_producto, tip.Nombre_producto);
            }
            cbb_producto.DataSource = new BindingSource(dicProducto, null);
            cbb_producto.DisplayMember = "Value";
            cbb_producto.ValueMember = "Key"; 
        }

        private void cbb_producto_SelectedIndexChanged(object sender, EventArgs e)
        {

            llenarCampos();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Util.data==null)
                {
                    aux_data = new DataTable();
                    aux_data.Columns.Add("ID");
                    aux_data.Columns.Add("Nombre");
                    aux_data.Columns.Add("Precio");
                    aux_data.Columns.Add("Cantidad");
                }
                else
                {
                    aux_data = Util.data;
                }
                DataRow dr = aux_data.NewRow();
                dr["ID"] =cbb_producto.SelectedValue;
                dr["Nombre"] =cbb_producto.Text;
                dr["Precio"] =lbl_precio.Text;
                dr["Cantidad"] =ccb_cantidad.Text;
                aux_data.Rows.Add(dr);
                Util.data = aux_data;
                BindingSource bs_datos = new BindingSource();
                bs_datos.DataSource = aux_data;
                dgv_pedido.DataSource = bs_datos;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
