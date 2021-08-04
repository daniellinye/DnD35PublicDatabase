using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Kubernetes1.Loaders.Models;

namespace Kubernetes1.Loaders.DatabaseFetcher
{
    public class DatabaseFetcher : DbContext
    {
        public DbSet<SourceLoader> Sources { get; set; }
        public DbSet<ClassLoader> Classes { get; set; }
        public DbSet<SpellLoader> Spells { get; set; }
        public DbSet<ItemLoader> Items { get; set; }

        
        public DatabaseFetcher():base("DataListings")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}
