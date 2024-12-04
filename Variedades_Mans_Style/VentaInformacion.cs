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
    public partial class VentaInformacion : Form
    {

        private Timer searchTimer; // Timer para retrasar la búsqueda
        public delegate void objetoSeleccionadoHandler(int idobjeto, int idcampo);
        public event objetoSeleccionadoHandler objetoseleccionado;

        public VentaInformacion()
        {
            InitializeComponent();
            ConfigureSearchTimer();
            ConfigurarComboBoxBusqueda();
        }


        ClienteMCN MetodosCliente = new ClienteMCN();
        ProductoMCN MetodosProducto = new ProductoMCN();
        EmpleadoMCN MetodosEmpleados = new EmpleadoMCN();
        VentaFacturaMCN MetodosVentaFactura = new VentaFacturaMCN();

        private void ConfigureDataGridViewClientes()
        {
            this.dgvVerCoincidencias.DefaultCellStyle.ForeColor = Color.Black;

            dgvVerCoincidencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvVerCoincidencias.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvVerCoincidencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dgvVerCoincidencias.ReadOnly = true; // Evita que el usuario edite las celdas
            dgvVerCoincidencias.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selecciona toda la fila al hacer clic
            dgvVerCoincidencias.AutoGenerateColumns = false;

            // Configuración de columnas

            dgvVerCoincidencias.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID Cliente",
                DataPropertyName = "ID_Cliente",

            });


            /*dgvVerCoincidencias.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Estado",
                DataPropertyName = "NombreEstado",

            });*/


            dgvVerCoincidencias.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",

            });

            ImprimirCoincidencias();


        }
        private void ConfigurarComboBoxBusqueda()
        {
            cbElegirBusqueda.Items.Add("Cliente");
            cbElegirBusqueda.Items.Add("Vendedor");
            cbElegirBusqueda.Items.Add("Producto");
            cbElegirBusqueda.SelectedIndex = 0; // Seleccionar el primer ítem por defecto
        }



        private void ConfigureDataGridViewEmpleado()
        {
            this.dgvVerCoincidencias.DefaultCellStyle.ForeColor = Color.Black;

            dgvVerCoincidencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvVerCoincidencias.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvVerCoincidencias.ReadOnly = true; // Evita que el usuario edite las celdas
            dgvVerCoincidencias.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selecciona toda la fila al hacer clic
            dgvVerCoincidencias.AutoGenerateColumns = false;

            // Configuración de columnas

            dgvVerCoincidencias.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID Empleado",
                DataPropertyName = "ID_Empleado"
            });

            /*dgvVerCoincidencias.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Estado",
                DataPropertyName = "NombreEstado"
            });*/


            dgvVerCoincidencias.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nombre",
                DataPropertyName = "Nombre"
            });


            /*dgvVerCoincidencias.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Cedula",
                DataPropertyName = "Cedula"
            });*/


            /*dgvVerCoincidencias.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Edad",
                DataPropertyName = "Edad"
            });*/

            dgvVerCoincidencias.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Rol",
                DataPropertyName = "NombreRol"
            });


            dgvVerCoincidencias.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Sucursal",
                DataPropertyName = "NombreSucursal"
            });

            ImprimirCoincidencias();


        }



        private void ConfigureDataGridViewProductos()
        {
            this.dgvVerCoincidencias.DefaultCellStyle.ForeColor = Color.Black;

            dgvVerCoincidencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvVerCoincidencias.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvVerCoincidencias.ReadOnly = true; // Evita que el usuario edite las celdas
            dgvVerCoincidencias.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selecciona toda la fila al hacer clic
            dgvVerCoincidencias.AutoGenerateColumns = false;

            // Configuración de columnas
            dgvVerCoincidencias.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID Producto",
                DataPropertyName = "ID_Producto"
            });

            dgvVerCoincidencias.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Producto",
                DataPropertyName = "Nombre"
            });

            dgvVerCoincidencias.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Marca",
                DataPropertyName = "Marca"
            });

            dgvVerCoincidencias.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Cantidad",
                DataPropertyName = "Cantidad"
            });

            dgvVerCoincidencias.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Precio de Producto",
                DataPropertyName = "Precio_Producto"
            });


            dgvVerCoincidencias.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Detalles",
                DataPropertyName = "Detalles"
            });

            /*dgvVerCoincidencias.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Estado de venta",
                DataPropertyName = "EstadoProducto"
            });*/

            dgvVerCoincidencias.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Sucursal",
                DataPropertyName = "Descripcion_Sucursal"
            });

            dgvVerCoincidencias.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Categoria",
                DataPropertyName = "Descripcion_Categoria"
            });

            ImprimirCoincidencias();


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

        private void imprimirBusquedaCoincidencias(string valorBusqueda)
        {

            string criterio = cbElegirBusqueda.SelectedItem.ToString().ToLower();

            var resultado = MetodosVentaFactura.BuscarRegistros(criterio, valorBusqueda);

            if (resultado is List<ClienteDTO> clientes)
            {
                // Mostrar clientes en tu DataGridView
                dgvVerCoincidencias.DataSource = clientes;
            }
            else if (resultado is List<ProductoDTO> productos)
            {
                // Mostrar productos en tu DataGridView
                dgvVerCoincidencias.DataSource = productos;
            }
            else if (resultado is List<EmpleadoDTO> vendedores)
            {
                // Mostrar vendedores en tu DataGridView
                dgvVerCoincidencias.DataSource = vendedores;
            }
            else
            {
                MessageBox.Show("No se encontraron registros.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void ImprimirCoincidencias()
        {
            string seleccion = cbElegirBusqueda.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(seleccion))
            {
                MessageBox.Show("Por favor selecciona un criterio de búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<object> resultados = null;

            if (seleccion == "Cliente")
            {
                resultados = MetodosCliente.ObtenerClientesActivos()?.Cast<object>().ToList();
            }
            else if (seleccion == "Producto")
            {
                resultados = MetodosProducto.verproductos()?.Cast<object>().ToList();
            }
            else if (seleccion == "Vendedor")
            {
                resultados = MetodosEmpleados.ObtenerVendedorActivos()?.Cast<object>().ToList();
            }

            if (resultados == null || !resultados.Any())
            {
                MessageBox.Show($"No se encontraron coincidencias para {seleccion}.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvVerCoincidencias.DataSource = null; // Limpia el DataGridView
            }
            else
            {
                dgvVerCoincidencias.DataSource = resultados;
            }
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop(); // Detiene el timer para evitar múltiples ejecuciones

            string textoBusqueda = txt_BuscarProducto.Text.Trim();

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                ImprimirCoincidencias(); // Si está vacío, muestra todos los registros
            }
            else
            {
                imprimirBusquedaCoincidencias(textoBusqueda); // Realiza la búsqueda
            }
        }

        private void BuscarProductoExistente_Load(object sender, EventArgs e)
        {
            //ConfigureDataGridViewProductos();
        }

        private void btn_SeleccionarProducto_Click(object sender, EventArgs e)
        {

            if (dgvVerCoincidencias.SelectedRows.Count == 0)
            {

                MessageBox.Show("Por favor, selecciona un registro.");
                return;
            }

            string seleccion = cbElegirBusqueda.SelectedItem?.ToString();

            if (seleccion == "Cliente")
            {
                int idclien = 1;
                var filaSeleccionada = dgvVerCoincidencias.SelectedRows[0];
                var ClienteSeleccionado = (ClienteDTO)filaSeleccionada.DataBoundItem;


                objetoseleccionado?.Invoke(ClienteSeleccionado.ID_Cliente, idclien);
                this.Close();
            }
            else if (seleccion == "Producto")
            {

                int idprodu = 2;
                var filaSeleccionada = dgvVerCoincidencias.SelectedRows[0];
                var productoSeleccionado = (ProductoDTO)filaSeleccionada.DataBoundItem;


                objetoseleccionado?.Invoke(productoSeleccionado.ID_Producto, idprodu);
                this.Close();
            }
            else if (seleccion == "Vendedor")
            {
                int idvende = 3;

                var filaSeleccionada = dgvVerCoincidencias.SelectedRows[0];
                var VendedorSeleccionado = (EmpleadoDTO)filaSeleccionada.DataBoundItem;


                objetoseleccionado?.Invoke(VendedorSeleccionado.ID_Empleado, idvende);
                this.Close();
            }


        }

        private void cbElegirBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = cbElegirBusqueda.SelectedItem.ToString();

            // Limpiar las columnas del DataGridView
            dgvVerCoincidencias.Columns.Clear();

            switch (seleccion)
            {
                case "Cliente":
                    ConfigureDataGridViewClientes();
                    break;
                case "Vendedor":
                    ConfigureDataGridViewEmpleado();
                    break;
                case "Producto":
                    ConfigureDataGridViewProductos();
                    break;
                default:
                    MessageBox.Show("Selección no válida.");
                    break;
            }

        }
    }
}
