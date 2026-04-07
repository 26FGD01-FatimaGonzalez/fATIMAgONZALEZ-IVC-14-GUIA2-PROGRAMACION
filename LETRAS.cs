internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una letra de las siguientes");
        Console.WriteLine("1-A");
        Console.WriteLine("2-B");
        Console.WriteLine("3-C");
        Console.WriteLine("4-D");
        Console.WriteLine("5-F");
        string letra = Console.ReadLine();
        switch (letra)
        {
            case "A":
                Console.WriteLine("EXCELENTE");
                break;
            case "B":
                Console.WriteLine("Bueno");
                break;
            case "C":
                Console.WriteLine("Regular");
                break;
            case "D":
                Console.WriteLine("Deficiente");
                break;
            case "F":
                Console.WriteLine("Reprobado");
                break;
            default:
                Console.WriteLine("La letra no es valida");
                break;
        }
    }
}