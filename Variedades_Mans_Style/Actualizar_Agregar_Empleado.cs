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
    public partial class Actualizar_Agregar_Empleado : Form
    {
        // Define un delegado y un evento

        public delegate void EmpleadoAgregadoActualizadoHandler(object sender, EventArgs e);

        public event EmpleadoAgregadoActualizadoHandler EmpleadoAgregadoActualizado;

        public Actualizar_Agregar_Empleado()
        {
            InitializeComponent();
        }


        SucursalMCN MetodosSucursal = new SucursalMCN();

        RolMCN MetodosRol = new RolMCN();

        EmpleadoMCN MetodosEmpleados  = new EmpleadoMCN();


        public int idEmpleado { get; set; }

        private void LlenarDatosEmpleado(int idEmpleado)

        {

            var empleado = MetodosEmpleados.ObtenerEmpleadoPorId(idEmpleado);

            if (empleado != null)

            {

                txtNombreEmpleado.Text = empleado.Nombre;

                txtCedulaEmpleado.Text = empleado.Cedula;

                dtpFechaEmple.Value = empleado.Edad ?? DateTime.Now;

                txtUsuario.Text = empleado.usuario;

                txtContra.Text = empleado.contrasena;


            }

        }



        private void llenarCOMBOBOX_Actualizar()
        {
            // Cargar todos los roles

            var Roles = MetodosRol.ObtenerRoles();

            cbRol.DataSource = Roles;

            cbRol.DisplayMember = "Puesto";

            cbRol.ValueMember = "ID_Rol";


            // Cargar todas las sucursales

            var Sucursales = MetodosSucursal.ObtenerSucursales();

            cbsucursal.DataSource = Sucursales;

            cbsucursal.DisplayMember = "Nombre";

            cbsucursal.ValueMember = "ID_Sucursal";


            cbRol.SelectedValue = MetodosRol.ObtenerRolID(idEmpleado);
            cbsucursal.SelectedValue = MetodosSucursal.ObtenerSucursalID(idEmpleado);


        }

        private void llenarCOMBOBOX_Agregar()
        {
            var Roles = MetodosRol.ObtenerRoles();
            cbRol.DataSource = Roles;
            cbRol.DisplayMember = "Puesto";
            cbRol.ValueMember = "ID_Rol";

            var Sucursales = MetodosSucursal.ObtenerSucursales();
            cbsucursal.DataSource = Sucursales;
            cbsucursal.DisplayMember = "Nombre";
            cbsucursal.ValueMember = "ID_Sucursal";

        }

        private void actulizarEmpleado()
        {

            EmpleadoDTO nuevoempleado = new EmpleadoDTO();

            nuevoempleado = new EmpleadoDTO()
            {

                ID_Empleado = idEmpleado,
                Nombre = txtNombreEmpleado.Text,
                Cedula = txtCedulaEmpleado.Text,
                Edad = dtpFechaEmple.Value,
                usuario = txtUsuario.Text,
                contrasena = txtContra.Text,
                ID_Rol = (int)cbRol.SelectedValue,
                ID_Sucursal = (int)cbsucursal.SelectedValue,

            };

            bool resultado = MetodosEmpleados.ActualizarEmpleado(nuevoempleado);

            if (resultado)
            {

                MessageBox.Show($"Se actualizo el empleado{nuevoempleado.Nombre}");

                EmpleadoAgregadoActualizado?.Invoke(this, EventArgs.Empty);

                this.Close();

            }
            else
            {
                MessageBox.Show($"No se actualizo el empleado{nuevoempleado.Nombre}");

            }


        }

        private void AgregarEmpleado()
        {

            EmpleadoDTO nuevoempleado = new EmpleadoDTO();

            nuevoempleado = new EmpleadoDTO()
            {

                Nombre = txtNombreEmpleado.Text,
                Cedula = txtCedulaEmpleado.Text,
                Edad = dtpFechaEmple.Value,
                Estado = 1,
                usuario = txtUsuario.Text,
                contrasena = txtContra.Text,
                ID_Rol = (int)cbRol.SelectedValue,
                ID_Sucursal = (int)cbsucursal.SelectedValue,

            };

            bool resultado = MetodosEmpleados.AgregarEmpleado(nuevoempleado);

            if (resultado) 
            {

                MessageBox.Show($"Se agrego el empleado{nuevoempleado.Nombre}");

                EmpleadoAgregadoActualizado?.Invoke( this, EventArgs.Empty );

                this.Close();

            }
            else
            {
                MessageBox.Show($"No se agrego el empleado{nuevoempleado.Nombre}");

            }


        }


        public Label cambiarlabel {  // Aqui basicamente vamos a cambiar lo que dice el label

            get { return label_Actualizar_Agregar_Empleado; } 

        }

        public Button cambiarboton{  // Aqui basicamente vamos a cambiar lo que dice el boton

            get { return btn_Agregar_Actualizar_Empleado; }

        }



        private void label_Agregar_Click(object sender, EventArgs e)
        {

        }


        private void label_Nombre_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void btn_Agregar_Actualizar_Empleado_Click(object sender, EventArgs e)
        {

            if (label_Actualizar_Agregar_Empleado.Text == "Agregar Empleado")
            {
                AgregarEmpleado();

            }
            else
            {
                actulizarEmpleado();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AgregarEmpleado_Load(object sender, EventArgs e)
        {
            if (btn_Agregar_Actualizar_Empleado.Text == "Agregar")
            {
                llenarCOMBOBOX_Agregar();
            }
            else
            {

                LlenarDatosEmpleado(idEmpleado);

                llenarCOMBOBOX_Actualizar();
            }

        }

        private void btn_CancelarEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel_DatosEmpleado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DPtFechaEmpleado_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
