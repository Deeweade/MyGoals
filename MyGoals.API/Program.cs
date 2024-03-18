using MyGoals.Infrastructure.Repositories;
using MyGoals.Services.Interfaces;
using MyGoals.Domain.Repositories;
using MyGoals.Infrastructure.Data;
using MyGoals.Services.Services;
using MyGoals.API.Middlewares;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options =>
{
    options.SuppressAsyncSuffixInActionNames = false;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("MyGoalsPostgres"),
        b => b.MigrationsAssembly("MyGoals.API"));
});

builder.Services.AddTransient<ExceptionHandlingMiddleware>();

//adding repositories
builder.Services.AddScoped<IHomeRepository, HomeRepository>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEmployeeRequestRepository, EmployeeRequestRepository>();
builder.Services.AddScoped<IGoalRepository, GoalRepository>();

//adding services
builder.Services.AddScoped<IHomeService, HomeService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IEmployeeRequestService, EmployeeRequestService>();
builder.Services.AddScoped<IGoalService, GoalService>();

var app = builder.Build();

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();