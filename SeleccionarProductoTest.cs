[TestClass]
public class SeleccionProductoTest
{
    [TestMethod]
    public void BuscarProductoPorNombre()
    {
        // Arrange
        var producto = new Producto()
        {
            Nombre = "Producto 1",
            Categoria = "Categoria 1"
        };

        var repositorioProductos = new RepositorioProductos();
        repositorioProductos.Agregar(producto);

        var cliente = new Cliente();

        // Act
        var productosEncontrados = cliente.BuscarProductos("Producto 1");

        // Assert
        Assert.AreEqual(1, productosEncontrados.Count);
        Assert.AreEqual(producto.Nombre, productosEncontrados[0].Nombre);
    }

    [TestMethod]
    public void BuscarProductoPorCategoria()
    {
        // Arrange
        var producto = new Producto()
        {
            Nombre = "Producto 1",
            Categoria = "Categoria 1"
        };

        var repositorioProductos = new RepositorioProductos();
        repositorioProductos.Agregar(producto);

        var cliente = new Cliente();

        // Act
        var productosEncontrados = cliente.BuscarProductos("Categoria 1");

        // Assert
        Assert.AreEqual(1, productosEncontrados.Count);
        Assert.AreEqual(producto.Nombre, productosEncontrados[0].Nombre);
    }

    [TestMethod]
    public void SeleccionarProducto()
    {
        // Arrange
        var producto = new Producto()
        {
            Nombre = "Producto 1",
            Categoria = "Categoria 1"
        };

        var repositorioProductos = new RepositorioProductos();
        repositorioProductos.Agregar(producto);

        var cliente = new Cliente();

        // Act
        cliente.SeleccionarProducto(producto);

        // Assert
        Assert.AreEqual(producto, cliente.Carrito.Producto);
    }
}
