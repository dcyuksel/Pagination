﻿using Microsoft.EntityFrameworkCore;

namespace Pagination.Models;

public class PagedList<T> : List<T>
{
    public PagedList(IEnumerable<T> currentPage, int count, int pageNumber, int pageSize)
    {
        CurrentPage = pageNumber;
        PageSize = pageSize;
        TotalCount = count;
        AddRange(currentPage);
    }

    public readonly IReadOnlyList<int> AvailablePageSizes = [10, 25, 50, 100];
    public int CurrentPage { get; set; }
    public int PageSize { get; set; }
    public int TotalCount { get; set; }
    public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
    public bool IsPreviousPageExists => CurrentPage > 1;
    public bool IsNextPageExists => CurrentPage < TotalPages;

    public static async Task<PagedList<T>> CreateAsync(IQueryable<T> source, int pageNumber, int pageSize)
    {
        var count = await source.CountAsync();
        var items = await source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

        return new PagedList<T>(items, count, pageNumber, pageSize);
    }
}
