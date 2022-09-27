public class Program
{
    public static void Main()
    {
        int nro1 = 2;
        int nro2 = 4;
        int resultado = Sumar(nro1, nro2);
        Console.WriteLine("1) ");
        Console.WriteLine("   El resultado de {0} + {1} es: {2}", nro1, nro2, resultado);
        Console.WriteLine("");

        CortarCadena();

        FechayHora();
    }

    public static int Sumar(int nro1, int nro2)
    {
        return nro1 + nro2;
    }

    public static void CortarCadena()
    {
        string texto;
        Console.WriteLine("2) ");
        do
        {
            Console.Write("   Ingrese un texto de 8 caracteres: ");
            texto = Console.ReadLine();
            if (texto.Length == 8)
            {
                Console.WriteLine("   Retorno: {0}", texto[..4]);
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("     El texto no tiene 8 caracteres.");
            }
        } while (texto.Length != 8);
    }

    public static void FechayHora()
    {
        Console.WriteLine("3) ");
        Console.WriteLine("   La fecha y hora actual es: {0}", DateTime.Now);
    }

}