using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MyGoals.Infrastructure.Data
{
    //public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    //{
    //    public ApplicationDbContext CreateDbContext(string[] args)
    //    {
    //        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

    //        var builder = new ConfigurationBuilder().Build();

    //        // получаем строку подключения из файла appsettings.json
    //        string connectionString = builder.GetConnectionString("MyGoalsPostgres");
    //        optionsBuilder.UseNpgsql(connectionString, opts => opts.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds));
    //        return new ApplicationDbContext(optionsBuilder.Options);
    //    }
    //}
}

