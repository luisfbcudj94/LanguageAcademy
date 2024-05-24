using LanguageAcademyApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
namespace LanguageAcademyApi.Persistance.DBContext
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Class> Classes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<ScheduledClass> ScheduledClasses { get; set; }
        public DbSet<TypeClass> TypeClasses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfiguration(new APITypeSeed());
        }
    }
}
