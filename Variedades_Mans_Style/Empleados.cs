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

        private Color originalColor;


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

        private void btn_WF_Desactivar_MouseHover(object sender, EventArgs e)
        {
            originalColor = btn_WF_Desactivar.BackColor;
            btn_WF_Desactivar.BackColor = Color.Black;
        }

        private void btn_WF_Desactivar_MouseLeave(object sender, EventArgs e)
        {
            btn_WF_Desactivar.BackColor = originalColor;

        }

        private void btn_WF_CerrarEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
