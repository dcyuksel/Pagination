using Microsoft.EntityFrameworkCore;
using Pagination;
using Pagination.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthorization();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<PaginationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:Pagination"], options => { options.CommandTimeout(30); });
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

builder.Services.AddScoped<ILogRepository, LogRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapGet("/logs",
    async (ILogRepository logsRepository, int pageNumber = 1, int pageSize = 10, string order = "desc", string? severity = null) =>
{
    return await logsRepository.GetLogsAsync(pageNumber, pageSize, order, severity);
})
.WithName("GetLogs")
.WithOpenApi();

app.Run();
