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
    public partial class Productos : Form
    {



        public Productos()
        {
            InitializeComponent();

        }

        private bool esProductoExistente = false; // Variable para indicar si el producto es existente
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

        private void llenarCOMBOBOXExistente()
        {


            cbox_Sucursal.SelectedValue = MetodosSucursal.ObtenerSucursalesPorID(idProductoSeleccionado);
            cbox_Categoria.SelectedValue = MetodosCategoria.ObtenerCategoriasPorID(idProductoSeleccionado);

            // Deshabilitar ComboBox para que no se puedan modificar
            cbox_Sucursal.Enabled = false;
            cbox_Categoria.Enabled = false;

        }

        private void GuardarExistente()
        {
            if (ValidarTextBoxesEnGrupo(panel_InfoProductos))
            {

                ProductoDTO actuProducto = new ProductoDTO();

                actuProducto = new ProductoDTO()
                {

                    ID_Producto = idProductoSeleccionado,
                    Nombre = txt_NombreProducto.Text,
                    Marca = txt_Marca.Text,
                    Cantidad = string.IsNullOrEmpty(txt_CandtidadProducto.Text) ? (int?)null : int.Parse(txt_CandtidadProducto.Text),
                    Precio_Compra = string.IsNullOrEmpty(txt_PrecioCompra.Text) ? (decimal?)null : decimal.Parse(txt_PrecioCompra.Text),
                    Precio_Producto = string.IsNullOrEmpty(txt_PrecioProducto.Text) ? (decimal?)null : decimal.Parse(txt_PrecioProducto.Text),
                    Detalles = txt_Detalles.Text,

                };

                int resulPRO = MetodosProducto.ActulizarProductoExistente(actuProducto);

                if (resulPRO != -1)
                {

                    MessageBox.Show($" Registro hecho papa");
                    esProductoExistente = false;
                    cbox_Categoria.Enabled = true;
                    cbox_Sucursal.Enabled = true;


                    btn_AgregarProducto.Enabled = true;
                    btn_AgregarProducto.Visible = true;

                    btnCancelarExistente.Enabled = false;
                    btnCancelarExistente.Visible = false;

                }
                else
                {
                    MessageBox.Show($" Registro no hecho pipipi");
                    esProductoExistente = false;
                    cbox_Categoria.Enabled = true;
                    cbox_Sucursal.Enabled = true;


                    btn_AgregarProducto.Enabled = true;
                    btn_AgregarProducto.Visible = true; 
                    
                    btnCancelarExistente.Enabled = false;
                    btnCancelarExistente.Visible = false;

                }

                Compra_EntradaDTO compraentra = new Compra_EntradaDTO();


                compraentra = new Compra_EntradaDTO()
                {

                    Estado = 1,
                    ID_Producto = resulPRO,
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
                    MessageBox.Show("valio queso el registro de compraEntrada");
                }

            }
            else
            {

                btnGuardarExistente.Enabled = true;
                btnGuardarExistente.Visible = true;

            }



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
            else
            {
                return;
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
            this.Close(); // Esto de aqui se podria borrar
        }

        private void btnAgregarExistente_Click(object sender, EventArgs e)
        {

            /*btn_AgregarProducto.Enabled = false;
            btn_AgregarProducto.Visible = false;*/

            BuscarProductoExistente FormularioProduExistente = new BuscarProductoExistente();

            FormularioProduExistente.ProductoSeleccionado += FormBuscarProducto_ProductoSeleccionado;
            FormularioProduExistente.Show();

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

                /*txt_CandtidadProducto.Text = producto.Cantidad.ToString();

                txt_PrecioCompra.Text = producto.Precio_Compra.HasValue ? producto.Precio_Compra.Value.ToString("F2") : string.Empty;

                txt_PrecioProducto.Text = producto.Precio_Producto.HasValue ? producto.Precio_Producto.Value.ToString("F2") : string.Empty;*/

                txt_Detalles.Text = producto.Detalles;

                cbox_Categoria.SelectedValue = producto.ID_Categoria;
                cbox_Sucursal.SelectedValue = producto.ID_Sucursal;

                // Deshabilitar ComboBox para que no se puedan modificar
                cbox_Sucursal.Enabled = false;
                cbox_Categoria.Enabled = false;

                btnCancelarExistente.Enabled = true;
                btnCancelarExistente.Visible = true;

                btnGuardarExistente.Enabled = true;
                btnGuardarExistente.Visible = true;

                btn_AgregarProducto.Enabled = false;
                btn_AgregarProducto.Visible = false;


                //llenarCOMBOBOXExistente();

                // Aqui seria no darle la opcion de modificar la tienda y la categoria

            }

            else

            {

                MessageBox.Show("No se encontró el producto seleccionado.");

            }

        }

        private void Productos_Load(object sender, EventArgs e)
        {
            llenarCOMBOBOX();
            btnCancelarExistente.Enabled = false;
            btnCancelarExistente.Visible = false;

            btnGuardarExistente.Enabled = false;
            btnGuardarExistente.Visible = false;

        }

        private void btnCancelarExistente_Click(object sender, EventArgs e)
        {
            var producto = MetodosProducto.BuscarPorID(idProductoSeleccionado);

            if (producto != null)
            {

                esProductoExistente = false; // El producto es existente
                // Llenar los TextBox con la información del producto seleccionado

                txt_NombreProducto.Text = producto.Nombre;

                txt_Marca.Text = producto.Marca;

                /*txt_CandtidadProducto.Text = producto.Cantidad.ToString();

                txt_PrecioCompra.Text = producto.Precio_Compra.HasValue ? producto.Precio_Compra.Value.ToString("F2") : string.Empty;

                txt_PrecioProducto.Text = producto.Precio_Producto.HasValue ? producto.Precio_Producto.Value.ToString("F2") : string.Empty;*/

                txt_Detalles.Text = producto.Detalles;

                cbox_Categoria.SelectedValue = producto.ID_Categoria;
                cbox_Sucursal.SelectedValue = producto.ID_Sucursal;

                // Deshabilitar ComboBox para que no se puedan modificar
                cbox_Sucursal.Enabled = true;
                cbox_Categoria.Enabled = true;

                btnCancelarExistente.Enabled = false;
                btnCancelarExistente.Visible = false;


                btn_AgregarProducto.Enabled = true;
                btn_AgregarProducto.Visible = true;


                btnGuardarExistente.Enabled = false;
                btnGuardarExistente.Visible = false;


                //llenarCOMBOBOXExistente();

                // Aqui seria no darle la opcion de modificar la tienda y la categoria

            }

            else

            {

                MessageBox.Show("No se encontró el producto seleccionado.");

            }


        }

        private void btnGuardarExistente_Click(object sender, EventArgs e)
        {
            GuardarExistente();


        }

        /*private void cbox_Sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void cbox_Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {



        }*/
    }
}
