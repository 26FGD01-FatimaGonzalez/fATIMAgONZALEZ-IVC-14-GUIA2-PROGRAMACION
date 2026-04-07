internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("========CALCULADORA========");
        Console.WriteLine("========MENU DE OPCIONES========");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        Console.WriteLine("Ingrese el número de la operación que desea realizar:");
        int opcion = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el primer número:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                Console.WriteLine("El resultado de la suma es: " + (num1 + num2));
                break;
            case 2:
                Console.WriteLine("El resultado de la resta es: " + (num1 - num2));
                break;
            case 3:
                Console.WriteLine("El resultado de la multiplicación es: " + (num1 * num2));
                break;
            case 4:
                Console.WriteLine("El resultado de la división es: " + (num1 / num2));
                break;

            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}