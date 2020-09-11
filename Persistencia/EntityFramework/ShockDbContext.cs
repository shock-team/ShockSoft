using MySql.Data.EntityFramework;
using ShockSoft.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockSoft.Persistencia.EntityFramework
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ShockDbContext :DbContext
    {
        public ShockDbContext() : base("name=DefaultConnection") { }

        public DbSet<Cliente> Clientes { get; set; }


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
