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
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
        }

        private void Panel_WF_Controles_Proveedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_WF_Actualizar_Click(object sender, EventArgs e)
        {

            Actualizar_Agregar_Categoria FormularioActualizar = new Actualizar_Agregar_Categoria();
            FormularioActualizar.Show();

            FormularioActualizar.cambiarlabel.Text = "Actualizar Categoria";
            FormularioActualizar.cambiarboton.Text = "Actualizar";
        }

        private void btn_WF_Agregar_Click(object sender, EventArgs e)
        {

            Actualizar_Agregar_Categoria FormularioAgregar = new Actualizar_Agregar_Categoria();
            FormularioAgregar.Show();

            FormularioAgregar.cambiarlabel.Text = "Agregar Categoria";
            FormularioAgregar.cambiarboton.Text = "Agregar";

        }

        private void panel_dgvCategoria_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_WF_CerrarCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
