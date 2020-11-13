using MySql.Data.EntityFramework;
using ShockSoft.Dominio;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace ShockSoft.Persistencia.EntityFramework
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ShockDbContext : DbContext
    {
        //Connection
        public ShockDbContext() : base("name=DefaultConnection") { }

        //Databases
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<LineaCompra> LineasDeCompras { get; set; }
        public DbSet<LineaVenta> LineasDeVentas { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<MetodoPago> MetodosDePago { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Reparacion> Reparaciones { get; set; }
        public DbSet<Rubro> TiposDeEquipo { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Parametro> Parametros { get; set; }
        public DbSet<Localidad> Localidades { get; set; }


        protected override void OnModelCreating(DbModelBuilder pModelBuilder)
        {
            pModelBuilder.Configurations.AddFromAssembly(System.Reflection.Assembly.GetExecutingAssembly());
            base.OnModelCreating(pModelBuilder);
        }

        /// <summary>
        /// Guarda las entidades en la base de datos.
        /// </summary>
        /// <returns></returns>
        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                var newException = new FormattedDbException(e);
                throw newException;
            }
        }
    }
}
