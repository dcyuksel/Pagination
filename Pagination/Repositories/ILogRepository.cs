using Pagination.Entities;
using Pagination.Models;

namespace Pagination.Repositories;

public interface ILogRepository
{
    Task<PagedList<LogEntity>> GetLogsAsync(int pageNumber = 1, int pageSize = 10, string order = "desc");
}
