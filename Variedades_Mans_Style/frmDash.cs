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
using System.Windows.Forms.DataVisualization.Charting;

namespace Variedades_Man_s_Style
{
    public partial class frmDash : Form
    {
        public frmDash()
        {
            InitializeComponent();
        }

        SucursalMCN MetodosSucursal = new SucursalMCN();

        private void LlenarChartsYSucursalesPrincipal(int idSucursal)
        {
            var productosPorCategoria = MetodosSucursal.ObtenerProductosPorCategoria(idSucursal);
            var top5MayorStock = MetodosSucursal.ObtenerTop5MayorStock(idSucursal);
            var productosBajoStock = MetodosSucursal.ObtenerProductosBajoStock(idSucursal, 10); // Umbral de stock bajo

            // Llenar el gráfico de productos por categoría
            chartCategorias.Series.Clear();
            chartCategorias.Series.Add("ProductosPorCategoria");
            chartCategorias.Series["ProductosPorCategoria"].ChartType = SeriesChartType.Doughnut;
            foreach (var item in productosPorCategoria)
            {
                chartCategorias.Series["ProductosPorCategoria"].Points.AddXY(item.Categoria, item.Cantidad);
            }

            // Llenar el gráfico de top 5 mayor stock
            chartMayorStock.Series.Clear();
            chartMayorStock.Series.Add("Top5MayorStock");
            chartMayorStock.Series["Top5MayorStock"].ChartType = SeriesChartType.Doughnut;
            foreach (var item in top5MayorStock)
            {
                chartMayorStock.Series["Top5MayorStock"].Points.AddXY(item.Nombre, item.Cantidad);
            }

            // Llenar el gráfico de bajo stock
            chartBajoStock.Series.Clear();
            chartBajoStock.Series.Add("BajoStock");
            chartBajoStock.Series["BajoStock"].ChartType = SeriesChartType.Doughnut;
            foreach (var item in productosBajoStock)
            {
                chartBajoStock.Series["BajoStock"].Points.AddXY(item.Nombre, item.Cantidad);
            }
        }

        private void LlenarChartsYSucursalesPrimaria(int idSucursal) // para la primaria
        {
            var productosPorCategoria = MetodosSucursal.ObtenerProductosPorCategoria(idSucursal);
            var top5MayorStock = MetodosSucursal.ObtenerTop5MayorStock(idSucursal);
            var productosBajoStock = MetodosSucursal.ObtenerProductosBajoStock(idSucursal, 10); // Umbral de stock bajo

            // Llenar el gráfico de productos por categoría
            chartcate.Series.Clear();
            chartcate.Series.Add("ProductosPorCategoria");
            chartcate.Series["ProductosPorCategoria"].ChartType = SeriesChartType.Doughnut;
            foreach (var item in productosPorCategoria)
            {
                chartcate.Series["ProductosPorCategoria"].Points.AddXY(item.Categoria, item.Cantidad);
            }

            // Llenar el gráfico de top 5 mayor stock
            chartMstock.Series.Clear();
            chartMstock.Series.Add("Top5MayorStock");
            chartMstock.Series["Top5MayorStock"].ChartType = SeriesChartType.Doughnut;
            foreach (var item in top5MayorStock)
            {
                chartMstock.Series["Top5MayorStock"].Points.AddXY(item.Nombre, item.Cantidad);
            }

            // Llenar el gráfico de bajo stock
            chartBstock.Series.Clear();
            chartBstock.Series.Add("BajoStock");
            chartBstock.Series["BajoStock"].ChartType = SeriesChartType.Doughnut;
            foreach (var item in productosBajoStock)
            {
                chartBstock.Series["BajoStock"].Points.AddXY(item.Nombre, item.Cantidad);
            }
        }



        /* private void CargarProductosPorCategoria(int idSucursal)
         {
             var datos = MetodosSucursal.ObtenerProductosPorCategoria(idSucursal);
             chartCategorias.Series.Clear();
             var serie = chartCategorias.Series.Add("Productos");
             serie.ChartType = SeriesChartType.Bar;

             foreach (var dato in datos)
             {
                 serie.Points.AddXY(dato.Key, dato.Value);
             }
         }*/

