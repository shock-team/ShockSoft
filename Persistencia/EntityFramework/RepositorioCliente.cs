using ShockSoft.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        /// El objetivo de este método es devolver los clientes filtrados en base a distintos criterios.
        /// </summary>
        /// <param name="pNombre">La cadena mediante la cual filtrar el nombre del cliente</param>
        /// <param name="pApellido">La cadena mediante la cual filtrar el apellido del cliente</param>
        /// <returns></returns>
        public IEnumerable<Cliente> ObtenerClientes(string pNombre, string pApellido)
        {
            var clientesFiltrados = (from c in iDbContext.Clientes
                                     .Include("Pagos")
                                     .Include("Ventas")
                                     .Include("Ventas.Lineas")
                                     .Include("Ventas.MetodoPago")
                                     where (string.IsNullOrEmpty(pNombre) || c.Nombre.ToUpper().Contains(pNombre.ToUpper())) &&
                                     (string.IsNullOrEmpty(pApellido) || c.Apellido.ToUpper().Contains(pApellido.ToUpper()))
                                     select c);
            return clientesFiltrados;
        }

        /// <summary>
        /// Este método devuelve la cantidad de clientes presente en la base de datos
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Este método se utiliza para obtener un cliente en particular de la base de datos a partir de su
        /// ID, trayendo además sus pagos y ventas.
        /// </summary>
        /// <param name="pIdCliente">El ID del cliente a traer.</param>
        /// <returns></returns>
        public Cliente ObtenerClientePorId(int pIdCliente)
        {
            var clientes = (from c in iDbContext.Clientes
                                     .Include("Pagos")
                                     .Include("Ventas")
                                     .Include("Ventas.Lineas")
                                     .Include("Ventas.MetodoPago")
                           where c.IdCliente == pIdCliente
                           select c);
            return clientes.First();
        }
    }
}
