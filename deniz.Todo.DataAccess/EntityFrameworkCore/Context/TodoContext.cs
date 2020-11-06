using deniz.Todo.DataAccess.EntityFrameworkCore.Mapping_Configuration;
using deniz.Todo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
/// <summary>
/// Step 2.3 = Db Baglantisi
/// </summary>
namespace deniz.Todo.DataAccess.EntityFrameworkCore.Context
{
    public class TodoContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=UdemyBlogTodo;Trusted_Connection=True;");
        }

        /// <summary>
        /// 2.3.1 => Mapping Klasoru icerigi
        /// 2.3.1.1 = Fluent Api config ayarlari
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new WorkMap());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Work> Works { get; set; }

    }

}
