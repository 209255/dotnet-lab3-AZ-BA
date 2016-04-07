using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations;
namespace JTTT_1._0.Database
{
    public class TaskServiceDbContext:DbContext
    {
        public TaskServiceDbContext() : base("Tasks1")
        {
            System.Data.Entity.Database.SetInitializer<TaskServiceDbContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<Task>()
            //    .HasRequired<IReaction>(u => u.Reaction)
            //    .WithRequiredDependent(c => c.Task).Map(p => p.MapKey("ReactionId"));
            //modelBuilder.Entity<Task>()
            //    .HasRequired<IAction>(u => u.Action)
            //    .WithRequiredDependent(c => c.Task).Map(p => p.MapKey("ActionId"));
            //modelBuilder.Entity<Task>()
            //   .HasRequired<IModel>(u => u.ActionModel)
            //   .WithRequiredDependent(c => c.Task).Map(p => p.MapKey("ActionModelId"));
            //modelBuilder.Entity<Task>()
            //   .HasRequired<IModel>(u => u.ReactionModel)
            //   .WithRequiredDependent(c => c.Task).Map(p => p.MapKey("ReactionModelId"));
        }

        public DbSet<Task> Tasks { get; set; }
        



    }
}