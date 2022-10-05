using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ulesanned
{
    public class kasutajaContext :DbContext
    {
        public DbSet<kasutaja> kasutajad { get; set; } = null;
        public kasutajaContext()
        {
            Database.CreateIfNotExists();
        }
        /*protected override void OnConfiguring(DbContext optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=kasutaja.db");
        }*/
    }
}
