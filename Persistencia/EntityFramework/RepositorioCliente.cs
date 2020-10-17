using ShockSoft.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public IEnumerable<Cliente> ObtenerClientes(string pNombre, string pApellido, bool pConDeudas, bool pSinDeudas, int pDesde, int pHasta)
        {
            var clientesFiltrados = (from c in iDbContext.Clientes
                                     join r in iDbContext.Reparaciones on c.IdCliente equals r.IdCliente
                                     where (r.Cobrado == pConDeudas) || (r.Cobrado == pSinDeudas) &&
                                     (string.IsNullOrEmpty(pNombre) || pNombre.Equals("") || c.Nombre.ToUpper().Contains(pNombre.ToUpper())) &&
                                     (string.IsNullOrEmpty(pApellido) || pApellido.Equals("") || c.Apellido.ToUpper().Contains(pApellido.ToUpper()))
                                     select c);
            return clientesFiltrados.Distinct().OrderBy(x => x.Apellido).Skip(pDesde).Take(pHasta);
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
                                     where (string.IsNullOrEmpty(pNombre) || pNombre.Equals("") || c.Nombre.Contains(pNombre)) &&
                                            (string.IsNullOrEmpty(pApellido) || pApellido.Equals("") || c.Apellido.Contains(pApellido))
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
        public IEnumerable<Cliente> VerificarInformacion(string pDNI, string pCUIT)
        {
            var cliente = (from c in iDbContext.Clientes
                           where (c.DNI.Equals(pDNI) || (c.CUIT.Equals(pCUIT)))
                           select c);
            return cliente;
        }
    }
}
