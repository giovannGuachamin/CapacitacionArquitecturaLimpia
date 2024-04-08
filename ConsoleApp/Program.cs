using Infraestructure;
using AplicationCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

Console.WriteLine("Hello, World!");

//Create a service builder for a console application
var services = new ServiceCollection();
//Instance a configuration object
var configuration = new ConfigurationBuilder().Build();

//Register the dependencies
//Nota: En un ambiente real esto debe ejecutarse solo en ambiente de desarrollo, en ambiente de producción se debe registrar en contexto de base de datos
Dependencias.ConfigureServices(services, configuration);

services.AddScoped<IProductoRepository, ProductoRepository>();

//Create a service provider
var serviceProvider = services.BuildServiceProvider();

//Get the repository
var productoRepository = serviceProvider.GetService<IProductoRepository>();

//Get all the products
var products = productoRepository.ObtenerTodosLosProductos();

foreach(var product in products)
{
    Console.WriteLine($"Id: { product.Id}, Nombre: {product.Nombre} Precio: {product.Precio}, Descuento: {product.Descuento}");
}