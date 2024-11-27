using CapaDatos;
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
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();

        }

        CategoriaMCN MetodosCategoria = new CategoriaMCN();

        private void imprimirRegistroCategorias()
        {

            var compras = MetodosCategoria.ObtenerCategoriasActivas();
            dgvVerCategorias.DataSource = compras;
            dgvVerCategorias.Refresh(); // Fuerza el refresco del control

        }

        private void Categoria_Load(object sender, EventArgs e)
        {

            ConfigureDataGridView();
            imprimirRegistroCategorias();

        }


        private void Panel_WF_Controles_Proveedor_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btn_WF_Actualizar_Click(object sender, EventArgs e)
        {
            // Verificar que haya una fila seleccionada
            if (dgvVerCategorias.SelectedRows.Count == 0) { 

                MessageBox.Show("Por favor, selecciona una categoría para actualizar."); 
                return; 
            }

            Actualizar_Agregar_Categoria FormularioActualizar = new Actualizar_Agregar_Categoria();

            FormularioActualizar.CategoriaAgregada += FormularioActualizar_CategoriaActualizada;

            var filaSeleccionada = dgvVerCategorias.SelectedRows[0];
            var categoriaSeleccionada = (CategoriaDTO)filaSeleccionada.DataBoundItem;

            FormularioActualizar.cambiarlabel.Text = "Actualizar Categoria";
            FormularioActualizar.cambiarboton.Text = "Actualizar";
            FormularioActualizar.cambiartextbox.Text = categoriaSeleccionada.Nombre;
            FormularioActualizar.CategoriaID = categoriaSeleccionada.ID_Categoria;

            FormularioActualizar.Show();


        }

        private void btn_WF_Agregar_Click(object sender, EventArgs e)
        {

            Actualizar_Agregar_Categoria FormularioAgregar = new Actualizar_Agregar_Categoria();

            FormularioAgregar.CategoriaAgregada += FormularioAgregar_CategoriaAgregada;
            FormularioAgregar.cambiarlabel.Text = "Agregar Categoria";
            FormularioAgregar.cambiarboton.Text = "Agregar";

            FormularioAgregar.Show();


        }

        private void FormularioAgregar_CategoriaAgregada(object sender, EventArgs e) { 

            imprimirRegistroCategorias();
        }

        private void FormularioActualizar_CategoriaActualizada(object sender, EventArgs e) { 

            imprimirRegistroCategorias();

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


        private void ConfigureDataGridView()
        {
            this.dgvVerCategorias.DefaultCellStyle.ForeColor = Color.Black;

            dgvVerCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvVerCategorias.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvVerCategorias.ReadOnly = true; // Evita que el usuario edite las celdas
            dgvVerCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selecciona toda la fila al hacer clic
            dgvVerCategorias.AutoGenerateColumns = false;

            // Configuración de columnas

            dgvVerCategorias.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Estado",
                DataPropertyName = "NombreEstado"
            });

            dgvVerCategorias.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID Categoria",
                DataPropertyName = "ID_Categoria"
            });

            dgvVerCategorias.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nombre",
                DataPropertyName = "Nombre"
            });


        }

        private void btn_WF_Desactivar_Click(object sender, EventArgs e)
        {

            // Verificar que haya una fila seleccionada
            if (dgvVerCategorias.SelectedRows.Count == 0)
            {

                MessageBox.Show("Por favor, selecciona una categoría para Remover.");
                return;
            }

            var filaSeleccionada = dgvVerCategorias.SelectedRows[0];
            var categoriaSeleccionada = (CategoriaDTO)filaSeleccionada.DataBoundItem;

            CategoriaDTO namecate = new CategoriaDTO();

            namecate = new CategoriaDTO()
            {
                ID_Categoria = categoriaSeleccionada.ID_Categoria,
                Estado = 0,

            };

            bool resultado = MetodosCategoria.EliminarCategoria(namecate);

            if (resultado)
            {

                MessageBox.Show("Se removio la categoria");
                imprimirRegistroCategorias();

            }
            else
            {
                MessageBox.Show("No se removio la categoria");
            }

            /*FormularioActualizar.cambiarlabel.Text = "Actualizar Categoria";
            FormularioActualizar.cambiarboton.Text = "Actualizar";
            FormularioActualizar.cambiartextbox.Text = categoriaSeleccionada.Nombre;
            FormularioActualizar.CategoriaID = categoriaSeleccionada.ID_Categoria;

            FormularioActualizar.Show();*/

        }
    }
}
