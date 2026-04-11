using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("==========CALCULADORA DE FUNCIONES TRIGONOMETRICAS BASICAS==========");
        Console.WriteLine("1-Seno");
        Console.WriteLine("2-Coseno");
        Console.WriteLine("3-Tangente");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("Ingrese el ángulo:");
        double anguloGrados = Convert.ToDouble(Console.ReadLine);
        double anguloRadianes = anguloGrados * (Math.PI / 180.0);
        Console.WriteLine("Escoge la opcion que deseas: ");
        int opcion = Convert.ToInt32(Console.ReadLine());
        switch(opcion)   {
            case 1:
                Console.WriteLine("El seno de tu angulo es:" + Math.Sin(anguloRadianes));
                break;
                    case 2:
                Console.WriteLine("El coseno de tu angulo es: " + Math.Cos(anguloRadianes));
                break;
                case 3:
                Console.WriteLine("La tangente de tu angulo es: " + Math.Tan(anguloRadianes));
                break;
            default:
                Console.WriteLine("EROR MATEMATICO");
                break;
        }
    }
    }