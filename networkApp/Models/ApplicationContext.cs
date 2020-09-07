using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace networkApp.Models
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            SetDateTime();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }
        public override int SaveChanges()
        {
            SetDateTime();
            return base.SaveChanges();
        }
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            SetDateTime();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            SetDateTime();
            return base.SaveChangesAsync(cancellationToken);
        }

        public DbSet<Tests> Tests { get; set; }


        private void SetDateTime()
        {
            
            var entries = ChangeTracker.Entries().ToList(); ;
            entries.ForEach(entry =>
            {
                if (entry.Entity is Tests test)
                {
                    if (entry.State == EntityState.Added)
                    {
                        test.DateTest = DateTime.Now;
                    }
                }
            });
        }
    }
}
