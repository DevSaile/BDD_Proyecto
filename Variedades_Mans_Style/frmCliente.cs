using CapaEntidad;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Variedades_Man_s_Style
{
    public partial class frmCliente : Form
    {
        private Timer searchTimer; // Timer para retrasar la búsqueda

        public frmCliente()
        {
            InitializeComponent();
            ConfigureSearchTimer();
        }

        ClienteMCN MetodosCliente = new ClienteMCN();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmMantCliente fm = new frmMantCliente();
            fm.Show();
            
        }

        private void ImprimirClientes()
        {
            var compras = MetodosCliente.ObtenerClientesActivos();
            dgvVerClientes.DataSource = compras;
            dgvVerClientes.Refresh(); // Fuerza el refresco del control

        }

        private void ConfigureDataGridView()
        {
            this.dgvVerClientes.DefaultCellStyle.ForeColor = Color.Black;

            dgvVerClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvVerClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvVerClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dgvVerClientes.ReadOnly = true; // Evita que el usuario edite las celdas
            dgvVerClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selecciona toda la fila al hacer clic
            dgvVerClientes.AutoGenerateColumns = false;

            // Configuración de columnas

            dgvVerClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID Cliente",
                DataPropertyName = "ID_Cliente",

            }); 


            dgvVerClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Estado",
                DataPropertyName = "NombreEstado",

            }); 


            dgvVerClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",

            });


        }

        private void panelDatosEmpleados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            ImprimirClientes();
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {

            if (txtNombreCliente.Text == string.Empty)
            {
                MessageBox.Show("Nombre invalido");
                return;
            }


            ClienteDTO namecliente = new ClienteDTO();

            namecliente = new ClienteDTO()
            {
                Nombre = txtNombreCliente.Text,
                Estado = 1,

            };

            bool resultado = MetodosCliente.AgregarCliente(namecliente);

            if (resultado)
            {

                MessageBox.Show("Se agrego el cliente");
                ImprimirClientes();

            }
            else
            {
                MessageBox.Show("No se agrego el cliente");
            }

        }

        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            if (txtNombreCliente.Text == string.Empty)
            {
                MessageBox.Show("Nombre invalido");
                return;
            }


            var filaSeleccionada = dgvVerClientes.SelectedRows[0];
            var categoriaSeleccionada = (ClienteDTO)filaSeleccionada.DataBoundItem;

            ClienteDTO namecliente = new ClienteDTO();

            namecliente = new ClienteDTO()
            {
                ID_Cliente = categoriaSeleccionada.ID_Cliente,
                Nombre = txtNombreCliente.Text,

            };

            bool resultado = MetodosCliente.ActualizarCliente(namecliente);

            if (resultado)
            {

                MessageBox.Show("Se agrego el cliente");
                ImprimirClientes();

            }
            else
            {
                MessageBox.Show("No se agrego el cliente");
            }
        }

        private void imprimirBusquedaClientes(string nombre)
        {
            var clientes = MetodosCliente.BuscarClienteNombre(nombre);

            if (clientes.Any())
            {
                dgvVerClientes.DataSource = clientes;
            }
            else
            {
                dgvVerClientes.DataSource = null;
                //MessageBox.Show("No se encontraron coincidencias.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgvVerClientes.Refresh(); // Fuerza el refresco del control
        }

        private void ConfigureSearchTimer()
        {
            searchTimer = new Timer();
            searchTimer.Interval = 300; // Retraso de 300 ms
            searchTimer.Tick += SearchTimer_Tick_Tick_Tick;
        }

        private void SearchTimer_Tick_Tick_Tick(object sender, EventArgs e)
        {

            searchTimer.Stop(); // Detiene el timer para evitar múltiples ejecuciones
            string textoBusqueda = txt_BuscarCliente.Text.Trim();

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                ImprimirClientes(); // Si está vacío, muestra todos los registros
            }
            else
            {
                imprimirBusquedaClientes(textoBusqueda); // Realiza la búsqueda
            }

        }

        private void txt_BuscarCliente_TextChanged(object sender, EventArgs e)
        {
            searchTimer.Stop(); // Detiene el timer en cada cambio de texto
            searchTimer.Start(); // Reinicia el timer
        }
    }
}
