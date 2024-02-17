[TestClass]
public class InicioVentaTest
{
    [TestMethod]
    public void IniciarVenta()
    {
        // Arrange
        var producto = new Producto()
        {
            Nombre = "Producto 1",
            Categoria = "Categoria 1"
        };

        var cliente = new Cliente();
        cliente.SeleccionarProducto(producto);

        var vendedor = new Vendedor();

        // Act
        var venta = vendedor.IniciarVenta(cliente);

        // Assert
        Assert.NotNull(venta);
        Assert.AreEqual(cliente, venta.Cliente);
        Assert.AreEqual(producto, venta.Producto);
    }
}
