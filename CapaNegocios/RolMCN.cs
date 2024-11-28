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

        public List<RolDTO> ObtenerRolesPorID(int IDRolsito)
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
    }
}
