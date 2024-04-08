namespace AplicationCore;

public interface IProductoRepository
{
    IEnumerable<Producto> ObtenerTodosLosProductos();
}
