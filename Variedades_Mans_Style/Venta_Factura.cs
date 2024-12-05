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
    public partial class Venta_Factura : Form
    {
        public Venta_Factura()
        {
            InitializeComponent();
            ConfigurarDGVventa();
        }

        VentaFacturaMCN MetodosVentaFactura = new VentaFacturaMCN();

        private void ImprimirVentas()
        {
            var ventas = MetodosVentaFactura.ObtenerVentasConSucursal();
            DGV_WF_VentaFactura.DataSource = ventas;
            DGV_WF_VentaFactura.Refresh();

        }

        private void ConfigurarDGVventa()
        {
            this.DGV_WF_VentaFactura.DefaultCellStyle.ForeColor = Color.Black;
            DGV_WF_VentaFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGV_WF_VentaFactura.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGV_WF_VentaFactura.AutoGenerateColumns = false;


            DGV_WF_VentaFactura.ReadOnly = true; // Evita que el usuario edite las celdas
            DGV_WF_VentaFactura.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selecciona toda la fila al hacer clic


            DGV_WF_VentaFactura.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID Venta",
                DataPropertyName = "ID_Venta"
            });

            DGV_WF_VentaFactura.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Fecha de Venta",
                DataPropertyName = "Fecha_Venta"
            });

            DGV_WF_VentaFactura.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Cliente",
                DataPropertyName = "NombreCliente"
            });

            DGV_WF_VentaFactura.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Producto",
                DataPropertyName = "NombreProducto"
            });

            DGV_WF_VentaFactura.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Cantidad Comprada",
                DataPropertyName = "Cantidad"
            });

            DGV_WF_VentaFactura.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Precio Vendido",
                DataPropertyName = "PrecioProducto"
            });

            DGV_WF_VentaFactura.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Cantidad",
                DataPropertyName = "Cantidad"
            });

            DGV_WF_VentaFactura.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Subtotal",
                DataPropertyName = "Subtotal"
            });

            DGV_WF_VentaFactura.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Total",
                DataPropertyName = "Total"
            });


            DGV_WF_VentaFactura.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Pagado con",
                DataPropertyName = "pagacon"
            });


            DGV_WF_VentaFactura.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Cambio",
                DataPropertyName = "cambio"
            });

            DGV_WF_VentaFactura.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Venta Hecha en",
                DataPropertyName = "NombreSucursal"
            });


            DGV_WF_VentaFactura.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Venta Hecha por",
                DataPropertyName = "NombreVendedor"
            });

        }

        private void btn_WF_CerrarCompraEntrada_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Venta_Factura_Load(object sender, EventArgs e)
        {
            ImprimirVentas();

        }

        private void VerRegistroVentasPorFecha(){

            try
            {
                // Capturamos las fechas de los DateTimePicker
                DateTime fechaInicio = Fecha1_Venta_Factura.Value.Date;
                DateTime fechaFin = Fecha2_Venta_Factura.Value.Date;

                if (fechaInicio > fechaFin)
                {
                    MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Llamamos al método de la capa negocio
                var negocio = new VentaFacturaMCN(); // Instancia de la clase de negocio
                var ventas = negocio.ObtenerVentasPorFechas(fechaInicio, fechaFin);

                // Mostramos los resultados en un DataGridView
                DGV_WF_VentaFactura.DataSource = ventas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_BuscarVentaFactura_Click(object sender, EventArgs e)
        {
            VerRegistroVentasPorFecha();
        }
    }
}
