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

        public List<CategoriaDTO> ObtenerCategorias()
        {

            return db.Categoria.Select(c => new CategoriaDTO
            {

                ID_Categoria = c.ID_Categoria,
                Nombre = c.Nombre,
                Estado = c.Estado,

            }).ToList();

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
