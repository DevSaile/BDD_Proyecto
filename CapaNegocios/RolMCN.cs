using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class RolMCN
    {

        private readonly bddVariedadesMansStyleEntities db;

        public RolMCN()
        {

            db = new bddVariedadesMansStyleEntities();
        }

        public List<RolDTO> ObtenerRoles()
        {

            return db.Rol.Select(r => new RolDTO
            {

                ID_Rol = r.ID_Rol,
                Puesto = r.ID_Rol == 1 ? "Administrador" : "Empleado",

                //NombreSucursal = v.ID_Sucursal == 1 ? "Tienda Principa" : "Tienda Primaria"

            }).ToList();

        }

        public int ObtenerRolID(int? idempleado)
        {
            var rol = (from r in db.Vendedor
                       where r.ID_Vendedor == idempleado
                       select r.ID_Rol).FirstOrDefault();

            return rol ?? -1;


        }


        /*public List<RolDTO> ObtenerRolesPorID(int? IDRolsito)
        {

            return (from r in db.Rol
            where r.ID_Rol == IDRolsito
               select new RolDTO
               {

                    ID_Rol = r.ID_Rol,
                    Puesto = r.ID_Rol == 1 ? "Administrador" : "Empleado",

                    //NombreSucursal = v.ID_Sucursal == 1 ? "Tienda Principa" : "Tienda Primaria"

               }).ToList();

        }

        public List<RolDTO> DevolverIndiceRol(int? idEmpleado)
        {

            return (from v in db.Vendedor
                    where v.ID_Vendedor == idEmpleado.Value // Coincidencia parcial, insensible a mayúsculas
                    select new RolDTO
                    {
                        ID_Rol = v.ID_Rol,
                        Puesto = v.ID_Rol == 1 ? "Administrador" : "Empleado",

                    }).ToList();

        }*/


    }
}
