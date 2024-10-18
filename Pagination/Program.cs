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

builder.Services.AddScoped<IPeopleRepository, PeopleRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapGet("/people/pageNumber/{pageNumber}/pageSize/{pageSize}/order/{order}",
    async (IPeopleRepository peopleRepository, int pageNumber = 1, int pageSize = 10, string order = "desc") =>
{
    return await peopleRepository.GetPeopleAsync(pageNumber, pageSize, order);
})
.WithName("GetPeople")
.WithOpenApi();

app.Run();
