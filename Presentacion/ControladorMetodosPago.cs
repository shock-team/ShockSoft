using ShockSoft.Dominio;
using ShockSoft.Persistencia.EntityFramework;
using System.Collections.Generic;
using System.Linq;

namespace ShockSoft.Presentacion
{
    /// <summary>
    /// Esta clase se encarga de funcionar como intermediaria entre la
    /// GUI correspondiente a los casos de uso asociados a la clase MetodoPago
    /// y las clases de dominio. Esta clase aplica el patrón de diseño Singleton.
    /// </summary>
    class ControladorMetodosPago
    {
        public static ControladorMetodosPago instancia;

        /// <summary>
        /// Obtiene la instancia del controlador
        /// </summary>
        /// <returns></returns>
        public static ControladorMetodosPago ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ControladorMetodosPago();
            }
            return instancia;
        }

        /// <summary>
        /// Este método se encarga de crear el nuevo método y agregarlo al repositorio
        /// </summary>
        /// <param name="pDescripcion">La descripción del nuevo método de pago</param>
        /// <param name="pValor">El valor del nuevo método de pago</param>
        public void AgregarMetodoDePago(string pDescripcion, float pValor)
        {
            MetodoPago metodo = new MetodoPago();
            metodo.Descripcion = pDescripcion;
            metodo.Valor = pValor;
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
        /// Este método se encarga de modificar los datos de un método de pago existente
        /// en el repositorio
        /// </summary>
        /// <param name="pDescripcion">La nueva descripción del método de pago</param>
        /// <param name="idMetodo">El ID del método de pago a modificar</param>
        public void ModificarMetodoDePago(string pDescripcion, int idMetodo)
        {
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    MetodoPago metodoAModificar = bUoW.RepositorioMetodoPago.Obtener(idMetodo);
                    metodoAModificar.Descripcion = pDescripcion;
                    bUoW.GuardarCambios();
                }
            }
        }
    }
}
