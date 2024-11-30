using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class ClienteMCN
    {

        private readonly bddVariedadesMansStyleEntities db;

        public ClienteMCN() 
        { 
            db = new bddVariedadesMansStyleEntities();
            
        }

        public List<ClienteDTO> ObtenerClientesActivos()
        {

            return db.Cliente

                .Where(c => c.Estado == 1) // Filtra las categorías con Estado igual a 1
                .Select(c => new ClienteDTO
                {
                    ID_Cliente = c.ID_Cliente,
                    Nombre = c.Nombre,
                    NombreEstado = "Activo/a"

                })
                .ToList();

        }

        public List<ClienteDTO> BuscarClienteNombre(string namecliente)
        {
            // Realiza una consulta LINQ para buscar por nombre de categoria
            return (from c in db.Cliente
                    where c.Nombre.ToLower().Contains(namecliente.ToLower()) // Coincidencia parcial, insensible a mayúsculas
                    select new ClienteDTO
                    {
                        ID_Cliente = c.ID_Cliente,
                        Nombre = c.Nombre,
                        NombreEstado = c.Estado == 1 ? "Activo/a" : "Inactivo/a"

                    }).ToList();


        }




        public bool ActualizarCliente(ClienteDTO actualCliente)
        {
            try
            {
                Cliente newClientemod = db.Cliente.Find(actualCliente.ID_Cliente);

                if (newClientemod is null)
                {

                    return false;
                }

                newClientemod.Nombre = actualCliente.Nombre;

                db.Entry(newClientemod).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarCliente(ClienteDTO killCliente)
        {
            try
            {
                Cliente killclien = db.Cliente.Find(killCliente.ID_Cliente);

                if (killclien is null)
                {

                    return false;
                }

                killclien.Estado = killCliente.Estado;

                db.Entry(killclien).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;

            }
        }


        public bool AgregarCliente(ClienteDTO newCliente)
        {

            try
            {

                Cliente nuevocliente = new Cliente()
                {

                    Nombre = newCliente.Nombre,
                    Estado = newCliente.Estado


                };

                db.Cliente.Add(nuevocliente);
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
