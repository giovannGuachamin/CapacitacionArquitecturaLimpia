using AplicationCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infraestructure;

public static class Dependencias
{
    public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        //Nota: En un ambiente real esto debe ejecutarse solo en ambiente de desarrollo
        services.AddDbContext<ApplicationContext>(options =>
            options.UseInMemoryDatabase("ArquitecturaLimpia"));

        //Agrega algunos productos de prueba a la base de datos en memoria
        using (var context = services.BuildServiceProvider().GetService<ApplicationContext>())
        {
            context!.Productos.Add(new Producto { Id = 1, Nombre = "CAMISETA DE LOGICSTUDIO", Precio = 100, Descuento = (decimal)0.2 });
            context.Productos.Add(new Producto { Id = 2, Nombre = "GORRA DE NETBY", Precio = 200, Descuento = (decimal) 0.3 });
            context.Productos.Add(new Producto { Id = 3, Nombre = "MOUSEPAD DE PRODUBANCO", Precio = 300, Descuento = (decimal) 0.8 });
            context.SaveChanges();
        }
    }
}
