internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("SECTORES ESTADIO DOROTEO GUAMUCH FLORES");
        Console.WriteLine("1. Palco (Q300.00)");
        Console.WriteLine("2. Tribuna (Q125.00)");
        Console.WriteLine("3. Preferencia (Q75.00)");
        Console.WriteLine("4. Generales (Q50.00)");
        Console.Write("Seleccione el sector (1-4): ");
        int sector = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de entradas: ");
        int cantidad = int.Parse(Console.ReadLine());
        double precio = 0;
        switch (sector)
        {
            case 1:
                precio = 300.00;
                break;
            case 2:
                precio = 125.00;

                break;
            case 3:
                precio = 75.00;
                break;
            case 4:
                precio = 50.00;
                break;
            default:
                Console.WriteLine("Error: Sector no válido.");
                break;

       
        }
        double total = precio * cantidad;

        // CORRECCIÓN 3: Mostrar el resultado
        Console.WriteLine("\n--- RESUMEN DE COMPRA ---");
        Console.WriteLine("Precio unitario: Q" + precio);
        Console.WriteLine("Cantidad: " + cantidad);
        Console.WriteLine("Total a pagar: Q" + total);
    }
}