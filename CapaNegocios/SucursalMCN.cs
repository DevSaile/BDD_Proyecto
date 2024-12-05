using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class SucursalMCN
    {

        private readonly bddVariedadesMansStyleEntities db;

        public SucursalMCN()
        {

            db = new bddVariedadesMansStyleEntities();
        }

        public List<SucursalDTO> ObtenerSucursales()
        {

            return db.Sucursal.Select(s => new SucursalDTO { 
                
                ID_Sucursal = s.ID_Sucursal,
                Nombre = (s.ID_Sucursal == 1 ? "Tienda Principal" : s.ID_Sucursal == 2 ? "Tienda Primaria" : " ") /*+ s.Nombre*/,

            }).ToList();

        }

        public int ObtenerSucursalID(int? idempleado) // obtiene la sucursal que le pertence al empleado en ese momento
        {
            var sucu = (from v in db.Vendedor
                       where v.ID_Vendedor == idempleado
                       select v.ID_Sucursal).FirstOrDefault();

            return sucu ?? -1;
        }

        public string DevolverSucursalProductos(int? idsucuproducto) // obtiene la sucursal que le pertence al prodcuto en ese momento
        {
            var sucu = (from p in db.Producto
                       where p.ID_Producto == idsucuproducto
                       select p.ID_Sucursal).FirstOrDefault();

            String devolver = sucu == 0 ? "Tienda Principal" : "Tienda Primaria";

            return devolver;
        }

        public string DevolverMarcaProductos(int? idsucuproducto) // obtiene la Marca que le pertence al prodcuto en ese momento
        {
            var sucu = (from p in db.Producto
                       where p.ID_Producto == idsucuproducto
                       select p.Marca).FirstOrDefault();

            //String devolver = sucu == 0 ? "Tienda Principal" : "Tienda Primaria";

            return sucu;
        }


        public List<SucursalDTO> ObtenerSucursalesPorID(int? ID_cate) // obtner el id de la categiria que pertenece al producto
        {
            // Verifica que ID_sucu no sea null antes de proceder
            if (!ID_cate.HasValue)
                return new List<SucursalDTO>();

            // Realiza la consulta
            var resultado = db.Sucursal
                .Where(c => c.Producto.Any(p => p.ID_Sucursal == ID_cate)) // Filtra categorías según los productos en la sucursal
                .Select(c => new SucursalDTO
                {
                    ID_Sucursal = c.ID_Sucursal,
                    Nombre = c.Nombre, // Mapear el nombre de la categoría

                }).ToList();

            return resultado;
        }
        
        /*public List<SucursalDTO> DevolverIndiceSucursal(int? idEmpleado)
        {

            return (from v in db.Vendedor
                    where v.ID_Vendedor == idEmpleado.Value // Coincidencia parcial, insensible a mayúsculas
                    select new SucursalDTO
                    {
                        ID_Sucursal = v.ID_Sucursal,
                        Nombre = v.ID_Sucursal == 1 ? "Tienda Primaria" : "Tienda Secundaria",

                    }).ToList();

        }*/


        /* DE AQUI PARA ABAJO VOY A TRABAJAR EL DASHBOARD DE LA TIENDA PRINCIPAL */

        /*public List<KeyValuePair<string, int>> ObtenerProductosPorCategoria(int idSucursal)
        {
            using (var db = new bddVariedadesMansStyleEntities())
            {
                var categorias = db.Producto
                    .Where(p => p.ID_Sucursal == idSucursal)
                    .GroupBy(p => p.Categoria.Nombre)
                    .Select(g => new
                    {
                        Categoria = g.Key,
                        Total = g.Count()
                    })
                    .ToList(); // Materializamos los datos primero

                // Transformamos el resultado en una lista de KeyValuePair
                return categorias.Select(c => new KeyValuePair<string, int>(c.Categoria, c.Total)).ToList();
            }
        }*/


        /*public List<KeyValuePair<string, int>> ObtenerTop5MayorStock(int idSucursal)
        {
            using (var db = new bddVariedadesMansStyleEntities())
            {
                var productos = db.Producto
                    .Where(p => p.ID_Sucursal == idSucursal)
                    .OrderByDescending(p => p.Cantidad)
                    .Take(5)
                    .Select(p => new
                    {
                        Nombre = p.Nombre,
                        Stock = p.Cantidad ?? 0
                    })
                    .ToList(); // Materializamos los datos primero

                // Transformamos el resultado en una lista de KeyValuePair
                return productos.Select(p => new KeyValuePair<string, int>(p.Nombre, p.Stock)).ToList();
            }
        }*/

        /*public List<KeyValuePair<string, int>> ObtenerProductosBajoStock(int idSucursal, int limite)
        {
            using (var db = new bddVariedadesMansStyleEntities())
            {
                var productos = db.Producto
                    .Where(p => p.ID_Sucursal == idSucursal && p.Cantidad < limite)
                    .Select(p => new
                    {
                        Nombre = p.Nombre,
                        Stock = p.Cantidad ?? 0
                    })
                    .ToList(); // Materializamos los datos primero

                // Transformamos el resultado en una lista de KeyValuePair
                return productos.Select(p => new KeyValuePair<string, int>(p.Nombre, p.Stock)).ToList();
            }
        }*/

        public Dictionary<string, decimal> ObtenerTotalesSucursal(int idSucursal)
        {

                // Asegúrate de que la suma sea de tipo decimal
                decimal totalGanancias = db.Venta_Factura
                    .Join(db.Venta_Detalles, vf => vf.ID_Venta, vd => vd.ID_Venta, (vf, vd) => new { vf, vd })
                    .Join(db.Producto, v => v.vd.ID_Producto, p => p.ID_Producto, (v, p) => new { v.vf, v.vd, p })
                    .Where(v => v.p.ID_Sucursal == idSucursal)
                    .Sum(v => (decimal)(v.vd.Cantidad * v.vd.PrecioProducto));

                int totalMarcas = db.Producto
                    .Where(p => p.ID_Sucursal == idSucursal)
                    .Select(p => p.Marca)
                    .Distinct()
                    .Count();

                return new Dictionary<string, decimal>
                {
                    { "Clientes", db.Cliente.Count() },
                    { "Empleados", db.Vendedor.Count() },
                    { "Productos", db.Producto.Count(p => p.ID_Sucursal == idSucursal) },
                    { "Ventas", db.Venta_Factura
                        .Join(db.Venta_Detalles, vf => vf.ID_Venta, vd => vd.ID_Venta, (vf, vd) => new { vf, vd })
                        .Join(db.Producto, v => v.vd.ID_Producto, p => p.ID_Producto, (v, p) => new { v.vf, p })
                        .Count(v => v.p.ID_Sucursal == idSucursal) },
                    { "GananciasTotales", totalGanancias },
                    { "Marcas", totalMarcas }
                };
            
        }



        public List<ProductoPorCategoriaDTO> ObtenerProductosPorCategoria(int idSucursal)
        {
            return db.Producto
                    .Where(p => p.ID_Sucursal == idSucursal)
                    .GroupBy(p => p.Categoria.Nombre)
                    .Select(g => new ProductoPorCategoriaDTO
                    {
                        Categoria = g.Key,
                        Cantidad = g.Count()
                    }).ToList();
        }

        public List<ProductoDTO> ObtenerTop5MayorStock(int idSucursal)
        {
            return db.Producto
                    .Where(p => p.ID_Sucursal == idSucursal)
                    .OrderByDescending(p => p.Cantidad)
                    .Take(5)
                    .Select(p => new ProductoDTO
                    {
                        Nombre = p.Nombre,
                        Cantidad = p.Cantidad
                    }).ToList();
        }

        public List<ProductoDTO> ObtenerProductosBajoStock(int idSucursal, int umbral)
        {
            return db.Producto
                    .Where(p => p.ID_Sucursal == idSucursal && p.Cantidad < umbral)
                    .Select(p => new ProductoDTO
                    {
                        Nombre = p.Nombre,
                        Cantidad = p.Cantidad
                    }).ToList();
        }

    }
}
