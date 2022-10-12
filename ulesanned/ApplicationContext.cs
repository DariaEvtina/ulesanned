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
        /*public string connection()
        {
            return @"Data Source=(LocalDB)\\\\MSSQLLocalDB;AttachDbFilename=C:\\\\Users\\\\opilane\\\\source\\\\repos\\\\dariaEvtinaTARpv20\\\\ulesanned\\\\ulesanned\\\\kasutajad.mdf;Integrated Security=True;Connect Timeout=30\";
        }*/
        public ApplicationContext() : base("kasutajad")
        {
            if (Database.Exists("kasutajad"))
            {
                Database.SetInitializer(new CreateDatabaseIfNotExists<ApplicationContext>());
            }
        }
        public DbSet<kasutaja> kasutajad1{get; set;}
        //public ApplicationContext() => Database.EnsureCreated();

        /*protected override void OnConfiguring(DbConfiguration optionsBuilder)
        {
            kasutaja kas=new kasutaja();
            optionsBuilder.UseSqlite(kas.connection);
        }*/
    }
}
