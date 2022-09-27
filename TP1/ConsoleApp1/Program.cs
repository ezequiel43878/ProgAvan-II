using System;
using System.ComponentModel; 


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

        Comentario();

        EnumeracionDias();

        EnumeracionDiass2();
    }

    // 1) Crear una función que devuelva la suma de dos números recibidos por parámetros
    public static int Sumar(int nro1, int nro2)
    {
        return nro1 + nro2;
    }

    // 2) Crear una función que reciba una cadena de 8 caracteres y retorne en el mismo parámetro la cadena cortada de izquierda a derecha en 4 caracteres.
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
    
    // 3) Crear una función que devuelva la fecha y hora actual
    public static void FechayHora()
    {
        Console.WriteLine("3) ");
        Console.WriteLine("   La fecha y hora actual es: {0}", DateTime.Now);
    }


    // 4) Escribir un comentario //
    public static void Comentario() 
    { 
            // Este es un comentario de una línea. 
            Console.WriteLine("Escribiendo un comentario con // ...", DateTime.Now); 
    } 


    // 1) Enumeraciones 
    public enum diaSemana 
    { 
        Domingo = 1, 
        Lunes = 2, 
        Martes = 3, 
        Miercoles = 4, 
        Jueves = 5, 
        Viernes = 6, 
        Sabado = 7, 
    } 

    public static void EnumeracionDias() 
    { 
             
        foreach (int i in Enum.GetValues(typeof(diaSemana))) 
        { 

               Console.Write($"{Enum.GetName(typeof(diaSemana),i)}"); 
               Console.WriteLine($": {i}");  
        } 
               Console.ReadKey(); 
    } 

        
    // 2) Agregar a la enumeración la posibilidad de Imprimir un Texto por cada día de la semana 
     
    public enum diaSemana2 

        { 
          [Description("Texto 1")] 
            Domingo = 1, 
          [Description("Texto 2")] 
           Lunes = 2, 
          [Description("Texto 3")] 
           Martes = 3, 
          [Description("Texto 4")] 
           Miercoles = 4, 
          [Description("Texto 5")] 
           Jueves = 5, 
          [Description("Texto 6")] 
           Viernes = 6, 
          [Description("Texto 7")] 
           Sabado = 7, 
        } 
    public static void EnumeracionDiass2() 
    { 

            foreach (int i in Enum.GetValues(typeof(diaSemana2))) 

            { 

                var dia = Enum.GetName(typeof(diaSemana), i); 

                Console.Write($"{dia}"); 

                Console.WriteLine($": {i}"); 

                diaSemana2 diaDescripcion = (diaSemana2)System.Enum.Parse(typeof(diaSemana2), dia); 
 

                var description = diaDescripcion.GetType() 

                .GetMember(diaDescripcion.ToString())[0] 

                .GetCustomAttributes(typeof(DescriptionAttribute), inherit: false)[0] as DescriptionAttribute; 

                Console.WriteLine(description.Description); 
            } 

            Console.ReadKey(); 
    } 
}
