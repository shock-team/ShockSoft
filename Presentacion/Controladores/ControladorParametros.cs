using ZonaSoft.Dominio;
using ZonaSoft.Persistencia.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ZonaSoft.Presentacion
{
    /// <summary>
    /// Esta clase se encarga de funcionar como intermediaria entre la
    /// GUI correspondiente a los casos de uso asociados a la clase Parametro
    /// y las clases de dominio. Esta clase aplica el patrón de diseño Singleton.
    /// </summary>
    public class ControladorParametros
    {
        private static ControladorParametros _instancia;
        public event EventHandler<Parametro> OnDolarChangedEvent;

        /// <summary>
        /// Obtiene la instancia del controlador
        /// </summary>
        /// <returns></returns>
        public static ControladorParametros ObtenerInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladorParametros();
            }

            return _instancia;
        }

        /// <summary>
        /// Este método se encarga de crear el nuevo parámetro y almacenarlo
        /// en el repositorio
        /// </summary>
        /// <param name="pDescripcion">La descripción del nuevo parámetro</param>
        /// <param name="pValor">El valor del nuevo parámetro</param>
        public void AgregarParametro(string pDescripcion, float pValor)
        {
            Parametro parametro = new Parametro();
            parametro.Descripcion = pDescripcion;
            parametro.Valor = pValor;
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    bUoW.RepositorioParametro.Agregar(parametro);
                    bUoW.GuardarCambios();
                }
            }
        }

        /// <summary>
        /// Este método se encarga de devolver una lista de todos los
        /// parámetros presentes en el repositorio
        /// </summary>
        /// <returns></returns>
        public List<Parametro> ListarParametros(int pDesde, int pCantidad)
        {
            List<Parametro> listaParametros;
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    listaParametros = bUoW.RepositorioParametro.ObtenerParametros(pDesde,pCantidad).ToList();
                }
            }
            return listaParametros;
        }

        /// <summary>
        /// Este método se utiliza para obtener todos los parámetros presentes en la base de datos.
        /// </summary>
        /// <returns></returns>
        public List<Parametro> ListarParametros()
        {
            List<Parametro> listaParametros;
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    listaParametros = bUoW.RepositorioParametro.ObtenerTodos().ToList();
                }
            }
            return listaParametros;
        }

        /// <summary>
        /// Este método se encarga de modificar los datos de un parámetro existente
        /// en el repositorio
        /// </summary>
        /// <param name="pDescripcion">La nueva descripción del parámetro</param>
        /// <param name="pValor">El nuevo valor del parámetro</param>
        /// <param name="idParametro">El ID del parámetro a modificar</param>
        public void ModificarParametro(string pDescripcion, float pValor, int idParametro)
        {
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    Parametro parametro = bUoW.RepositorioParametro.Obtener(idParametro);
                    parametro.Descripcion = pDescripcion;
                    parametro.Valor = pValor;
                    bUoW.GuardarCambios();
                    OnDolarChangedEvent?.Invoke(this, parametro);
                }
            }
        }

        /// <summary>
        /// Este método se utiliza para obtener únicamente el parámetro que almacena el valor
        /// del dólar utilizado actualmente.
        /// </summary>
        /// <returns></returns>
        public float ObtenerPrecioDolar()
        {
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    return bUoW.RepositorioParametro.ObtenerPrecioDolar().Valor;
                }
            }
        }

        /// <summary>
        /// Este método se utiliza para obtener la cantidad total de parámetros presentes en la 
        /// base de datos.
        /// </summary>
        /// <returns></returns>
        public int ObtenerCantidadDeParametros()
        {
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    return bUoW.RepositorioParametro.CantidadFilas();
                }
            }
        }
    }
}