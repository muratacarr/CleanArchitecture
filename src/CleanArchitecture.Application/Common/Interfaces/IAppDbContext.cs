using CleanArchitecture.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Common.Interfaces
{
    public interface IAppDbContext
    {
        DbSet<Car> Cars { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
