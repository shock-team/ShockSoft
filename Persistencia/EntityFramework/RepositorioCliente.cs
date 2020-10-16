using ShockSoft.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShockSoft.Excepciones;

namespace ShockSoft.Persistencia.EntityFramework
{
    public class RepositorioCliente : Repositorio<Cliente, ShockDbContext>
    {
        public RepositorioCliente(ShockDbContext pDbContext) : base(pDbContext) { }

        /// <summary>
        /// Devuelve un segmento de Clientes ordenado por Apellido.
        /// </summary>
        /// <param name="pDesde"></param>
        /// <param name="pHasta"></param>
        /// <returns></returns>
        public IEnumerable<Cliente> ObtenerPorParte(int pDesde, int pHasta)
        {
            return this.iDbContext.Set<Cliente>().OrderBy(x => x.Apellido).Skip(pDesde).Take(pHasta);
        }

        /// <summary>
        /// Devuelve Clientes filtrados por <paramref name="pConDeudas"/> o <paramref name="pSinDeudas"/>.
        /// </summary>
        /// <param name="pConDeudas"></param>
        /// <returns></returns>
        public IEnumerable<Cliente> ObtenerDeudores(bool pConDeudas, bool pSinDeudas)
        {
            var clientesFiltrados = (from c in iDbContext.Clientes
                                     join r in iDbContext.Reparaciones on c.IdCliente equals r.IdCliente
                                     where (r.Cobrado == pConDeudas) || (r.Cobrado == pSinDeudas)
                                     select c);
            return clientesFiltrados;
        }

        /// <summary>
        /// Devuelve Clientes filtrados por <paramref name="pNombre"/> y <paramref name="pApellido"/>.
        /// </summary>
        /// <param name="pNombre"></param>
        /// <param name="pApellido"></param>
        /// <returns></returns>
        public IEnumerable<Cliente> ObtenerPorDatos(string pNombre, string pApellido)
        {
            var clientesFiltrados = (from c in iDbContext.Clientes
                                     where (string.IsNullOrEmpty(pNombre) || c.Nombre.Contains(pNombre)) &&
                                            (string.IsNullOrEmpty(pApellido) || c.Apellido.Contains(pApellido))
                                     select c);
            return clientesFiltrados;                                          
        }

        public int CantidadFilas()
        {
            var sql = "SELECT COUNT(*) FROM clientes";
            return this.iDbContext.Database.SqlQuery<int>(sql).Single();
        }

        /// <summary>
        /// Verifica que no exista un cliente en la base de datos con los datos a cargar
        /// </summary>
        /// <param name="pDNI">El DNI del cliente a cargar</param>
        /// <param name="pCUIT">El CUIT del cliente a cargar</param>
        public void VerificarInformacion(string pDNI, string pCUIT)
        {
            var cliente = (from c in iDbContext.Clientes
                           where (c.DNI.Equals(pDNI) || (c.CUIT.Equals(pCUIT)))
                           select c);
            if (cliente != null)
            {
                throw new ClienteYaExisteException();
            }
        }
    }
}
