using NUnit.Framework;
using System;
using System.Collections.Generic;

[TestClass]
public class GeneracionFacturaTest
{
    [TestMethod]
    public void GenerarFactura()
    {
        // Arrange
        var producto = new Producto()
        {
            Nombre = "Producto 1",
            Precio = 100
        };

        var cliente = new Cliente();
        cliente.SeleccionarProducto(producto);

        var vendedor = new Vendedor();
        var venta = vendedor.IniciarVenta(cliente);

        // Act
        var factura = vendedor.GenerarFactura(venta);

        // Assert
        Assert.NotNull(factura);
        Assert.AreEqual(producto.Nombre, factura.Producto);
        Assert
