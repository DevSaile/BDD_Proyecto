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
    public partial class BuscarProductoExistente : Form
    {

        private Timer searchTimer; // Timer para retrasar la búsqueda
        public delegate void ProductoSeleccionadoHandler(int idProducto);
        public event ProductoSeleccionadoHandler ProductoSeleccionado;

        public BuscarProductoExistente()
        {
            InitializeComponent();
            ConfigureSearchTimer();
        }

        ProductoMCN MetodosProducto = new ProductoMCN();
        Compra_EntradaMCN MetodosCompraEntrada = new Compra_EntradaMCN();



        private void ConfigureDataGridViewProductos()
        {
            this.dgvVerProductosExis.DefaultCellStyle.ForeColor = Color.Black;

            dgvVerProductosExis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvVerProductosExis.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvVerProductosExis.ReadOnly = true; // Evita que el usuario edite las celdas
            dgvVerProductosExis.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selecciona toda la fila al hacer clic
            dgvVerProductosExis.AutoGenerateColumns = false;

            // Configuración de columnas
            dgvVerProductosExis.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID Producto",
                DataPropertyName = "ID_Producto"
            });

            dgvVerProductosExis.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Producto",
                DataPropertyName = "Nombre"
            });

            dgvVerProductosExis.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Marca",
                DataPropertyName = "Marca"
            });

            dgvVerProductosExis.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Cantidad",
                DataPropertyName = "Cantidad"
            });

            dgvVerProductosExis.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Precio de Producto",
                DataPropertyName = "Precio_Producto"
            });


            dgvVerProductosExis.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Detalles",
                DataPropertyName = "Detalles"
            });

            dgvVerProductosExis.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Estado de venta",
                DataPropertyName = "EstadoProducto"
            });

            dgvVerProductosExis.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Sucursal",
                DataPropertyName = "versucu"
            });

            dgvVerProductosExis.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Categoria",
                DataPropertyName = "Descripcion_Categoria"
            });




        }

        private void txt_BuscarProducto_TextChanged(object sender, EventArgs e)
        {
            searchTimer.Stop(); // Detiene el timer en cada cambio de texto
            searchTimer.Start(); // Reinicia el timer
        }

        private void ConfigureSearchTimer()
        {
            searchTimer = new Timer();
            searchTimer.Interval = 300; // Retraso de 300 ms
            searchTimer.Tick += SearchTimer_Tick;
        }

        private void imprimirBusquedaProductos(string nombre)
        {
            var productos = MetodosProducto.BuscarProductosHEAVY(nombre: nombre);

            if (productos.Any())
            {
                dgvVerProductosExis.DataSource = productos;
            }
            else
            {
                dgvVerProductosExis.DataSource = null;
                //MessageBox.Show("No se encontraron coincidencias.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgvVerProductosExis.Refresh(); // Fuerza el refresco del control
        }

        private void ImprimirProductos()
        {
            var productos = MetodosProducto.verproductos();
            dgvVerProductosExis.DataSource = productos;
            dgvVerProductosExis.Refresh();

        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop(); // Detiene el timer para evitar múltiples ejecuciones
            string textoBusqueda = txt_BuscarProducto.Text.Trim();

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                ImprimirProductos(); // Si está vacío, muestra todos los registros
            }
            else
            {
                imprimirBusquedaProductos(textoBusqueda); // Realiza la búsqueda
            }
        }

        private void BuscarProductoExistente_Load(object sender, EventArgs e)
        {
            ConfigureDataGridViewProductos();
        }
            
        private void btn_SeleccionarProducto_Click(object sender, EventArgs e)
        {

            if (dgvVerProductosExis.SelectedRows.Count == 0)
            {

                MessageBox.Show("Por favor, selecciona un producto.");
                return;
            }

            var filaSeleccionada = dgvVerProductosExis.SelectedRows[0];
            var productoSeleccionado = (ProductoDTO)filaSeleccionada.DataBoundItem;


            ProductoSeleccionado?.Invoke(productoSeleccionado.ID_Producto);
            this.Close();

        }
    }
}
