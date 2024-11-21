using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocios;

namespace Variedades_Man_s_Style
{
    public partial class WF_CompraEntrada : Form
    {
        public WF_CompraEntrada()
        {
            InitializeComponent();
            /*this.Load += new EventHandler(WF_CompraEntrada_Load);*/
        }

        Compra_EntradaMCN MetodosCompraEntrada = new Compra_EntradaMCN();

        private void Label_CompraEntrada_Click(object sender, EventArgs e)
        {

        }

        private void Fecha1_CompraEntrada_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Fecha2_CompraEntrada_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Panel_WF_Info_Proveedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_Agregar_Click(object sender, EventArgs e)
        {

        }

        private void ConfigureDataGridView()
        {
            this.DGV_WF_Proveedor.DefaultCellStyle.ForeColor = Color.Black;

            DGV_WF_Proveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGV_WF_Proveedor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGV_WF_Proveedor.ReadOnly = true; // Evita que el usuario edite las celdas
            DGV_WF_Proveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selecciona toda la fila al hacer clic
            DGV_WF_Proveedor.AutoGenerateColumns = false;

            // Configuración de columnas
            DGV_WF_Proveedor.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID Entrada",
                DataPropertyName = "ID_Entrada"
            });

            DGV_WF_Proveedor.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Categoría",
                DataPropertyName = "Nombre_Categoria"
            });

            DGV_WF_Proveedor.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID Producto",
                DataPropertyName = "ID_Producto"
            });

            DGV_WF_Proveedor.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Producto",
                DataPropertyName = "Nombre_Producto"
            });

            DGV_WF_Proveedor.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Marca",
                DataPropertyName = "Marca"
            });

            DGV_WF_Proveedor.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Cantidad",
                DataPropertyName = "CantidadCompra"
            });

            DGV_WF_Proveedor.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Precio de Compra",
                DataPropertyName = "Precio_Compra"
            });

            /*DGV_WF_Proveedor.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Precio de Producto",
                DataPropertyName = "Precio_Producto"
            });*/

            DGV_WF_Proveedor.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Detalles",
                DataPropertyName = "Detalles"
            });

            DGV_WF_Proveedor.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Detalle Sucursal",
                DataPropertyName = "Descripcion_Sucursal"
            });


            DGV_WF_Proveedor.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Sucursal",
                DataPropertyName = "Nombre_Sucursal"
            });

            DGV_WF_Proveedor.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Fecha de Compra",
                DataPropertyName = "Fecha_Compra"
            });

        }


        private void imprimirRegistroCompraEntrada()
        {

            var compras = MetodosCompraEntrada.VerRegistroCompraEntrada();
            DGV_WF_Proveedor.DataSource = compras;
            DGV_WF_Proveedor.Refresh(); // Fuerza el refresco del control

        }

        private void WF_CompraEntrada_Load(object sender, EventArgs e)
        {

            ConfigureDataGridView();

            imprimirRegistroCompraEntrada();

        }

        private void btn_WF_CerrarProveedor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGV_WF_Proveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
