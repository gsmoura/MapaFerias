using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace MapaFerias.Models
{
    public class appContext : DbContext
    {
        public appContext() : base("ConnectionString")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<appContext, MapaFerias.Migrations.Configuration>("ConnectionString"));
            Database.Log = instrucao => System.Diagnostics.Debug.WriteLine(instrucao);
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}