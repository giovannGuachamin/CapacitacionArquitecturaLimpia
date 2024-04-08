using AplicationCore;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure;

public class ApplicationContext : DbContext
{
    public DbSet<Producto> Productos { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
    }
}
