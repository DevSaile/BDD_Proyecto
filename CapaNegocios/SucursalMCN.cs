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

        public int ObtenerSucursalID(int? idempleado)
        {
            var sucu = (from v in db.Vendedor
                       where v.ID_Vendedor == idempleado
                       select v.ID_Sucursal).FirstOrDefault();

            return sucu ?? -1;
        }

        /*public List<SucursalDTO> ObtenerSucursalesPorID(int? ID_sucu)
        {

            return ( from s in db.Sucursal where s.ID_Sucursal == ID_sucu
            select new SucursalDTO
            { 
                ID_Sucursal = s.ID_Sucursal,
                Nombre = (s.ID_Sucursal == 1 ? "Tienda Principal" : s.ID_Sucursal == 2 ? "Tienda Primaria" : " "),

            }).ToList();

        }
        public List<SucursalDTO> DevolverIndiceSucursal(int? idEmpleado)
        {

            return (from v in db.Vendedor
                    where v.ID_Vendedor == idEmpleado.Value // Coincidencia parcial, insensible a mayúsculas
                    select new SucursalDTO
                    {
                        ID_Sucursal = v.ID_Sucursal,
                        Nombre = v.ID_Sucursal == 1 ? "Tienda Primaria" : "Tienda Secundaria",

                    }).ToList();

        }*/


    }
}
