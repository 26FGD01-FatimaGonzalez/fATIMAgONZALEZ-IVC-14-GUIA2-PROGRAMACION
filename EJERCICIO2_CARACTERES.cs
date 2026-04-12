internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingresa un caracter de digito o vocal:");
        string caracter1 = Console.ReadLine();
        switch (caracter1) {
            case "0":
            case "1":
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
                Console.WriteLine("Tu caracter es un digito");
                break;
            case "a":
                case "b":
                case "i":
            case "o": 
                case "u":
                Console.WriteLine("Tu caracter es una vocal");
                break;
            default:
                Console.WriteLine("NO ES VALIDO");
                break;
                
        }
    }
}