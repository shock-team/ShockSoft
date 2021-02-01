using ZonaSoft.Dominio;
using ZonaSoft.Excepciones;
using ZonaSoft.Persistencia.EntityFramework;
using System.Collections.Generic;
using System.Linq;

namespace ZonaSoft.Presentacion
{
    /// <summary>
    /// Esta clase se encarga de funcionar como intermediaria entre la
    /// GUI correspondiente a los casos de uso asociados a la clase Marca
    /// y las clases de dominio. Esta clase aplica el patrón de diseño Singleton.
    /// </summary>
    public class ControladorMarcas
    {
        private static ControladorMarcas _instancia;

        /// <summary>
        /// Obtiene la instancia del controlador
        /// </summary>
        /// <returns></returns>
        public static ControladorMarcas ObtenerInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladorMarcas();
            }

            return _instancia;
        }

        /// <summary>
        /// Este método se encarga de crear la nueva marca y agregarla al repositorio
        /// </summary>
        /// <param name="pDescripcion">La descripción de la nueva marca</param>
        public void AgregarMarca(string pDescripcion)
        {
            if (!(pDescripcion.Equals("")))
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
            else
            {
                throw new DatosFaltantesException("Nombre");
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
        /// Este método se utiliza para listar las marcas presentes en la base de datos, separadas por
        /// páginas.
        /// </summary>
        /// <param name="pDesde">El índice a partir del cual obtener las marcas.</param>
        /// <param name="pCantidad">La cantidad de marcas a devolver.</param>
        /// <returns></returns>
        public List<Marca> ListarMarcas(int pDesde, int pCantidad)
        {
            List<Marca> listaMarcas;
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    listaMarcas = bUoW.RepositorioMarca.ObtenerMarcas(pDesde, pCantidad).ToList();
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

        /// <summary>
        /// Este método se utiliza para verificar que una marca a agregar no posee el mismo nombre
        /// que otra presente en la base de datos.
        /// </summary>
        /// <param name="pNombre">El nombre de la marca a agregar.</param>
        public void VerificarDatos(string pNombre)
        {
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    IEnumerable <Marca> marcas = bUoW.RepositorioMarca.VerificarDatos(pNombre);
                    if (marcas.Count() > 0)
                    {
                        throw new DatosRepetidosException();
                    }
                }
            }
        }

        /// <summary>
        /// Este método se utiliza para obtener la cantidad de marcas presente en la base de datos.
        /// </summary>
        /// <returns></returns>
        public int ObtenerCantidadDeMarcas()
        {
            int cant = 0;
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    cant = bUoW.RepositorioMarca.CantidadFilas();
                }
            }
            return cant;
        }
    }
}
