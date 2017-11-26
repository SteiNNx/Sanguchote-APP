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
using DataAccesSQL;

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
            if (Util.data!=null)
            {
                llenarGrid();
            }
            else { lbl_total.Text = ""; }
            
        }

        private void llenarGrid()
        {
            aux_data = Util.data;
            BindingSource bs_datos = new BindingSource();
            bs_datos.DataSource = aux_data;
            dgv_pedido.DataSource = bs_datos;
            lbl_total.Text = precioTotal().ToString();
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
            pb_producto.ImageLocation= pro.Url_imagen;
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

                foreach (DataGridViewRow item in dgv_pedido.Rows)
                {
                    if (Convert.ToInt32(item.Cells[0].Value) == Convert.ToInt32(cbb_producto.SelectedValue))
                    {
                        item.Cells[0].Value = cbb_producto.SelectedValue;
                        item.Cells[1].Value = cbb_producto.Text;
                        item.Cells[2].Value = lbl_precio.Text;
                        item.Cells[3].Value = Convert.ToInt32(ccb_cantidad.Text) + Convert.ToInt32(item.Cells[3].Value);
                        return;
                    }
                }
                dr["ID"] =cbb_producto.SelectedValue;
                dr["Nombre"] =cbb_producto.Text;
                dr["Precio"] =lbl_precio.Text;
                dr["Cantidad"] =ccb_cantidad.Text;
                aux_data.Rows.Add(dr);
                Util.data = aux_data;
                BindingSource bs_datos = new BindingSource();
                bs_datos.DataSource = aux_data;
                dgv_pedido.DataSource = bs_datos;
                lbl_total.Text = precioTotal().ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_pedido.Rows.Count!=0)
                {
                    CL_Compra comp = new CL_Compra();
                    comp.Usuario = Util.usuario;
                    comp.Fecha_compra = DateTime.Now.ToString("yyyy/MM/dd");
                    int precio = precioTotal();
                    comp.Total_Pago = precio;
                    string xmlCompra = Util.SerializeCompra<CL_Compra>(comp);
                    MessageBox.Show(xmlCompra);
                    bool resp = serv.insertarCompra(xmlCompra);
                    if (resp)
                    {
                        List<CL_DetalleCompra> listaDetalle = new List<CL_DetalleCompra>();
                        foreach (DataGridViewRow item in dgv_pedido.Rows)
                        {
                            if (Convert.ToInt32(item.Cells[0].Value) != 0)
                            {
                                CL_DetalleCompra det = new CL_DetalleCompra();
                                CL_Producto pro = new CL_Producto();
                                pro.Id_producto = Convert.ToInt32(item.Cells[0].Value);
                                det.Producto = pro;
                                det.Cantidad = Convert.ToInt32(item.Cells[3].Value);
                                listaDetalle.Add(det);
                            }
                        }

                        foreach (CL_DetalleCompra item2 in listaDetalle)
                        {
                            string xmlDetalle = Util.SerializeDetalleCompra<CL_DetalleCompra>(item2);
                            serv.insertarDetalleCompra(xmlDetalle);
                        }
                        CL_RegistrarVentas registrarVentas = new CL_RegistrarVentas();
                        registrarVentas.id_compra = new DAO_Compra().maxIdCompra();
                        registrarVentas.total = precioTotal();
                        registrarVentas.propitna = Convert.ToInt32(Math.Round((precioTotal() * 0.10), 0));
                        string xmlRegistroCompra = Util.SerializeRegistrarVentas<CL_RegistrarVentas>(registrarVentas);
                        serv.insertarRegistrarVentas(xmlRegistroCompra);
                        lbl_mensaje.Text = "Pedido Exitoso";
                        Util.data = null;

                    }
                    else
                    {
                        lbl_mensaje.Text = "Pedido no Exitoso, Intentelo Mas Tarde";
                    }
                }
                else
                {
                    lbl_mensaje.Text = "Ingrese Productos Al Carrito";
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private int precioTotal()
        {
            int precio = 0;
            foreach (DataGridViewRow item in dgv_pedido.Rows)
            {
                precio += Convert.ToInt32(item.Cells[2].Value) * Convert.ToInt32(item.Cells[3].Value);
            }
            return precio;
        }
    }
}
