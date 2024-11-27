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



            if (ValidarTextBoxesEnGrupo(panel_InfoProductos))
            {
                // ... (resto de tu código)

                // Validación adicional para cantidades y precios negativos
                if (int.TryParse(txt_CandtidadProducto.Text, out int cantidad) && cantidad < 0)
                {
                    MessageBox.Show("La cantidad no puede ser negativa.");
                    return;
                }

                if (decimal.TryParse(txt_PrecioCompra.Text, out decimal precioCompra) && precioCompra < 0)
                {
                    MessageBox.Show("El precio de compra no puede ser negativo.");
                    return;
                }

                if (decimal.TryParse(txt_PrecioProducto.Text, out decimal precioProducto) && precioProducto < 0)
                {
                    MessageBox.Show("El precio del producto no puede ser negativo.");
                    return;
                }

                // Lógica para guardar datos.
                MessageBox.Show("Todos los campos están llenos. Procediendo con la operación.");

                ProductoDTO produ = new ProductoDTO();


                produ = new ProductoDTO()
                {

                    ID_Categoria = (int)cbox_Categoria.SelectedValue,
                    ID_Sucursal = (int)cbox_Sucursal.SelectedValue,
                    Nombre = txt_NombreProducto.Text,
                    Marca = txt_Marca.Text,
                    Cantidad = string.IsNullOrEmpty(txt_CandtidadProducto.Text) ? (int?)null : int.Parse(txt_CandtidadProducto.Text),
                    Precio_Compra = string.IsNullOrEmpty(txt_PrecioCompra.Text) ? (decimal?)null : decimal.Parse(txt_PrecioCompra.Text),
                    Precio_Producto = string.IsNullOrEmpty(txt_PrecioProducto.Text) ? (decimal?)null : decimal.Parse(txt_PrecioProducto.Text),
                    Detalles = txt_Detalles.Text,
                    Estado = 1


                };

                int GuardarProdu_obtenerResultado = MetodosProducto.AgregarProducto(produ);

                if (GuardarProdu_obtenerResultado != -1)
                {

                    MessageBox.Show("Se agrego el producto");
                }
                else
                {
                    MessageBox.Show("valio queso");
                }

                Compra_EntradaDTO compraentra = new Compra_EntradaDTO();


                compraentra = new Compra_EntradaDTO()
                {

                    Estado = 1,
                    ID_Producto = GuardarProdu_obtenerResultado,
                    Fecha_Compra = DateTime.Today,
                    Precio_Compra = string.IsNullOrEmpty(txt_PrecioCompra.Text) ? (decimal?)null : decimal.Parse(txt_PrecioCompra.Text),
                    CantidadCompra = string.IsNullOrEmpty(txt_CandtidadProducto.Text) ? (int?)null : int.Parse(txt_CandtidadProducto.Text)

                };

                bool savecompraentra = MetodosCompraEntrada.AgregarProducto(compraentra);


                if (savecompraentra)
                {

                    MessageBox.Show("Se agrego el registro");
                }
                else
                {
                    MessageBox.Show("valio queso");
                }

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

        /*private void cbox_Sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void cbox_Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {



        }*/
    }
}
