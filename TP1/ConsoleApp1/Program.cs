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

        Console.WriteLine("Enumerar-1) ");
        EnumeracionDias();

        Console.WriteLine("Enumerar-2) ");
        EnumeracionDiass2();

        Console.WriteLine("Conversion-1) ");
        Conversion();

        Console.WriteLine("Colores");
        Colores(); 

        Console.WriteLine("Mayora10");
        Mayora10();

        Console.WriteLine("MayorElse");
        Console.Write("Ingrese un Nro:"); 
        MayorElse(int.Parse(Console.ReadLine()));

        Mayora50();

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
        Console.WriteLine("4) ");
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

            Console.Write($"{Enum.GetName(typeof(diaSemana), i)}");
            Console.WriteLine($": {i}");
        }
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

    }

    /*1) Realizar la conversión de true, false, 1 y 0 utilizando los métodos Convert., bool.Parse y bool.TryParse.
    Explique cómo responde en cada caso cada uno de los métodos indicados. */


    public static void Conversion()
    {

        bool boolean = System.Convert.ToBoolean(1); //retorna true al convertir el 1 entero a boleano 
        Console.WriteLine(boolean);
        boolean = System.Convert.ToBoolean(0); //retorna false al convertir el 0 entero a boleano 
        Console.WriteLine(boolean);
        boolean = System.Convert.ToBoolean("true"); //retorna true al convertir el string a boleano 
        Console.WriteLine(boolean);
        boolean = System.Convert.ToBoolean("false"); //retorna false al convertir el string a boleano 
        Console.WriteLine(boolean);


        boolean = bool.Parse("true"); //retorna true al convertir el string a boleano 
        Console.WriteLine(boolean);
        boolean = bool.Parse("false"); //retorna false al convertir el string a boleano 
        Console.WriteLine(boolean);




        bool flag;

        boolean = Boolean.TryParse("true", out flag);
        Console.WriteLine(boolean);
        boolean = Boolean.TryParse("false", out flag);
        Console.WriteLine(boolean);
        //retorna intenta convertir el string a boleano en caso de exito retorna un true y el valor parceado (boolean y flag) 

        boolean = Boolean.TryParse("algo", out flag);
        Console.WriteLine(boolean);
        //retorna intenta convertir el string a boleano en caso de fracaso retorna un false solamente 
    } 

 /* 3. Escriba una sentencia switch utilizando una enumeración con 3 colores (blanco, azul y negro) 
 y paracada caso indicar un mensaje de cual es el color informado. //Ale
 
 */
    public static void Colores()
    {
        char ch;
        Console.WriteLine("Que tipo de color eliges? \n B) blanco.\n A) Azul .\n N) Negro.");
        ch = Convert.ToChar(Console.ReadLine());
        switch(Char.ToLower(ch))
         {
             case 'a':
             Console.WriteLine("Color informado: Azul");
             break;
             case 'b':
             Console.WriteLine("Color informado: Blanco");
             break;
             case 'n':
             Console.WriteLine("Color informado: Negro");
             break;
             default:
             Console.WriteLine("no hay color para esa opcion");
             break;
         }//swich    
         
    }//void


/*    4) Si se tiene una variable entera a, realice una sentencia if para evaluar si     
la variable a es mayor a 10. Si es verdad, mostrar un mensaje indicando que el valor es mayor a 10. //Ale   */

    public static void Mayora10()
    {
        int a;
        Console.WriteLine("Ingrese un numero: ");
        a = Convert.ToInt32(Console.ReadLine());  
        if (a > 10){
        Console.WriteLine($"El numero: {a}, es mayor a 10"); 
        }
        else
        {
        Console.WriteLine($"El numero: {a}, no es mayor a 10"); 
        }
        Console.WriteLine("Adios"); 
    }

    //5) Al ejercicio del punto 4), agregar la sentencia de else y, en ella, indicar un mensaje de error. 
    public static Boolean MayorElse(int valor ) 
    { 

        //Console.Write("Ingrese un Nro:"); 

        //int valor = int.Parse(Console.ReadLine()); 
        Boolean retorno=false;
        if (valor > 10) 
        { 
            Console.Write("El Nro es Mayor a 10");
            retorno =true;
        } 
        else 
        { 
            Console.Write("El nro de ser mayor a 10 "); 
            retorno =false;
        } 
        //Console.ReadKey(); 

        return retorno;
    }

    /* 6) ¿Cuál es la diferencia entre la sentencia for y foreach? ¿Cuándo se debe utilizar cada una de ellas?

    Respuesta en el Readme
    
    */

    //  7) Defina una variable a que en cada ciclo de una sentencia while incremente su valor en 5. Cuando la variable a exceda el valor de 50, el ciclo while debe finalizar.

    private static void Mayora50(){

        int a = 0;

        while (a <= 50)
        {
            Console.WriteLine(a);
            a = a + 5;
        }
    }

}
