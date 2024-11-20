using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variedades_Man_s_Style
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();

            llenarCOMBOBOX();
        }

        ProductoMCN MetodosProducto = new ProductoMCN();
        CategoriaMCN MetodosCategoria = new CategoriaMCN();
        SucursalMCN MetodosSucursal = new SucursalMCN();

        private void btn_WF_CerrarProveedor_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel_InfoProductos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt_BuscarProveedor_TextChanged(object sender, EventArgs e)
        {
            //txt_BuscarProveedor.Enabled = false;
        }

        private void llenarCOMBOBOX()
        {
            var sucursales = MetodosSucursal.ObtenerSucursales();
            cbox_Sucursal.DataSource = sucursales;
            cbox_Sucursal.DisplayMember = "Nombre";
            cbox_Sucursal.ValueMember = "ID_Sucursal";

            var categorias = MetodosCategoria.ObtenerCategorias();
            cbox_Categoria.DataSource = categorias;
            cbox_Categoria.DisplayMember = "Nombre";
            cbox_Categoria.ValueMember = "ID_Categoria";

        }

        private void cbox_Sucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // DESACTIVMOS LA ENTRADA POR EL TECLADO PARA LA COMBOBOX
        }

        private void cbox_Categoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // DESACTIVMOS LA ENTRADA POR EL TECLADO PARA LA COMBOBOX

        }

        /*private void cbox_Sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void cbox_Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {



        }*/
    }
}
