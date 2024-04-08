using AplicationCore;

namespace Infraestructure;

public class ProductoRepository : IProductoRepository
{
    public readonly ApplicationContext _context;

    public ProductoRepository(ApplicationContext context)
    {
        _context = context;
    }

    public IEnumerable<Producto> ObtenerTodosLosProductos()
    {
        return _context.Productos.ToList();
    }
}