        /*private void CargarTop5MayorStock(int idSucursal)
        {
            var datos = MetodosSucursal.ObtenerTop5MayorStock(idSucursal);
            chartMayorStock.Series.Clear();
            var serie = chartMayorStock.Series.Add("Stock");
            serie.ChartType = SeriesChartType.Pie;

            foreach (var dato in datos)
            {
                serie.Points.AddXY(dato.Key, dato.Value);
            }
        }*/

        /*private void CargarBajoStock(int idSucursal)
        {
            var datos = MetodosSucursal.ObtenerProductosBajoStock(idSucursal, 10); // Stock límite: 10
            chartBajoStock.Series.Clear();
            var serie = chartBajoStock.Series.Add("Bajo Stock");
            serie.ChartType = SeriesChartType.Column;

            foreach (var dato in datos)
            {
                serie.Points.AddXY(dato.Key, dato.Value);
            }
        }*/

        /* private void CargarTotalesLabels(int idSucursal)
         {
             var totales = MetodosSucursal.ObtenerTotalesSucursal(idSucursal);

             labelClientes.Text = totales["Clientes"].ToString();
             labelEmpleados.Text = totales["Empleados"].ToString();
             labelProductos.Text = totales["Productos"].ToString();
             labelVentas.Text = totales["Ventas"].ToString();
         }*/

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void LlenarLabelsPrincipal(int idSucursal) // para la princiapl
        {
            var totales = MetodosSucursal.ObtenerTotalesSucursal(idSucursal);

            labelClientes.Text = totales["Clientes"].ToString();
            labelEmpleados.Text = totales["Empleados"].ToString();
            labelProductos.Text = totales["Productos"].ToString();
            labelVentas.Text = totales["Ventas"].ToString();
            labelGanancias.Text = totales["GananciasTotales"].ToString("C2");
            labelMarcas.Text = totales["Marcas"].ToString();
        }

        private void LlenarLabelsPrimaria(int idSucursal) // para la primaria
        {
            var totales = MetodosSucursal.ObtenerTotalesSucursal(idSucursal);

            labelclien.Text = totales["Clientes"].ToString();
            labelemple.Text = totales["Empleados"].ToString();
            labelprodu.Text = totales["Productos"].ToString();
            labelven.Text = totales["Ventas"].ToString();
            labelganan.Text = totales["GananciasTotales"].ToString("C2");
            labelmar.Text = totales["Marcas"].ToString();
        }

        /*private void FrmVentas_Load(object sender, EventArgs e)
        {
            // Asume que idSucursal es el ID de la sucursal específica que quieres mostrar
            int idSucursal = 1;
            LlenarChartsYSucursalesPrincipal(idSucursal);
            LlenarLabelsPrincipal(idSucursal);
        }*/


        private void frmDash_Load(object sender, EventArgs e)
        {

            // Asume que idSucursal es el ID de la sucursal específica que quieres mostrar
            int idSucursal = 1;
            LlenarChartsYSucursalesPrincipal(idSucursal);
            LlenarLabelsPrincipal(idSucursal);

            /*int idSucursalPrincipal = 1; // Cambia este valor según la sucursal principal
            CargarProductosPorCategoria(idSucursalPrincipal);
            CargarTop5MayorStock(idSucursalPrincipal);
            //CargarBajoStock(idSucursalPrincipal);
            CargarTotalesLabels(idSucursalPrincipal);*/

        }

       private void tabPage2_Click(object sender, EventArgs e) // Para la secundaria
        {
            int idsucursal = 2;
            LlenarChartsYSucursalesPrimaria(idsucursal);
            LlenarLabelsPrimaria(idsucursal);
        }

        private void forprincipal_Click(object sender, EventArgs e) // para la princiapal
        {



        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {


        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                int idSucursal = 1;
                LlenarChartsYSucursalesPrincipal(idSucursal);
                LlenarLabelsPrincipal(idSucursal);
                MessageBox.Show("Estás en la primera pestaña");
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                int idsucursal = 2;
                LlenarChartsYSucursalesPrimaria(idsucursal);
                LlenarLabelsPrimaria(idsucursal);
                MessageBox.Show("Estás en la segunda pestaña");
            }
        }
    }
}
