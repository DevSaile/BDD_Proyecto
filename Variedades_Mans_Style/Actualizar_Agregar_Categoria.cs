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
    public partial class Actualizar_Agregar_Categoria : Form
    {

        // Define un delegado y un evento

        public delegate void CategoriaAgregadaHandler(object sender, EventArgs e);
        public event CategoriaAgregadaHandler CategoriaAgregada;

        public Actualizar_Agregar_Categoria()
        {
            InitializeComponent();
        }


        //public Actualizar_Agregar_Categoria(int ID_Categoria)
        //{
        //    InitializeComponent();

        //}

        CategoriaMCN MetodosCategoria = new CategoriaMCN();
        public int? CategoriaID { get; set; }

        public void AgregarCategoria()
        {
            CategoriaDTO namecate = new CategoriaDTO();

            namecate = new CategoriaDTO()
            {

                Nombre = txt_NombreCategoria.Text,
                Estado = 1


            };
    
            bool resultado = MetodosCategoria.AgregarCategoria(namecate);

            if (resultado)
            {

                MessageBox.Show($"Se agrego la categoria {namecate.Nombre}");

                CategoriaAgregada?.Invoke(this, EventArgs.Empty);

                this.Close();

            }
            else
            {
                MessageBox.Show($"No Se agrego la categoria {namecate.Nombre}");
            }

        }

        public void ActualizarCategoria()
        {
            CategoriaDTO namecate = new CategoriaDTO();

            namecate = new CategoriaDTO()
            {
                ID_Categoria = CategoriaID,
                Nombre = txt_NombreCategoria.Text,

            };

            bool resultado = MetodosCategoria.ActualizarCategoria(namecate);

            if (resultado)
            {

                MessageBox.Show("Se actualizo la categoria");

                CategoriaAgregada?.Invoke(this, EventArgs.Empty);

                this.Close();

            }
            else
            {
                MessageBox.Show("No se actualizo la categoria");
            }

        }
        private void btn_Agregar_Actualizar_Categoria_Click(object sender, EventArgs e)
        {
            //  ESTO DE AQUI ES PARA CUANDO AGREGUE LA CATEGORIA

            if (txt_NombreCategoria.Text == string.Empty || MetodosCategoria.ObtenerNombreCategoria(txt_NombreCategoria.Text) != null)
            {

                MessageBox.Show("Nombre ivalido o ya existe una categoria con ese nombre");
                return;
            }   

            if (label_Actualizar_Agregar_Categoria.Text == "Agregar Categoria")
            {
                AgregarCategoria();

            }
            else
            {
                ActualizarCategoria();
            }

            // FIN DE AGREGAR NUEVA CATEGORIA

            // ESTO DE AQUI ES CUANDO ACTUALIZA


        }

        public Label cambiarlabel {  // Aqui basicamente vamos a cambiar lo que dice el label

            get { return label_Actualizar_Agregar_Categoria; } 

        }

        public Button cambiarboton{  // Aqui basicamente vamos a cambiar lo que dice el boton

            get { return btn_Agregar_Actualizar_Categoria; }

        }

        public TextBox cambiartextbox
        {  // Aqui basicamente vamos a cambiar lo que dice el boton

            get { return txt_NombreCategoria; }

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
