using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CategoriaMCN
    {


        private readonly bddVariedadesMansStyleEntities db;

        public CategoriaMCN()
        {

            db = new bddVariedadesMansStyleEntities();

        }

        public List<CategoriaDTO> ObtenerCategoriasActivas()
        {

            return db.Categoria
                .Where(c => c.Estado == 1) // Filtra las categorías con Estado igual a 1
                .Select(c => new CategoriaDTO
                {
                    ID_Categoria = c.ID_Categoria,
                    Nombre = c.Nombre,
                    Estado = c.Estado,
                    NombreEstado = "Activa" 
                })
                .ToList();

        }

        public List<CategoriaDTO> ObtenerCategoriasInActivas()
        {

            return db.Categoria
                .Where(c => c.Estado == 0) // Filtra las categorías con Estado igual a 0
                .Select(c => new CategoriaDTO
                {
                    ID_Categoria = c.ID_Categoria,
                    Nombre = c.Nombre,
                    Estado = c.Estado,
                    NombreEstado = "inactiva" 
                })
                .ToList();

        }

        public CategoriaDTO ObtenerNombreCategoria(string namecate)
        {
            // Realiza una consulta LINQ para buscar por nombre de categoria

            return (from c in db.Categoria
                            where c.Nombre == namecate
                            select new CategoriaDTO
                            {
                                ID_Categoria = c.ID_Categoria,
                                Nombre = c.Nombre,
                                Estado = c.Estado

                            }).FirstOrDefault();

            
        }

        public bool ActualizarCategoria(CategoriaDTO actualcate)
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

        }


    }
}
