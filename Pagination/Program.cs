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

app.MapGet("/logs/pageNumber/{pageNumber}/pageSize/{pageSize}/order/{order}",
    async (ILogRepository logsRepository, int pageNumber = 1, int pageSize = 10, string order = "desc") =>
{
    return await logsRepository.GetLogsAsync(pageNumber, pageSize, order);
})
.WithName("GetLogs")
.WithOpenApi();

app.Run();
