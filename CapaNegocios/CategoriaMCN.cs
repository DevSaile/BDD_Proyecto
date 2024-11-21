﻿using CapaDatos;
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


            }).ToList();

        }
    }
}
