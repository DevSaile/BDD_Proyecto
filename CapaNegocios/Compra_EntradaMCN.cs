using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaNegocios
{
    public class Compra_EntradaMCN
    {
        private readonly bddVariedadesMansStyleEntities db;

        public Compra_EntradaMCN()
        {
            db = new bddVariedadesMansStyleEntities();

        }

        public bool AgregarProducto(Compra_EntradaDTO compraentra)
        {

            try
            {

                Compra_Entrada nuevaentrada = new Compra_Entrada()
                {

                    Estado = compraentra.Estado,
                    ID_Producto = compraentra.ID_Producto,
                    Precio_Compra = compraentra.Precio_Compra,
                    CantidadCompra = compraentra.CantidadCompra,
                    Fecha_Compra = compraentra.Fecha_Compra

                };

                db.Compra_Entrada.Add(nuevaentrada);
                db.SaveChanges();

                return true;

            }
            catch
            {

                return false;

            }

        }



        public List<Compra_EntradaDTO> VerRegistroCompraEntrada()
        {


            var resultado =

                from ce in db.Compra_Entrada
                join p in db.Producto on ce.ID_Producto equals p.ID_Producto
                join ct in db.Categoria on p.ID_Categoria equals ct.ID_Categoria
                join su in db.Sucursal on p.ID_Sucursal equals su.ID_Sucursal

                select new Compra_EntradaDTO
                {

                    ID_Entrada = ce.ID_Entrada,

                    Nombre_Categoria = ct.Nombre,
                    ID_Producto = p.ID_Producto,
                    Nombre_Producto = p.Nombre,
                    Marca = p.Marca,
                    CantidadCompra = ce.CantidadCompra,
                    Precio_Compra = ce.Precio_Compra, // aqui modifique esto
                    /*Precio_Producto = p.Precio_Producto,*/  //segun mi logica no hay que usar info del producto en la compra entrada
                    Detalles = p.DetalleS,
                    Descripcion_Sucursal = su.ID_Sucursal == 1 ? "Tienda Principal" : "Tienda Primaria",
                    Nombre_Sucursal = su.Nombre,
                   
                    Fecha_Compra = ce.Fecha_Compra.HasValue ? ce.Fecha_Compra.Value : DateTime.MinValue
                };

            return resultado.ToList();


            /*   HAY OTRA MANERA MAS FACIL DE HACER ESTA WEA PERO ME COMPLIQUE LA VIDA */


        }

    }

}
