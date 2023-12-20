using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace NLayer.Repository;

public class AppDbContextFactory:IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseSqlServer("Server=ISTN37687;Database=UdemyNLayerDb;User=xeaydin;Password=Password12.;TrustServerCertificate=true");

        return new AppDbContext(optionsBuilder.Options);
    }
}