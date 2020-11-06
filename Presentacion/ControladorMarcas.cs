using ShockSoft.Dominio;
using ShockSoft.Persistencia.EntityFramework;
using System.Collections.Generic;
using System.Linq;

namespace ShockSoft.Presentacion
{
    /// <summary>
    /// Esta clase se encarga de funcionar como intermediaria entre la
    /// GUI correspondiente a los casos de uso asociados a la clase Marca
    /// y las clases de dominio. Esta clase aplica el patrón de diseño Singleton.
    /// </summary>
    public class ControladorMarcas
    {
        public static ControladorMarcas instancia;

        /// <summary>
        /// Obtiene la instancia del controlador
        /// </summary>
        /// <returns></returns>
        public static ControladorMarcas ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ControladorMarcas();
            }
            return instancia;
        }

        /// <summary>
        /// Este método se encarga de crear la nueva marca y agregarla al repositorio
        /// </summary>
        /// <param name="pDescripcion">La descripción de la nueva marca</param>
        public void AgregarMarca(string pDescripcion)
        {
            Marca marca = new Marca();
            marca.Descripcion = pDescripcion;
            using (var pDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(pDbContext))
                {
                    bUoW.RepositorioMarca.Agregar(marca);
                    bUoW.GuardarCambios();
                }
            }
        }

        /// <summary>
        /// Este método se encarga de devolver una lista de todas las marcas presentes
        /// en el repositorio
        /// </summary>
        /// <returns></returns>
        public List<Marca> ListarMarcas()
        {
            List<Marca> listaMarcas;
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    listaMarcas = bUoW.RepositorioMarca.ObtenerTodos().ToList();
                }
            }
            return listaMarcas;
        }

        /// <summary>
        /// Este método se encarga de modificar los datos de una marca existente
        /// en el repositorio
        /// </summary>
        /// <param name="pDescripcion">La nueva descripción de la marca</param>
        /// <param name="idMarca">El ID de la marca a modificar</param>
        public void ModificarMarca(string pDescripcion, int idMarca)
        {
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    Marca marcaAModificar = bUoW.RepositorioMarca.Obtener(idMarca);
                    marcaAModificar.Descripcion = pDescripcion;
                    bUoW.GuardarCambios();
                }
            }
        }

        public Marca Obtener(int pId)
        {
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    Marca marca = bUoW.RepositorioMarca.Obtener(pId);
                    return marca;
                }
            }
        }
    }
}
