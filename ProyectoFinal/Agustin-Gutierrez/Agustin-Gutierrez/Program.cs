
using Agustin_Gutierrez.Clases;

namespace Agustin_Gutierrez
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //Ejemplo basico, en este ejemplo el sistema de gestion se usa en una joyeria

            Usuario usuario = new Usuario(1, "Agustin", "Gutierrez", "agus123", "aguspassword", "agutierrez@gmail.com" , "Vendedor","10/05/2024" );

            Producto producto = new Producto(103, "Cadena de oro", 50000, 120000, 12, usuario.ObtenerId());

            Venta venta = new Venta(1, "Cadena de oro vendida en pagina web", usuario.ObtenerId() , "11/05/2024");

            ProductoVendido productoVendido = new ProductoVendido(1, producto.ObtenerId(), 12, venta.ObtenerId());

            Console.WriteLine("Usuario:");
            Console.WriteLine($"ID: {usuario.ObtenerId()}, Nombre: {usuario.ObtenerNombre()}, Apellido: {usuario.ObtenerApellido()}, Nombre de usuario: {usuario.ObtenerNombreUsuario()}, Mail: {usuario.ObtenerMail()}");

            Console.WriteLine("\nProducto:");
            Console.WriteLine($"ID: {producto.ObtenerId()}, Descripción: {producto.ObtenerDescripción()}, Costo: {producto.ObtenerCosto()}, Precio de venta: {producto.ObtenerPrecioVenta()}, Stock: {producto.ObtenerStock()}, ID de usuario: {producto.ObtenerIdUsuario()}");

            Console.WriteLine("\nVenta:");
            Console.WriteLine($"ID: {venta.ObtenerId()}, Comentarios: {venta.ObtenerComentarios()}, ID de usuario: {venta.ObtenerIdUsuario()}");

            Console.WriteLine("\nProductos Vendidos:");
            Console.WriteLine($"ID: {productoVendido.ObtenerId()}, ID de producto: {productoVendido.ObtenerIdProducto()}, Stock: {productoVendido.ObtenerStock()}, ID de venta: {productoVendido.ObtenerIdVenta()}");

        }
    }
}