using Microsoft.EntityFrameworkCore;
using Pagination.Entities;

namespace Pagination;

public class PaginationDbContext(DbContextOptions<PaginationDbContext> options) : DbContext(options)
{
    public virtual DbSet<LogEntity> Logs { get; set; }
}
