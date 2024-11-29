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
    public partial class Empleados : Form
    {

        private Timer searchTimer; // Timer para retrasar la búsqueda

        public Empleados()
        {
            InitializeComponent();
            ConfigureSearchTimer(); // Asegúrate de inicializar el Timer aquí
    
        }

        EmpleadoMCN MetodosEmpleado = new EmpleadoMCN();

        private void btn_WF_Actualizar_Click(object sender, EventArgs e)
        {

            // Verificar que haya una fila seleccionada
            if (DGV_Empleados.SelectedRows.Count == 0)
            {

                MessageBox.Show("Por favor, selecciona una empleado para actualizar.");
                return;
            }

            Actualizar_Agregar_Empleado FormularioActualizar = new Actualizar_Agregar_Empleado();

            FormularioActualizar.EmpleadoAgregadoActualizado += FormularioActualizar_EmpleadoActualizada;

            var filaSeleccionada = DGV_Empleados.SelectedRows[0];
            var categoriaSeleccionada = (EmpleadoDTO)filaSeleccionada.DataBoundItem;

            FormularioActualizar.cambiarlabel.Text = "Actualizar Empleado";
            FormularioActualizar.cambiarboton.Text = "Actualizar";
            FormularioActualizar.idEmpleado = categoriaSeleccionada.ID_Empleado;

            FormularioActualizar.Show();

        }

        private void btn_WF_Agregar_Click(object sender, EventArgs e)
        {
            Actualizar_Agregar_Empleado FormularioAgregar = new Actualizar_Agregar_Empleado();

            FormularioAgregar.EmpleadoAgregadoActualizado += FormularioAgregar_EmpleadoAgregada;

            FormularioAgregar.cambiarlabel.Text = "Agregar Empleado";
            FormularioAgregar.cambiarboton.Text = "Agregar";

            FormularioAgregar.Show();

        }

        private void FormularioAgregar_EmpleadoAgregada(object sender, EventArgs e)
        {

            imprimirRegistroEmpleados();
        }

        private void FormularioActualizar_EmpleadoActualizada(object sender, EventArgs e)
        {

            imprimirRegistroEmpleados();

        }

        private void imprimirRegistroEmpleados()
        {
            var compras = MetodosEmpleado.ObtenerVendedorActivos();
            DGV_Empleados.DataSource = compras;
            DGV_Empleados.Refresh(); // Fuerza el refresco del control

        }

        private void imprimirBusquedaEmpleados(string nombre)
        {
            var empleados = MetodosEmpleado.BuscarEmpleadoNombre(nombre);

            if (empleados.Any())
            {
                DGV_Empleados.DataSource = empleados;
            }
            else
            {
                DGV_Empleados.DataSource = null;
                //MessageBox.Show("No se encontraron coincidencias.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DGV_Empleados.Refresh(); // Fuerza el refresco del control
        }

        private void ConfigureDataGridView()
        {
            this.DGV_Empleados.DefaultCellStyle.ForeColor = Color.Black;

            DGV_Empleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGV_Empleados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGV_Empleados.ReadOnly = true; // Evita que el usuario edite las celdas
            DGV_Empleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selecciona toda la fila al hacer clic
            DGV_Empleados.AutoGenerateColumns = false;

            // Configuración de columnas

            DGV_Empleados.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID Empleado",
                DataPropertyName = "ID_Empleado"
            });

            DGV_Empleados.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Estado",
                DataPropertyName = "NombreEstado"
            });


            DGV_Empleados.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nombre",
                DataPropertyName = "Nombre"
            });


            DGV_Empleados.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Cedula",
                DataPropertyName = "Cedula"
            });


            DGV_Empleados.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Edad",
                DataPropertyName = "Edad"
            });

            DGV_Empleados.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Rol",
                DataPropertyName = "NombreRol"
            });


            DGV_Empleados.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Sucursal",
                DataPropertyName = "NombreSucursal"
            });


           

        }


        private void btn_WF_CerrarEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void Empleados_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            imprimirRegistroEmpleados();
        }

        private void ConfigureSearchTimer()
        {
            searchTimer = new Timer();
            searchTimer.Interval = 300; // Retraso de 300 ms
            searchTimer.Tick += SearchTimer_Tick_Tick;
        }


        private void txt_NombreEmpleado_TextChanged(object sender, EventArgs e)
        {
            searchTimer.Stop(); // Detiene el timer en cada cambio de texto
            searchTimer.Start(); // Reinicia el timer
        }

        private void SearchTimer_Tick_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop(); // Detiene el timer para evitar múltiples ejecuciones
            string textoBusqueda = txt_NombreEmpleado.Text.Trim();

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                imprimirRegistroEmpleados(); // Si está vacío, muestra todos los registros
            }
            else
            {
                imprimirBusquedaEmpleados(textoBusqueda); // Realiza la búsqueda
            }

        }
    }
}
