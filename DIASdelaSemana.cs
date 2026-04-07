internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=========Dias de la semana=========");
        Console.WriteLine("Digite un numero del 1 al 7 para mostrar el dia de la semana");
        int dia;
        //solicitar el dato
        dia = Convert.ToInt32(Console.ReadLine());
        switch (dia)
        { 
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miercoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            case 6:
                Console.WriteLine("Sabado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("Digite un valor entre el 1 al 7");
                break;
        }
    }
}