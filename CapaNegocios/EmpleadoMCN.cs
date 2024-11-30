using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class EmpleadoMCN
    {
        private readonly bddVariedadesMansStyleEntities db;

        public EmpleadoMCN()
        {

            db = new bddVariedadesMansStyleEntities();

        }
        public List<EmpleadoDTO> ObtenerVendedorActivos()
        {

            return db.Vendedor

                .Where(v => v.Estado == 1) // Filtra las categorías con Estado igual a 1
                .Select(v => new EmpleadoDTO
                {
                    ID_Empleado = v.ID_Vendedor,
                    NombreEstado = "Activo",
                    Nombre = v.Nombre,
                    Cedula = v.Cedula,  
                    Edad = v.Edad,
                    NombreRol = v.ID_Rol == 1 ? "Administrador" : "Empleado",
                    NombreSucursal = v.ID_Sucursal == 1 ? "Tienda Principa" : "Tienda Primaria"

                    //versucu = p.ID_Sucursal == 1 ? "Tienda Principal" : "Tienda Primaria",

                })
                .ToList();

        }

        public List<EmpleadoDTO> ObtenerVendedorInActivos()
        {

            return db.Vendedor

                .Where(v => v.Estado == 0) // Filtra las categorías con Estado igual a 1
                .Select(v => new EmpleadoDTO
                {
                    ID_Empleado = v.ID_Vendedor,
                    NombreEstado = "Activo",
                    Nombre = v.Nombre,
                    Cedula = v.Cedula,
                    Edad = v.Edad,
                    NombreRol = v.ID_Rol == 1 ? "Administrador" : "Empleado",
                    NombreSucursal = v.ID_Sucursal == 1 ? "Tienda Principa" : "Tienda Primaria"

                    //versucu = p.ID_Sucursal == 1 ? "Tienda Principal" : "Tienda Primaria",

                })
                .ToList();

        }

        public List<EmpleadoDTO> BuscarEmpleadoNombre(string namecate)
        {
            // Realiza una consulta LINQ para buscar por nombre de categoria
            return (from v in db.Vendedor
                    where v.Nombre.ToLower().Contains(namecate.ToLower()) // Coincidencia parcial, insensible a mayúsculas
                    select new EmpleadoDTO
                    {
                        ID_Empleado = v.ID_Vendedor,
                        NombreEstado = "Activo",
                        Nombre = v.Nombre,
                        Cedula = v.Cedula,
                        Edad = v.Edad,
                        NombreRol = v.ID_Rol == 1 ? "Administrador" : "Empleado",
                        NombreSucursal = v.ID_Sucursal == 1 ? "Tienda Principal" : "Tienda Primaria"

                    }).ToList();


        }

        public EmpleadoDTO ObtenerEmpleadoPorId(int idEmpleado)

        {

            return (from e in db.Vendedor

                    where e.ID_Vendedor == idEmpleado

                    select new EmpleadoDTO

                    {

                        Nombre = e.Nombre,

                        Cedula = e.Cedula,

                        Edad = e.Edad,

                        usuario = e.Usuario,

                        contrasena = e.contra,

                    }).FirstOrDefault();

        }

        public bool AgregarEmpleado(EmpleadoDTO empleado)
        {

            try
            {

                Vendedor nuevoempleado = new Vendedor() { 

                    Nombre = empleado.Nombre,
                    Cedula= empleado.Cedula,
                    Edad = empleado.Edad,
                    Estado = empleado.Estado,
                    Usuario = empleado.usuario,
                    contra = empleado.contrasena,
                    ID_Rol = empleado.ID_Rol,
                    ID_Sucursal = empleado.ID_Sucursal  


                };

                db.Vendedor.Add(nuevoempleado);
                db.SaveChanges();

                return true;

            }
            catch 
            { 

                return false;
            
            }

        }

        public bool EliminarEmpleado(EmpleadoDTO ripempleado)
        {

            try
            {
                Vendedor ripvendedor= db.Vendedor.Find(ripempleado.ID_Empleado);

                if (ripvendedor is null)
                {

                    return false;
                }

                ripvendedor.Estado = ripempleado.Estado;

                db.Entry(ripvendedor).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool ActualizarEmpleado(EmpleadoDTO actualEmpleado)
        {
            try
            {
                Vendedor actempleado = db.Vendedor.Find(actualEmpleado.ID_Empleado);

                if (actempleado is null)
                {

                    return false;
                }


                actempleado.ID_Vendedor = actualEmpleado.ID_Empleado;
                actempleado.Nombre = actualEmpleado.Nombre;
                actempleado.Cedula = actualEmpleado.Cedula;
                actempleado.Edad = actualEmpleado.Edad;
                actempleado.ID_Sucursal = actualEmpleado.ID_Sucursal;
                actempleado.ID_Rol = actualEmpleado.ID_Rol;
                actempleado.Usuario = actualEmpleado.usuario;
                actempleado.contra = actualEmpleado.contrasena;

                db.Entry(actempleado).State = System.Data.Entity.EntityState.Modified;
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
