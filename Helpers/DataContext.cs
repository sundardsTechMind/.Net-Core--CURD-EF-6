namespace WebApi.Helpers;

using Microsoft.EntityFrameworkCore;
using WebApi.Entities;

public class DataContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // dotnet tool install - g dotnet - ef
        // dotnet tool update - g dotnet - ef

        //dotnet add package Microsoft.EntityFrameworkCore.SqlServer
        //dotnet add package Microsoft.EntityFrameworkCore.Design


        //dotnet ef migrations add InitialCreate
        //dotnet ef database update

        options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
    }

    public DbSet<User> Users { get; set; }
}