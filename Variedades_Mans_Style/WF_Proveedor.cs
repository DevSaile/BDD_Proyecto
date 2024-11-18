using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Drawing2D;


namespace Variedades_Man_s_Style
{
    public partial class WF_Proveedor : Form
    {

        public WF_Proveedor()
        {
            InitializeComponent();
            /*this.Paint += new PaintEventHandler(Panel_WF_Controles_Proveedor_Paint);*/
        }


        //Esto de aqui es por si quiero mover el formulario

        /* #region Drag Form/ Mover Arrastrar Formulario

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void WF_Proveedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel_WF_Info_Proveedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel_WF_Controles_Proveedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion */



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void WF_Proveedor_Load(object sender, EventArgs e)
        {

        }

        private void Panel_Controles_Provedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_WF_Eliminar_Click(object sender, EventArgs e)
        {

        }

        /*private void Panel_WF_Info_Proveedor_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; 
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height); 

            // Crear el degradado radial

            using (GraphicsPath path = new GraphicsPath()) { 

                path.AddEllipse(rect); 

                using (PathGradientBrush brush = new PathGradientBrush(path)) { 

                    brush.CenterColor = Color.Black; 

                    brush.SurroundColors = new Color[] { ColorTranslator.FromHtml("#1162ac") }; 
                    g.FillRectangle(brush, rect);

                } 
            }

        }*/

        private void DGV_WF_Proveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_WF_CerrarProveedor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel_WF_Controles_Proveedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_WF_Actualizar_Click(object sender, EventArgs e)
        {

            Actualizar_Agregar_Proveedor FormularioActualizar = new Actualizar_Agregar_Proveedor();
            FormularioActualizar.Show();

            FormularioActualizar.cambiarlabel.Text = "Actualizar Proveedor";
            FormularioActualizar.cambiarboton.Text = "Actualizar";


        }

        private void btn_WF_Agregar_Click(object sender, EventArgs e)
        {

            Actualizar_Agregar_Proveedor FormularioAgregar = new Actualizar_Agregar_Proveedor();
            FormularioAgregar.Show();

            FormularioAgregar.cambiarlabel.Text = "Agregar Proveedor";

            FormularioAgregar.cambiarboton.Text = "Agregar";

        }

        /*private void btn_WF_Buscar_Click(object sender, EventArgs e)
        {

            BuscarProovedor FormularioBuscar = new BuscarProovedor();
            FormularioBuscar.Show();


        }*/
    }
}
