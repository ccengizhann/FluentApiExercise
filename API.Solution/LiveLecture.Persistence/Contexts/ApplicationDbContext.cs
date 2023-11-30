using LiveLecture.Domain.Entities;
using LiveLecture.Domain.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LiveLecture.Persistence.Contexts
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Ignore<User>();
            modelBuilder.Ignore<Role>();
            modelBuilder.Ignore<UserSetting>();


            base.OnModelCreating(modelBuilder);
        }
    }
}

