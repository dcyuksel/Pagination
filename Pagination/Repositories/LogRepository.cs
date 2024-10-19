using Pagination.Entities;
using Pagination.Models;

namespace Pagination.Repositories;

public class LogRepository(PaginationDbContext context) : ILogRepository
{
    public async Task<PagedList<LogEntity>> GetLogsAsync(int pageNumber = 1, int pageSize = 10, string order = "desc")
    {
        pageNumber = pageNumber < 1 ? 1 : pageNumber;
        pageSize = pageSize < 0 ? 10 : pageSize;
        pageSize = pageSize > 100 ? 100 : pageSize;

        var query = context.Logs.AsQueryable();
        if (order == "desc")
        {
            query = query.OrderByDescending(e => e.TimeStamp);
        }
        else
        {
            query = query.OrderBy(e => e.TimeStamp);
        }

        return await PagedList<LogEntity>.CreateAsync(query, pageNumber, pageSize);
    }
}
