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

        /*public bool ActualizarCategoria(CategoriaDTO actualcate)
        {
            try
            {
                Categoria newcategoria = db.Categoria.Find(actualcate.ID_Categoria);

                if (newcategoria is null)
                {
                    
                    return false;
                }

                newcategoria.Nombre = actualcate.Nombre;

                db.Entry(newcategoria).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarCategoria(CategoriaDTO actualcate)
        {
            try
            {
                Categoria newcategoria = db.Categoria.Find(actualcate.ID_Categoria);

                if (newcategoria is null)
                {
                    
                    return false;
                }

                newcategoria.Estado = actualcate.Estado;

                db.Entry(newcategoria).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool AgregarCategoria(CategoriaDTO namecategoria)
        {

            try
            {

                Categoria nuevacate = new Categoria()
                {

                    Nombre = namecategoria.Nombre,
                    Estado = namecategoria.Estado


                };

                db.Categoria.Add(nuevacate);
                db.SaveChanges();


                return true;

            }
            catch
            {

                return false;


            }

        }*/


    }
}
