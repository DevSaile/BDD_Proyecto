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

        public event EmpleadoAgregadoActualizadoHandler CategoriaAgregada;

        public Actualizar_Agregar_Empleado()
        {
            InitializeComponent();
        }

        CategoriaMCN MetodosEmpleado = new CategoriaMCN();
        public int? CategoriaID { get; set; }

        public Label cambiarlabel {  // Aqui basicamente vamos a cambiar lo que dice el label

            get { return label_Actualizar_Agregar_Empleado; } 

        }

        public Button cambiarboton{  // Aqui basicamente vamos a cambiar lo que dice el boton

            get { return btn_Agregar_Actualizar_Empleado; }

        }

        /*public TextBox cambiartxtnombreEmpleado
        {

            get { return txt_NombreEmpleado;  }
        }
        public TextBox cambiartxtCedulaEmpleado
        {

            get { return txt_CedulaEmpleado;  }
        }
        public TextBox cambiartxtEdadEmpleado
        {

            get { return txt_EdadEmpleado; }
        }*/




        private void label_Agregar_Click(object sender, EventArgs e)
        {

        }

        private void AgregarProveedor_Load(object sender, EventArgs e)
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

        private void btn_CancelarProveedor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel_DatosProveedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Agregar_Actualizar_Empleado_Click(object sender, EventArgs e)
        {

        }
    }
}
