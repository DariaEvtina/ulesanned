using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ulesanned
{

    internal class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("kasutajad")
        {
            if (Database.Exists("kasutajad"))
            {
                Database.SetInitializer(new DropCreateDatabaseAlways<ApplicationContext>());
            }
        }
        public DbSet<kasutaja> kasutajad1{get; set;}
        public DbSet<rekordit> rekordit1 { get; set; }
    }
}
