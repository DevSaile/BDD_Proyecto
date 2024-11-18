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
        private readonly BDD_VariedadesMansStyleEntities db;

        public Compra_EntradaMCN()
        {
            db = new BDD_VariedadesMansStyleEntities();

        }

        public List<Compra_EntradaDTO> VerRegistroCompraEntrada()
        {


            var resultado =

                from ce in db.Compra_Entrada
                join p in db.Producto on ce.ID_Producto equals p.ID_Producto
                join pv in db.Proveedor on ce.ID_Proveedor equals pv.ID_Proveedor

                select new Compra_EntradaDTO
                {
                   
                    ID_Entrada = ce.ID_Entrada,
                    Nombre_Proveedor = pv.Nombre,
                    Nombre_Producto = p.Nombre,
                    Fecha_Compra = ce.Fecha_Compra.HasValue ? ce.Fecha_Compra.Value : DateTime.MinValue
                };

            return resultado.ToList();


        }

    }

}
