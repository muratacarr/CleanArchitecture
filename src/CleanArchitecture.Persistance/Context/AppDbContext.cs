using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Reflection.Metadata;

namespace CleanArchitecture.Persistance.Context;

public sealed class AppDbContext : DbContext, IAppDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Car> Cars => Set<Car>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var entries=ChangeTracker.Entries<Car>();

        foreach (var entry in entries)
        {
            if (entry.State==EntityState.Added)          
               entry.Property(p => p.CreatedDate).CurrentValue = DateTime.Now;

            if (entry.State==EntityState.Modified)
                entry.Property(p=>p.UpdatedDate).CurrentValue = DateTime.Now;
            
        }


        return base.SaveChangesAsync(cancellationToken);
    }
}
