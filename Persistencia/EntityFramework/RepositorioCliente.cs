﻿using ShockSoft.Dominio;
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
        /// El objetivo de este método es devolver los clientes filtrados en base a distintos criterios.
        /// </summary>
        /// <param name="pNombre">La cadena mediante la cual filtrar el nombre del cliente</param>
        /// <param name="pApellido">La cadena mediante la cual filtrar el apellido del cliente</param>
        /// <param name="pConDeudas">Si debe incluir a los clientes que tengan deudas</param>
        /// <param name="pSinDeudas">Si debe incluir a los clientes que no tengan deudas</param>
        /// <param name="pDesde">El número de clientes a partir del cual debe traerlos</param>
        /// <param name="pCantidad">El numero de clientes a traer</param>
        /// <returns></returns>
        public IEnumerable<Cliente> ObtenerClientes(string pNombre, string pApellido, bool pConDeudas, bool pSinDeudas, int pDesde, int pCantidad)
        {
            var clientesFiltrados = (from c in iDbContext.Clientes
                                     join r in iDbContext.Reparaciones on c.IdCliente equals r.IdCliente
                                     where ((r.Cobrado == pConDeudas) || (r.Cobrado == pSinDeudas)) &&
                                     (string.IsNullOrEmpty(pNombre) || c.Nombre.ToUpper().Contains(pNombre.ToUpper())) &&
                                     (string.IsNullOrEmpty(pApellido) || c.Apellido.ToUpper().Contains(pApellido.ToUpper()))
                                     select c);
            return clientesFiltrados.Distinct().OrderBy(x => x.Apellido).Skip(pDesde).Take(pCantidad);
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
    }
}
