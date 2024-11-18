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
            ConfigureDataGridView();
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

            DGV_WF_Proveedor.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID Entrada",
                DataPropertyName = "ID_Entrada"
            });

            DGV_WF_Proveedor.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Proveedor",
                DataPropertyName = "Nombre_Proveedor"
            });

            DGV_WF_Proveedor.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Producto",
                DataPropertyName = "Nombre_Producto"
            });

            DGV_WF_Proveedor.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Fecha de Compra",
                DataPropertyName = "Fecha_Compra"
            });

            // Configura otras columnas según sea necesario
        }


        private void imprimirRegistroCompraEntrada()
        {

            DGV_WF_Proveedor.DataSource = null;
            DGV_WF_Proveedor.DataSource = MetodosCompraEntrada.VerRegistroCompraEntrada();
            DGV_WF_Proveedor.Refresh(); // Fuerza el refresco del control

        }

        private void WF_CompraEntrada_Load(object sender, EventArgs e)
        {
            imprimirRegistroCompraEntrada();


        }

        private void btn_WF_CerrarProveedor_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
