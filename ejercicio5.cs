internal class Program
{
    private static void Main(string[] args)
    {
        const double PRECIO_SIN_IVA = 650.00;
        double precioConIva = PRECIO_SIN_IVA * 1.12;

        Console.Write("Cantidad de impresoras: ");
        int cantidad = int.Parse(Console.ReadLine());

        Console.WriteLine("Forma de pago: 1.Efectivo, 2.Tarjeta, 3.Vale");
        int opcion = int.Parse(Console.ReadLine());

        double totalSinDesc = cantidad * precioConIva;
        double porcDesc = 0;
        string formaPago = "";

        switch (opcion)
        {
            case 1: porcDesc = 0.10; formaPago = "Efectivo"; break;
            case 2: porcDesc = 0.05; formaPago = "Tarjeta de Crédito"; break;
            case 3: porcDesc = 0.15; formaPago = "Vale de Regalo"; break;
            default: formaPago = "Otro (Sin descuento)"; break;
        }

        double montoDescuento = totalSinDesc * porcDesc;
        double totalFinal = totalSinDesc - montoDescuento;

        Console.WriteLine("\n--- RESUMEN ---");
        Console.WriteLine($"Cantidad: {cantidad}");
        Console.WriteLine($"Precio Unitario (C/IVA): Q{precioConIva:F2}");
        Console.WriteLine($"Total sin descuento: Q{totalSinDesc:F2}");
        Console.WriteLine($"Forma de pago: {formaPago}");
        Console.WriteLine($"Descuento: Q{montoDescuento:F2}");
        Console.WriteLine($"Total a pagar: Q{totalFinal:F2}");
    }
}
