using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class VentaFacturaMCN
    {
        private readonly bddVariedadesMansStyleEntities db;

        public VentaFacturaMCN()
        {
            db = new bddVariedadesMansStyleEntities();

        }

        public int AgregarVenta(Venta_FacturaDTO venta)
        {
            try
            {
                Venta_Factura newVenta = new Venta_Factura
                {
                    Estado = venta.Estado,
                    ID_Cliente = venta.ID_Cliente,
                    ID_Producto = venta.ID_Producto,
                    ID_Vendedor = venta.ID_Vendedor,
                    Fecha_Venta = venta.Fecha_Venta,
                    Cantidad = venta.Cantidad,
                    Subtotal = venta.Subtotal,
                    Total = venta.Total,
                    PrecioProducto = venta.PrecioProducto,
                    Paga = venta.pagacon,
                    Cambio = venta.cambio
                };

                db.Venta_Factura.Add(newVenta);
                db.SaveChanges();
                return newVenta.ID_Venta;
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                return -1;
            }
        }

        public bool ActualizarVenta(Venta_FacturaDTO venta)
        {
            try
            {
                Venta_Factura existingVenta = db.Venta_Factura.Find(venta.ID_Venta);
                if (existingVenta == null) return false;

                existingVenta.Estado = venta.Estado;
                existingVenta.ID_Cliente = venta.ID_Cliente;
                existingVenta.ID_Producto = venta.ID_Producto;
                existingVenta.ID_Vendedor = venta.ID_Vendedor;
                existingVenta.Fecha_Venta = venta.Fecha_Venta;
                existingVenta.Cantidad = venta.Cantidad;
                existingVenta.Subtotal = venta.Subtotal;
                existingVenta.Total = venta.Total;
                existingVenta.PrecioProducto = venta.PrecioProducto;
                existingVenta.Paga = venta.pagacon;
                existingVenta.Cambio = venta.cambio;

                db.Entry(existingVenta).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                return false;
            }
        }

        public bool EliminarVenta(Venta_FacturaDTO venta)
        {
            try
            {
                Venta_Factura existingVenta = db.Venta_Factura.Find(venta.ID_Venta);
                if (existingVenta == null) return false;

                existingVenta.Estado = venta.Estado;

                db.Entry(existingVenta).State = EntityState.Modified;
                db.SaveChanges();


                return true;
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                return false;
            }
        }

        public Venta_FacturaDTO ObtenerVentaPorId(int idVenta)
        {
            try
            {
                Venta_Factura venta = db.Venta_Factura.Find(idVenta);
                if (venta == null) return null;

                return new Venta_FacturaDTO
                {
                    ID_Venta = venta.ID_Venta,
                    Estado = venta.Estado,
                    ID_Cliente = venta.ID_Cliente,
                    ID_Producto = venta.ID_Producto,
                    ID_Vendedor = venta.ID_Vendedor,
                    Fecha_Venta = venta.Fecha_Venta,
                    Cantidad = venta.Cantidad,
                    Subtotal = venta.Subtotal,
                    Total = venta.Total,
                    PrecioProducto = venta.PrecioProducto,
                    pagacon = venta.Paga,
                    cambio = venta.Cambio
                };
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                return null;
            }
        }

        public List<Venta_FacturaDTO> ObtenerTodasLasVentas()
        {
            try
            {
                return db.Venta_Factura.Select(venta => new Venta_FacturaDTO
                {
                    ID_Venta = venta.ID_Venta,
                    Estado = venta.Estado,
                    ID_Cliente = venta.ID_Cliente,
                    ID_Producto = venta.ID_Producto,
                    ID_Vendedor = venta.ID_Vendedor,
                    Fecha_Venta = venta.Fecha_Venta,
                    Cantidad = venta.Cantidad,
                    Subtotal = venta.Subtotal,
                    Total = venta.Total,
                    PrecioProducto = venta.PrecioProducto,
                    pagacon = venta.Paga,
                    cambio = venta.Cambio

                }).ToList();
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                return new List<Venta_FacturaDTO>();
            }
        }


    }
}
