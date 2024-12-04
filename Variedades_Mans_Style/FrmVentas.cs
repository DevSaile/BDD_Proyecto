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
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }


        ClienteMCN MetodosCliente = new ClienteMCN();
        ProductoMCN MetodosProducto = new ProductoMCN();
        EmpleadoMCN MetodosEmpleados = new EmpleadoMCN();
        VentaFacturaMCN MetodosVentaFactura = new VentaFacturaMCN();

        private int idProductoSeleccionado; // Variable para almacenar el ID del producto seleccionado
        private int idClienteSeleccionado; // Variable para almacenar el ID del producto seleccionado

        private int idEmpleadoSeleccionado; // Variable para almacenar el ID del producto seleccionado

        private bool clientexiste = false;
        private int resultadoNewCliente;


        private void LlenarCombobox()
        {

            var empleados = MetodosEmpleados.ObtenerVendedorActivos();
            cbempleadoventa.DataSource = empleados;
            cbempleadoventa.DisplayMember = "Nombre";
            cbempleadoventa.ValueMember = "ID_Empleado";


        }

        private void label4_Click(object sender, EventArgs e)
        {

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
                    clientexiste = true;

                    idClienteSeleccionado = idobjeto;
                    txtnombrecliente.Text = cliente.Nombre;
                    //cbRol.SelectedValue = MetodosRol.ObtenerRolID(idEmpleado);
                    //cbsucursal.SelectedValue = MetodosSucursal.ObtenerSucursalID(idEmpleado);
                }


            }
            else if (clientexiste == false)
            {

                ClienteDTO namecliente = new ClienteDTO();

                namecliente = new ClienteDTO()
                {
                    Nombre = txtnombrecliente.Text,
                    Estado = 1,

                };

                resultadoNewCliente = MetodosCliente.AgregarClienteParaVenta(namecliente);

                if (resultadoNewCliente != -1)
                {
                    clientexiste = false;
                }
                else
                {
                    MessageBox.Show("No se agrego el ususario nuevo");
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
    }
}
