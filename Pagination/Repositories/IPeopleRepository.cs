using Pagination.Entities;
using Pagination.Models;

namespace Pagination.Repositories;

public interface IPeopleRepository
{
    Task<PagedList<PeopleEntity>> GetPeopleAsync(int pageNumber = 1, int pageSize = 10, string order = "desc");
}
