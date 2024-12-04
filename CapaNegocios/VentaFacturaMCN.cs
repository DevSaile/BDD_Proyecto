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

        // En estos metodos de abajo basicamente realizamos las busquedas

        public List<ClienteDTO> BuscarClientes(string valor)
        {
            return db.Cliente
                .Where(c => c.Estado == 1 && c.Nombre.ToLower().Contains(valor.ToLower()))
                .Select(c => new ClienteDTO
                {
                    ID_Cliente = c.ID_Cliente,
                    Nombre = c.Nombre,
                    //Estado = c.Estado,
                    // Otros campos relevantes
                }).ToList();
        }

        public List<ProductoDTO> BuscarProductos(string valor)
        {
            return db.Producto
                .Where(p => p.Estado == 1 && p.Nombre.ToLower().Contains(valor.ToLower()))
                .Select(p => new ProductoDTO
                {
                    ID_Producto = p.ID_Producto,
                    Nombre = p.Nombre,
                    Marca = p.Marca,
                    Cantidad = p.Cantidad,
                    Precio_Producto = p.Precio_Producto,
                    Detalles = p.DetalleS,
                    Descripcion_Categoria = p.ID_Categoria == 1 ? "Cosmeticos" : "Electronica",
                    Descripcion_Sucursal = p.ID_Sucursal == 1 ? "Tienda Principal" : "Tienda Primaria"

                }).ToList();
        }

        public List<EmpleadoDTO> BuscarVendedores(string valor)
        {
            return db.Vendedor
                .Where(v => v.Estado == 1 && v.Nombre.ToLower().Contains(valor.ToLower()))
                .Select(v => new EmpleadoDTO
                {
                    ID_Empleado = v.ID_Vendedor,
                    Nombre = v.Nombre,
                    NombreRol = v.ID_Rol == 1 ? "Administrador" : "Empleado",
                    NombreSucursal = v.ID_Sucursal == 1 ? "Tienda Principal" : "Tienda Primaria"
                    // Otros campos relevantes
                }).ToList();
        }

        public object BuscarRegistros(string criterio, string valor)
        {
            switch (criterio.ToLower())
            {
                case "cliente":
                    return BuscarClientes(valor);
                case "producto":
                    return BuscarProductos(valor);
                case "vendedor":
                    return BuscarVendedores(valor);
                default:
                    return null; // Si el criterio no es válido, retorna null o lanza una excepción.
            }
        }


        // Métodos específicos para cada tipo de búsqueda

    }
}
