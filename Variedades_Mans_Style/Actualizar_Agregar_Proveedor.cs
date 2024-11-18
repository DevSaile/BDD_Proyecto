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
    public partial class Actualizar_Agregar_Proveedor : Form
    {
        public Actualizar_Agregar_Proveedor()
        {
            InitializeComponent();
        }

        public Label cambiarlabel {  // Aqui basicamente vamos a cambiar lo que dice el label

            get { return label_Actualizar_Agregar_Proveedor; } 

        }

        public Button cambiarboton{  // Aqui basicamente vamos a cambiar lo que dice el boton

            get { return btn_Agregar_Actualizar_Proveedor; }

        }

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
    }
}
