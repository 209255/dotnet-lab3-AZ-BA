using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations;
namespace JTTT_1._0.Database
{
    public class TaskServiceDbContext:DbContext
    {
        public TaskServiceDbContext() : base("Tasks2")
        {
        
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        
        }

        public DbSet<Task> Tasks { get; set; }
   }
}