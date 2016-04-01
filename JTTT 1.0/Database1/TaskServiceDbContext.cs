using System.Data.Entity;

namespace JTTT_1._0.Database
{
    public class TaskServiceDbContext:DbContext
    {
        public TaskServiceDbContext() : base("Tasks")
        {
          
        }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<IReaction> Reaction { get; set; }
        public DbSet<IAction> Action { get; set; }
    
    }
}