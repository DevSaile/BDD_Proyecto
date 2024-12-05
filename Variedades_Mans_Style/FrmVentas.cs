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
using System.Windows.Documents;
using System.Windows.Forms;

namespace Variedades_Man_s_Style
{
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
            Configurarverproductosventa();
        }


        ClienteMCN MetodosCliente = new ClienteMCN();
        ProductoMCN MetodosProducto = new ProductoMCN();
        EmpleadoMCN MetodosEmpleados = new EmpleadoMCN();
        VentaFacturaMCN MetodosVentaFactura = new VentaFacturaMCN();
        SucursalMCN MetodosSucursal = new SucursalMCN();

        private List<ProductoDTO> productosEnVenta = new List<ProductoDTO>();

        private int idProductoSeleccionado; // Variable para almacenar el ID del producto seleccionado
        private int idClienteSeleccionado = -1; // Variable para almacenar el ID del producto seleccionado

        private int idEmpleadoSeleccionado; // Variable para almacenar el ID del producto seleccionado

        private bool clientexiste = false;
        private int resultadoNewCliente;


        private void LlenarCombobox()
        {

            var empleados = MetodosEmpleados.ObtenerVendedorActivos();
            cbempleadoventa.DataSource = empleados;
            cbempleadoventa.DisplayMember = "Nombre";
            cbempleadoventa.ValueMember = "ID_Empleado";

            idEmpleadoSeleccionado = (int)cbempleadoventa.SelectedValue;


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AgregarProductoVentas()
        {
            if (idProductoSeleccionado <= 0)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            if (!int.TryParse(txtcantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida");
                return;
            }

            var producto = MetodosProducto.BuscarPorID(idProductoSeleccionado);
            if (producto == null || producto.Cantidad < cantidad)
            {
                MessageBox.Show("Cantidad insuficiente en stock");
                return;
            }

            productosEnVenta.Add(new ProductoDTO
            {
                ID_Producto = producto.ID_Producto,
                Nombre = producto.Nombre,
                Precio_Producto = producto.Precio_Producto,
                Cantidad = cantidad,
                Detalles = producto.Detalles,
                Marca = MetodosSucursal.DevolverMarcaProductos(producto.ID_Producto), // Estos de aqui se podrian quitar
                Descripcion_Sucursal = MetodosSucursal.DevolverSucursalProductos(idProductoSeleccionado)
                
            });

            ActualizarListaProductos();


        }

        private void CrearVenta()
        {

            if ((txtnombrecliente.Text != MetodosCliente.DevolveNombrecliente(idClienteSeleccionado)) && idClienteSeleccionado != -1)
            {
                idClienteSeleccionado = -1;
                clientexiste = false;
                //MessageBox.Show("jadhdsagjja");
            }

            if (clientexiste == false)
            {

                ClienteDTO namecliente = new ClienteDTO();

                namecliente = new ClienteDTO()
                {
                    Nombre = txtnombrecliente.Text,
                    Estado = 1,

                };

                idClienteSeleccionado = MetodosCliente.AgregarClienteParaVenta(namecliente);

                if (resultadoNewCliente != -1)
                {
                    clientexiste = false;
                }
                else
                {
                    MessageBox.Show("No se agrego el ususario nuevo");
                }

            }

            if (productosEnVenta.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto a la venta");
                return;
            }

            if (!decimal.TryParse(txtpagocon.Text, out decimal pago) || pago <= 0)
            {
                MessageBox.Show("Ingrese un monto válido para el pago");
                return;
            }

            var total = productosEnVenta.Sum(p => p.Precio_Producto * p.Cantidad);
            if (pago < total)
            {
                MessageBox.Show("El monto pagado no puede ser menor al total");
                return;
            }

            var nuevaVenta = new Venta_FacturaDTO
            {
                Estado = 1,
                ID_Cliente = idClienteSeleccionado,
                ID_Vendedor = idEmpleadoSeleccionado,
                Fecha_Venta = DateTime.Now,
                Subtotal = total,
                Total = total,
                pagacon = pago,
                cambio = pago - total,
                PrecioProducto = string.IsNullOrEmpty(txtprecio.Text) ? (decimal?)null : decimal.Parse(txtprecio.Text),
                Cantidad = string.IsNullOrEmpty(txtcantidad.Text) ? (int?)null : int.Parse(txtcantidad.Text),
                Detalles = productosEnVenta.Select(p => new Venta_DetallesDTO
                {
                    ID_Producto = p.ID_Producto,
                    Cantidad = p.Cantidad,
                    PrecioProducto = p.Precio_Producto

                }).ToList()
            };

            var resultado = MetodosVentaFactura.AgregarVentaPRO(nuevaVenta);

            if (resultado != -1)
            {
                MessageBox.Show("Venta registrada exitosamente");
                clientexiste = false;
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("No se pudo registrar la venta");
            }

        }

        private void Configurarverproductosventa()
        {

            this.dgvdataVenta.DefaultCellStyle.ForeColor = Color.Black;

            dgvdataVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvdataVenta.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvdataVenta.ReadOnly = true; // Evita que el usuario edite las celdas
            dgvdataVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selecciona toda la fila al hacer clic
            dgvdataVenta.AutoGenerateColumns = false;

            // Configuración de columnas
            dgvdataVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID Producto",
                DataPropertyName = "ID_Producto"
            });

            dgvdataVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Esta en",
                DataPropertyName = "Descripcion_Sucursal"
            });

            dgvdataVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nombre",
                DataPropertyName = "Nombre"
            });


            dgvdataVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Precio del Producto",
                DataPropertyName = "Precio_Producto"
            });

            dgvdataVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Marca",
                DataPropertyName = "Marca"
            });

            dgvdataVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Cantidad",
                DataPropertyName = "Cantidad"
            });


            dgvdataVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Detalles",
                DataPropertyName = "Detalles"
            });





        }

        private void LimpiarFormulario()
        {
            txtnombrecliente.Clear();
            txtproducto.Clear();
            txtprecio.Clear();
            txtstock.Clear();
            txtstock.Clear();
            txttotalpagar.Clear();
            txtpagocon.Clear();
            txtcambio.Clear();
            productosEnVenta.Clear();
            dgvdataVenta.DataSource = null;
        }


        private void ActualizarListaProductos()
        {
            dgvdataVenta.DataSource = null;
            dgvdataVenta.DataSource = productosEnVenta;
            CalcularTotalVenta();
        }

        private void CalcularTotalVenta()
        {
            decimal? total = productosEnVenta.Sum(p => p.Precio_Producto * p.Cantidad);
            txttotalpagar.Text = total.Value.ToString("F2");
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            LlenarCombobox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VentaInformacion Formulariollenarcampos = new VentaInformacion();

            Formulariollenarcampos.objetoseleccionado+= FormBuscarObjeto_ObjetoSeleccionado;
            Formulariollenarcampos.Show();
        }

        private void FormBuscarObjeto_ObjetoSeleccionado(int idobjeto, int idcampo)
        {
            if (idcampo == 1)
            {

                var cliente = MetodosCliente.BuscarClienteIDSolo(idobjeto);

                if (cliente != null)
                {

                    idClienteSeleccionado = idobjeto;
                    txtnombrecliente.Text = cliente.Nombre;
                    //cbRol.SelectedValue = MetodosRol.ObtenerRolID(idEmpleado);
                    //cbsucursal.SelectedValue = MetodosSucursal.ObtenerSucursalID(idEmpleado);

                    clientexiste = true;

                }


            }


            if (idcampo == 2)
            {
                var ventaproducto = MetodosProducto.BuscarPorID(idobjeto);

                if (ventaproducto != null)
                {

                    idProductoSeleccionado = idobjeto;
                    txtproducto.Text = ventaproducto.Nombre;
                    txtprecio.Text = ventaproducto.Precio_Producto.ToString();
                    txtstock.Text = ventaproducto.Cantidad.ToString();

                }


            }


            if (idcampo == 3)
            {
                var ventaempleado = MetodosEmpleados.ObtenerEmpleadoPorId(idobjeto);

                if (ventaempleado != null)
                {

                    idEmpleadoSeleccionado = idobjeto;
                    cbempleadoventa.SelectedValue = idEmpleadoSeleccionado;
                    //cbRol.SelectedValue = MetodosRol.ObtenerRolID(idEmpleado);
                    //cbsucursal.SelectedValue = MetodosSucursal.ObtenerSucursalID(idEmpleado);
                }


            }



        }

        private void btnAgregarVentaProducto_Click(object sender, EventArgs e)
        {
            AgregarProductoVentas();
        }

        private void txtpagocon_TextChanged(object sender, EventArgs e)
        {
            //var total = productosEnVenta.Sum(p => p.Precio_Producto * p.Cantidad);
            //decimal? pago = string.IsNullOrEmpty(txtpagocon.Text) ? (decimal?)null : decimal.Parse(txtpagocon.Text);

            decimal pago;
            if (decimal.TryParse(txtpagocon.Text, out pago))
            {
                // La conversión fue exitosa, el usuario ingresó un número válido
                var total = productosEnVenta.Sum(p => p.Precio_Producto * p.Cantidad);

                if (pago < total)
                {

                }
                else
                {
                    total = pago - total;
                    txtcambio.Text = total.ToString();

                }
            }
            else
            {

                txtpagocon.Text = ""; // Limpiar el TextBox
                txtcambio.Text = "";
            }


            /*if (pago < total)
            {
                return;
            }
            else
            {


            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearVenta();
        }

        private void btn_WF_CerrarEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
