using ShockSoft.Dominio;
using ShockSoft.Persistencia.EntityFramework;
using ShockSoft.Excepciones;
using System.Collections.Generic;
using System.Linq;

namespace ShockSoft.Presentacion
{
    /// <summary>
    /// Esta clase se encarga de funcionar como intermediaria entre la
    /// GUI correspondiente a los casos de uso asociados a la clase Localidad
    /// y las clases de dominio. Esta clase aplica el patrón de diseño Singleton.
    /// </summary>
    public class ControladorLocalidades
    {

        public static ControladorLocalidades instancia;

        /// <summary>
        /// Obtiene la instancia del controlador
        /// </summary>
        /// <returns></returns>
        public static ControladorLocalidades ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ControladorLocalidades();
            }
            return instancia;
        }

        /// <summary>
        /// Este método se encarga de crear la nueva localidad y agregarla al repositorio
        /// </summary>
        /// <param name="pNombre">El nombre de la nueva localidad</param>
        public void AgregarLocalidad(string pNombre)
        {
            Localidad localidad = new Localidad();
            localidad.Nombre = pNombre;
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    bUoW.RepositorioLocalidad.Agregar(localidad);
                    bUoW.GuardarCambios();
                }
            }
        }

        /// <summary>
        /// Este método se encarga de devolver una lista de todas las localidades
        /// presentes en el repositorio
        /// </summary>
        /// <returns></returns>
        public List<Localidad> ListarLocalidades()
        {
            List<Localidad> listaLocalidades;
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    listaLocalidades = bUoW.RepositorioLocalidad.ObtenerTodos().OrderBy(x => x.Nombre).ToList();
                }
            }
            return listaLocalidades;
        }

        /// <summary>
        /// Este método se encarga de modificar los datos de una localidad existente
        /// en el repositorio
        /// </summary>
        /// <param name="pNombre">El nuevo nombre de la localidad</param>
        /// <param name="idLocalidad">El ID de la localidad a modificar</param>
        public void ModificarLocalidad(string pNombre, int idLocalidad)
        {
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    Localidad localidadAModificar = bUoW.RepositorioLocalidad.Obtener(idLocalidad);
                    localidadAModificar.Nombre = pNombre;
                    bUoW.GuardarCambios();
                }
            }
        }

        /// <summary>
        /// Este método se encarga de obtener una localidad específica cargada en la base de datos.
        /// </summary>
        /// <param name="idLocalidad">El ID de la localidad a buscar</param>
        /// <returns></returns>
        public Localidad ObtenerLocalidad(int idLocalidad)
        {
            Localidad localidadObtenida;
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    localidadObtenida = bUoW.RepositorioLocalidad.Obtener(idLocalidad);
                }
            }
            return localidadObtenida;
        }

        public void VerificarDatos(string pNombre)
        {
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    IEnumerable<Localidad> localidades = bUoW.RepositorioLocalidad.VerificarDatos(pNombre);
                    if (localidades.Count() > 0)
                    {
                        throw new DatosRepetidosException();
                    }
                }
            }
        }
    }
}
