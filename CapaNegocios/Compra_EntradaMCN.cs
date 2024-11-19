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
        private readonly MansStyleBDDEntities db;

        public Compra_EntradaMCN()
        {
            db = new MansStyleBDDEntities();

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
                    Cantidad = p.Cantidad,
                    Precio_Compra = p.Precio_Compra,
                    Precio_Producto = p.Precio_Producto,
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
