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
using System.Windows.Controls;
using System.Windows.Forms;


namespace Variedades_Man_s_Style
{
    public partial class frmProductos : Form
    {

        public frmProductos()
        {
            InitializeComponent();

            llenarCOMBOBOX();
        }

        ProductoMCN MetodosProducto = new ProductoMCN();
        CategoriaMCN MetodosCategoria = new CategoriaMCN();
        SucursalMCN MetodosSucursal = new SucursalMCN();

        private void llenarCOMBOBOX()
        {
            var sucursales = MetodosSucursal.ObtenerSucursales();
            cbBuscarPorSucursal.DataSource = sucursales;
            cbBuscarPorSucursal.DisplayMember = "Nombre";
            cbBuscarPorSucursal.ValueMember = "ID_Sucursal";

            var categorias = MetodosCategoria.ObtenerCategoriasActivas();
            cbBuscarCategoria.DataSource = categorias;
            cbBuscarCategoria.DisplayMember = "Nombre";
            cbBuscarCategoria.ValueMember = "ID_Categoria";


        }



        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel_DatosProveedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_Nombre_Click(object sender, EventArgs e)
        {

        }

        private void label_Numero_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_Direccion_Click(object sender, EventArgs e)
        {

        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            ImprimirProductos();

        }

        private void ConfigureDataGridView()
        {
            this.dgvVerProductos.DefaultCellStyle.ForeColor = Color.Black;

            dgvVerProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvVerProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvVerProductos.ReadOnly = true; // Evita que el usuario edite las celdas
            dgvVerProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selecciona toda la fila al hacer clic
            dgvVerProductos.AutoGenerateColumns = false;

            // Configuración de columnas
            dgvVerProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID Producto",
                DataPropertyName = "ID_Producto"
            });

            /*dgvVerProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Estado de venta",
                DataPropertyName = "EstadoProducto"
            });*/


            dgvVerProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Sucursal",
                DataPropertyName = "versucu"
            });

            dgvVerProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Categoria",
                DataPropertyName = "Descripcion_Categoria"
            });

            dgvVerProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Producto",
                DataPropertyName = "Nombre"
            });

            dgvVerProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Marca",
                DataPropertyName = "Marca"
            });

            dgvVerProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Cantidad",
                DataPropertyName = "Cantidad"
            });

            dgvVerProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Precio de Producto",
                DataPropertyName = "Precio_Producto"
            });


            dgvVerProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Detalles",
                DataPropertyName = "Detalles"
            });


        }

        private bool ValidarTextBoxIndividuales(System.Windows.Forms.TextBox textBox, string nombreCampo)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show($"El campo '{nombreCampo}' no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return false;
            }
            return true;
        }




        private void cbBuscarPorSucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // DESACTIVMOS LA ENTRADA POR EL TECLADO PARA LA COMBOBOX


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Label_Productos_Click(object sender, EventArgs e)
        {

        }

        private void btn_CancelarProveedor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_WF_CerraProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarProduNombre_Click(object sender, EventArgs e)
        {
            if (ValidarTextBoxIndividuales(txt_NombreProducto, "Nombre de Producto"))
            {
                // Lógica para guardar datos.
                //MessageBox.Show("Todos los campos están llenos. Procediendo con la operación.");

                List<ProductoDTO> verprodunomnbre = MetodosProducto.BuscarPorNombre(txt_NombreProducto.Text);

                if (verprodunomnbre == null || verprodunomnbre.Count == 0)
                {
                    MessageBox.Show($"No se ha encontrado ningun producto con nombre {txt_NombreProducto.Text}");
                    return;
                }


                dgvVerProductos.DataSource = verprodunomnbre;
                dgvVerProductos.Refresh();
            }
        }

        private void btnBucarProduID_Click(object sender, EventArgs e)
        {
            if (ValidarTextBoxIndividuales(txt_IdProducto, "ID de Producto"))
            {

                var verproduid = MetodosProducto.BuscarPorIDLista(int.Parse(txt_IdProducto.Text));


                if (verproduid == null)
                {
                    MessageBox.Show($"No se ha encontrado ningun producto con id {txt_IdProducto.Text}");
                    return;
                }


                dgvVerProductos.DataSource = verproduid;
                dgvVerProductos.Refresh();

            }
        }

        private void BuscarPorCategoria_Click(object sender, EventArgs e)
        {
            List<ProductoDTO> verproducategoria = MetodosProducto.BuscarPorCategoria((int)cbBuscarCategoria.SelectedValue);


            if (verproducategoria == null || verproducategoria.Count == 0)
            {
                MessageBox.Show($"No se ha encontrado ningun producto en la categoria {cbBuscarCategoria.SelectedText}");
                return;
            }


            dgvVerProductos.DataSource = verproducategoria;
            dgvVerProductos.Refresh();
        }

        private void btnBuscarSucursal_Click(object sender, EventArgs e)
        {
            List<ProductoDTO> verproduSucursal = MetodosProducto.BuscarPorSucursal((int)cbBuscarPorSucursal.SelectedValue);


            if (verproduSucursal == null || verproduSucursal.Count == 0)
            {
                MessageBox.Show($"No se ha encontrado ningun producto en la Sucursal {cbBuscarPorSucursal.SelectedText}");
                return;
            }


            dgvVerProductos.DataSource = verproduSucursal;
            dgvVerProductos.Refresh();
        }

        private void dgvVerProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarProduNombre_MouseMove(object sender, MouseEventArgs e)
        {

            // Cambiar la imagen al pasar el ratón
            //btnBuscarProduNombre.Image = ImagenReemplazo;
        }

        private void btnBuscarProduNombre_MouseLeave(object sender, EventArgs e)
        {
            //btnBuscarProduNombre.Image = ImagenOriginal;
        }

        private void cbBuscarCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ImprimirProductos()
        {
            var verproductos = MetodosProducto.verproductos();
            dgvVerProductos.DataSource = verproductos;
            dgvVerProductos.Refresh();
        }

        private void FormularioActualizar_ProductoActualizada(object sender, EventArgs e)
        {

            ImprimirProductos();
        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {

            // Verificar que haya una fila seleccionada
            if (dgvVerProductos.SelectedRows.Count == 0)
            {

                MessageBox.Show("Por favor, selecciona una empleado para actualizar.");
                return;
            }

            ProductosActualizar FormularioActualizar = new ProductosActualizar();

            FormularioActualizar.ProductoActualizado += FormularioActualizar_ProductoActualizada;

            var filaSeleccionada = dgvVerProductos.SelectedRows[0];
            var categoriaSeleccionada = (ProductoDTO)filaSeleccionada.DataBoundItem;

            FormularioActualizar.idProducto = categoriaSeleccionada.ID_Producto;

            FormularioActualizar.Show();
        }

        private void btnDesactivarProducto_Click(object sender, EventArgs e)
        {
            var filaSeleccionada = dgvVerProductos.SelectedRows[0];
            var productoSeleccionado = (ProductoDTO)filaSeleccionada.DataBoundItem;

            ProductoDTO actuProducto = new ProductoDTO();

            actuProducto = new ProductoDTO()
            {

                ID_Producto = productoSeleccionado.ID_Producto,
                Estado = 0

            };

            int resulPRO = MetodosProducto.KILLProductoExistente(actuProducto);

            if (resulPRO != -1)
            {

                MessageBox.Show($" Removido hecho papa");
                ImprimirProductos();

            }
            else
            {
                MessageBox.Show($" No Removido no hecho pipipi");

            }


        }
    }
}
