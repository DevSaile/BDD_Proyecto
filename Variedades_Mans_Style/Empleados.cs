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
        public Empleados()
        {
            InitializeComponent();
        }

        EmpleadoMCN MetodosEmpleado = new EmpleadoMCN();

        private void btn_WF_Actualizar_Click(object sender, EventArgs e)
        {
            Actualizar_Agregar_Empleado FormularioActualizar = new Actualizar_Agregar_Empleado();
            FormularioActualizar.Show();

            FormularioActualizar.cambiarlabel.Text = "Actualizar Empleado";
            FormularioActualizar.cambiarboton.Text = "Actualizar";
        }

        private void btn_WF_Agregar_Click(object sender, EventArgs e)
        {
            Actualizar_Agregar_Empleado FormularioAgregar = new Actualizar_Agregar_Empleado();
            FormularioAgregar.Show();

            FormularioAgregar.cambiarlabel.Text = "Agregar Empleado";
            FormularioAgregar.cambiarboton.Text = "Agregar";

        }

        private void imprimirRegistroEmpleados()
        {
            var compras = MetodosEmpleado.ObtenerVendedorActivos();
            DGV_Empleados.DataSource = compras;
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
    }
}
