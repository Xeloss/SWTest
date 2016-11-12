using SWTest.Data.Entities;
using System.Data.Entity;

namespace SWTest.Data.Context
{
    public class EntityContext : DbContext
    {
        public EntityContext()
            : base("DBConnection")
        {
            DbConfiguration.SetConfiguration(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Event> Events { get; set; }
    }
}
