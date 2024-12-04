using CapaDatos;
using CapaEntidad;
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
    public partial class ProductosActualizar : Form
    {

        public delegate void ProductoActualizadoHandler(object sender, EventArgs e);

        public event ProductoActualizadoHandler ProductoActualizado;

        public ProductosActualizar()
        {
            InitializeComponent();

            llenarCOMBOBOX();
        }

        public int idProducto { get; set; }


        private bool esProductoExistente; // Variable para indicar si el producto es existente
        private int idProductoSeleccionado; // Variable para almacenar el ID del producto seleccionado

        ProductoMCN MetodosProducto = new ProductoMCN();
        CategoriaMCN MetodosCategoria = new CategoriaMCN();
        SucursalMCN MetodosSucursal = new SucursalMCN();
        Compra_EntradaMCN MetodosCompraEntrada = new Compra_EntradaMCN();



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

        private bool ValidarTextBoxesEnGrupo(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show($"Hay campos vacios, verifica por favor", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox.Focus();
                    return false;
                }
            }
            return true;
        }

        private void llenarCOMBOBOX()
        {
            var sucursales = MetodosSucursal.ObtenerSucursales();
            cbox_Sucursal.DataSource = sucursales;
            cbox_Sucursal.DisplayMember = "Nombre";
            cbox_Sucursal.ValueMember = "ID_Sucursal";

            var categorias = MetodosCategoria.ObtenerCategoriasActivas();
            cbox_Categoria.DataSource = categorias;
            cbox_Categoria.DisplayMember = "Nombre";
            cbox_Categoria.ValueMember = "ID_Categoria";

        }

        private void GuardarProducto()
        {


                ProductoDTO actuProducto = new ProductoDTO();

                actuProducto = new ProductoDTO() 
                {
                    ID_Categoria = (int)cbox_Categoria.SelectedValue,
                    ID_Sucursal = (int)cbox_Sucursal.SelectedValue,
                    ID_Producto = idProductoSeleccionado,
                    Nombre = txt_NombreProducto.Text,
                    Marca = txt_Marca.Text,
                    Cantidad = string.IsNullOrEmpty(txt_CandtidadProducto.Text) ? (int?)null : int.Parse(txt_CandtidadProducto.Text),
                    Precio_Compra = string.IsNullOrEmpty(txt_PrecioCompra.Text) ? (decimal?)null : decimal.Parse(txt_PrecioCompra.Text),
                    Precio_Producto = string.IsNullOrEmpty(txt_PrecioProducto.Text) ? (decimal?)null : decimal.Parse(txt_PrecioProducto.Text),
                    Detalles = txt_Detalles.Text,

                };

                int resulPRO = MetodosProducto.ActulizarProducto(actuProducto);

                if (resulPRO != -1)
                {

                    MessageBox.Show($" Actualizado hecho papa");
                    ProductoActualizado?.Invoke(this, EventArgs.Empty);

                    this.Close();

            }
                else
                {
                    MessageBox.Show($" No Actualizado no hecho pipipi");

                }



        }

        private void cbox_Sucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // DESACTIVMOS LA ENTRADA POR EL TECLADO PARA LA COMBOBOX
        }

        private void cbox_Categoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // DESACTIVMOS LA ENTRADA POR EL TECLADO PARA LA COMBOBOX

        }

        private void btn_AgregarProducto_Click(object sender, EventArgs e)
        {
            GuardarProducto();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FormBuscarProducto_ProductoSeleccionado(int idProducto)
        {

            // Cargar los detalles del producto seleccionado y realizar el proceso de registro

            var producto = MetodosProducto.BuscarPorID(idProducto);

            if (producto != null)
            {

                idProductoSeleccionado = idProducto; // Almacenar el ID del producto seleccionado

                esProductoExistente = true; // El producto es existente
                // Llenar los TextBox con la información del producto seleccionado

                txt_NombreProducto.Text = producto.Nombre;

                txt_Marca.Text = producto.Marca;

                txt_CandtidadProducto.Text = producto.Cantidad.ToString();

                txt_PrecioCompra.Text = producto.Precio_Compra.HasValue ? producto.Precio_Compra.Value.ToString("F2") : string.Empty;

                txt_PrecioProducto.Text = producto.Precio_Producto.HasValue ? producto.Precio_Producto.Value.ToString("F2") : string.Empty;

                txt_Detalles.Text = producto.Detalles;

                cbox_Categoria.SelectedValue = producto.ID_Categoria;
                cbox_Sucursal.SelectedValue = producto.ID_Sucursal;

            }
            else

            {

                MessageBox.Show("No se encontró el producto seleccionado.");

            }

        }

        private void ProductosActualizar_Load(object sender, EventArgs e)
        {
            FormBuscarProducto_ProductoSeleccionado(idProducto);
        }

        /*private void cbox_Sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void cbox_Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {



        }*/
    }
}
