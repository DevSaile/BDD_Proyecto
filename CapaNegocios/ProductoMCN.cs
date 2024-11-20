﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

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

            var resultado = db.Producto
                .Include(p => p.Categoria) // Incluye la relación con Categoria
                .Include(p => p.Sucursal)  // Incluye la relación con Sucursal
                .Where(p => p.Estado == 1) // Filtra productos activos
                .Select(p => new ProductoDTO // Cambia a ProductoDTO
                {
                    ID_Producto = p.ID_Producto,
                    Nombre = p.Nombre,
                    Marca = p.Marca,
                    Descripcion_Categoria = p.Categoria.Nombre, // Accede al nombre de la categoría
                    vercate = p.ID_Sucursal == 1 ? "Tienda Principal" : "Tienda Primaria",
                    Descripcion_Sucursal = p.Sucursal.Nombre,   // Accede al nombre de la sucursal
                    Cantidad = p.Cantidad,
                    //Precio_Compra = p.Precio_Compra,
                    Precio_Producto = p.Precio_Producto,
                    Detalles = p.DetalleS // Asegúrate de incluir la propiedad si es relevante
                }).ToList();

            return resultado; // Esto ahora devuelve List<ProductoDTO>

            /*return db.Producto
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


                }).ToList();*/
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