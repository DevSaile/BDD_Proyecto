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

        private void Categoria_Load(object sender, EventArgs e)
        {

            ConfigureDataGridView();
            imprimirRegistroCategorias();

        }


        private void Panel_WF_Controles_Proveedor_Paint(object sender, PaintEventArgs e)
        {

        }


        private void imprimirRegistroCategorias()
        {

            var compras = MetodosCategoria.ObtenerCategorias();
            dgvVerCategorias.DataSource = compras;
            dgvVerCategorias.Refresh(); // Fuerza el refresco del control

        }

        private void btn_WF_Actualizar_Click(object sender, EventArgs e)
        {

            Actualizar_Agregar_Categoria FormularioActualizar = new Actualizar_Agregar_Categoria();

            FormularioActualizar.cambiarlabel.Text = "Actualizar Categoria";
            FormularioActualizar.cambiarboton.Text = "Actualizar";


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
                DataPropertyName = "Estado"
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


    }
}
