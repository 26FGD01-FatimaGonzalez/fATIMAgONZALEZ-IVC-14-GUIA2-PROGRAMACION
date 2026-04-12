internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese la cantidad en metros: ");
        double metros = double.Parse(Console.ReadLine());

        Console.WriteLine("Seleccione conversión: \na) Pies\nb) Centímetros\nc) Pulgadas");
        char opcion = Console.ReadKey().KeyChar;
        Console.WriteLine();

        switch (char.ToLower(opcion))
        {
            case 'a':
                Console.WriteLine($"{metros}m son {metros * 3.28084} pies.");
                break;
            case 'b':
                Console.WriteLine($"{metros}m son {metros * 100} cm.");
                break;
            case 'c':
                Console.WriteLine($"{metros}m son {metros * 39.3701} pulgadas.");
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}