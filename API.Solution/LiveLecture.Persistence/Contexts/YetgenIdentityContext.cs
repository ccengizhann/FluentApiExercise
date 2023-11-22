using LiveLecture.Domain.Entities;
using LiveLecture.Domain.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LiveLecture.Persistence.Contexts
{
    public class YetgenIdentityContext: IdentityDbContext<User,Role,Guid>
    {
        public YetgenIdentityContext(DbContextOptions<YetgenIdentityContext>dbContextOptions) : base(dbContextOptions) 
        
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Ignore<Student>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
