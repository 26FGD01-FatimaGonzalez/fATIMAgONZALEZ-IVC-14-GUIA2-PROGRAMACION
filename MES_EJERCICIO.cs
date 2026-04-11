using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingresa un número del 1 al 12.");
        int mes;
        mes = Convert.ToInt32(Console.ReadLine());
        switch(mes) {
            case 1:
                Console.WriteLine("Es el mes de ENERO y tiene 31 dias");
                break;
                case 2:
                Console.WriteLine("Es el mes de FEBRERO y tiene 29 dias en año COMÚN");
                break;
                case 3:
                Console.WriteLine("Es el mes de MARZO y tiene 31 dias");
                break;
                case 4:
                Console.WriteLine("Es el mes de ABRIL y tiene 30 dias");
                break;
                case 5:
                Console.WriteLine("Es el mes de MAYO y tiene 31 dias");
                break;
                case 6:
                Console.WriteLine("Es el mes de JUNIO y tiene 30 dias");
                break;
                case 7:
                Console.WriteLine("Es el mes de JULIO y tiene 31 dias");
                break;
                case 8:
                Console.WriteLine("Es el mes de AGOSTO y tiene 31 dias");
                break;
                case 9:
                Console.WriteLine("Es el mes dde SEPTIEMBRE y tiene 30 dias");
                break;
                case 10:
                Console.WriteLine("Es el mes de OCTUBRE y tiene 31 dias");
                break;
                case 11:
                Console.WriteLine("Es el mes de NOVIEMBRE y tiene 30 dias");
                break;
                case 12:
                Console.WriteLine("Es el mes de DICIEMBRE y tiene 31 dias");
                break;
                default:
                Console.WriteLine("ESTE NO ES UN MES VALIDO");
                break;

        }
    }
}