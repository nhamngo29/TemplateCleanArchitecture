namespace CleanArchitecture.Application.Abstractions.Data;

using Domain.Entities;
using Microsoft.EntityFrameworkCore;

public interface IAppDbContext
{
    DbSet<TodoItem> Todos { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
