using Pagination.Entities;
using Pagination.Models;

namespace Pagination.Repositories;

public class PeopleRepository(PaginationDbContext context) : IPeopleRepository
{
    public async Task<PagedList<PeopleEntity>> GetPeopleAsync(int pageNumber = 1, int pageSize = 10, string order = "desc")
    {
        pageNumber = pageNumber < 1 ? 1 : pageNumber;
        pageSize = pageSize < 0 ? 10 : pageSize;
        pageSize = pageSize > 100 ? 100 : pageSize;

        var query = context.People.AsQueryable();
        if (order == "desc")
        {
            query = query.OrderByDescending(e => e.Age);
        }
        else
        {
            query = query.OrderBy(e => e.Age);
        }

        return await PagedList<PeopleEntity>.CreateAsync(query, pageNumber, pageSize);
    }
}
