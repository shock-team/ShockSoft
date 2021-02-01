using ZonaSoft.Dominio;
using ZonaSoft.Persistencia.EntityFramework;
using System.Collections.Generic;
using System.Linq;

namespace ZonaSoft.Presentacion
{
    /// <summary>
    /// Esta clase se encarga de funcionar como intermediaria entre la
    /// GUI correspondiente a los casos de uso asociados a la clase MetodoPago
    /// y las clases de dominio. Esta clase aplica el patrón de diseño Singleton.
    /// </summary>
    public class ControladorMetodosPago
    {
        private static ControladorMetodosPago _instancia;

        /// <summary>
        /// Obtiene la instancia del controlador
        /// </summary>
        /// <returns></returns>
        public static ControladorMetodosPago ObtenerInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladorMetodosPago();
            }

            return _instancia;
        }

        /// <summary>
        /// Este método se encarga de crear el nuevo método y agregarlo al repositorio
        /// </summary>
        /// <param name="pDescripcion">La descripción del nuevo método de pago</param>
        /// <param name="pMultiplicadorInteres">El valor del nuevo método de pago</param>
        public void AgregarMetodoDePago(string pDescripcion, float pMultiplicadorInteres)
        {
            MetodoPago metodo = new MetodoPago();
            metodo.Descripcion = pDescripcion;
            metodo.MultiplicadorInteres = pMultiplicadorInteres;
            using (var pDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(pDbContext))
                {
                    bUoW.RepositorioMetodoPago.Agregar(metodo);
                    bUoW.GuardarCambios();
                }
            }
        }

        /// <summary>
        /// Este método se encarga de devolver una lista de todos los metodos de
        /// pago presentes en el repositorio
        /// </summary>
        /// <returns></returns>
        public List<MetodoPago> ListarMetodosDePago()
        {
            List<MetodoPago> listaMetodos = new List<MetodoPago>();
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    listaMetodos = bUoW.RepositorioMetodoPago.ObtenerTodos().ToList();
                }
            }
            return listaMetodos;
        }

        /// <summary>
        /// Este método se utiliza para obtener una página de los métodos de pago presentes en
        /// la base de datos.
        /// </summary>
        /// <param name="pDesde">El índice a partir del cual obtener los métodos de pago.</param>
        /// <param name="pCantidad">La cantidad de métodos de pago a devolver.</param>
        /// <returns></returns>
        public List<MetodoPago> ListarMetodosDePago(int pDesde, int pCantidad)
        {
            List<MetodoPago> listaMetodos = new List<MetodoPago>();
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    listaMetodos = bUoW.RepositorioMetodoPago.ObtenerTodos().ToList();
                }
            }
            return listaMetodos;
        }

        /// <summary>
        /// Este método se encarga de modificar los datos de un método de pago existente
        /// en el repositorio
        /// </summary>
        /// <param name="pDescripcion">La nueva descripción del método de pago</param>
        /// <param name="idMetodo">El ID del método de pago a modificar</param>
        public void ModificarMetodoDePago(string pDescripcion, float pMultiplicador, int idMetodo)
        {
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    MetodoPago metodoAModificar = bUoW.RepositorioMetodoPago.Obtener(idMetodo);
                    metodoAModificar.Descripcion = pDescripcion;
                    metodoAModificar.MultiplicadorInteres = pMultiplicador;
                    bUoW.GuardarCambios();
                }
            }
        }

        /// <summary>
        /// Este método se utiliza para obtener un método de pago en particular de la base de datos,
        /// a partir de su ID.
        /// </summary>
        /// <param name="pIdMetodo">El ID del método a obtener.</param>
        /// <returns></returns>
        public MetodoPago ObtenerMetodoDePago(int pIdMetodo)
        {
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    MetodoPago metodo = bUoW.RepositorioMetodoPago.Obtener(pIdMetodo);
                    return metodo;
                }
            }
        }

        /// <summary>
        /// Este método se utiliza para obtener la cantidad total de métodos de pago presentes en
        /// la base de datos.
        /// </summary>
        /// <returns></returns>
        public int ObtenerCantidadDeMetodosDePago()
        {
            int cantidad = 0;
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    cantidad = bUoW.RepositorioMetodoPago.CantidadFilas();
                }
            }
            return cantidad;
        }
    }
}
