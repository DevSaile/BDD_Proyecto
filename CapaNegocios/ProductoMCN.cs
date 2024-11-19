using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class ProductoMCN
    {

        private readonly MansStyleBDDEntities db;

        public ProductoMCN()
        {

            db = new MansStyleBDDEntities();
        }

        public List<ProductoDTO> verproductos()
        {

            return db.Producto
                .Select(x => new ProductoDTO
                {

                    Nombre = x.Nombre,
                    Cantidad = x.Cantidad,
                    Precio_Compra = x.Precio_Compra,
                    Precio_Producto = x.Precio_Producto,
                    Marca = x.Marca,
                    Detalles = x.DetalleS,
                    ID_Sucursal = x.ID_Sucursal,
                    ID_Categoria = x.ID_Categoria,
                    Estado = x.Estado


                }).ToList();
        }

        public bool AgregarProducto(ProductoDTO produ)
        {

            try
            {

                Producto nuevoprodu = new Producto()
                {

                    Nombre = produ.Nombre,
                    Cantidad = produ.Cantidad,
                    Precio_Compra = produ.Precio_Compra,
                    Precio_Producto = produ.Precio_Producto,
                    Marca = produ.Marca,
                    DetalleS = produ.Detalles,
                    
                    ID_Categoria = produ.ID_Categoria,
                    ID_Sucursal = produ.ID_Sucursal,
                    Estado = produ.Estado
                    
       
                };

                db.Producto.Add(nuevoprodu);
                db.SaveChanges();

                return true;

            }
            catch
            {

                return false;
            
            }

        }

    }
}
