# Programación Avanzada 2.
# Licenciatura en Gestión Tecnológica.

## Guía Práctica : Introducción C#


#### Generalidades

1. Crear una función que devuelva la suma de dos números recibidos por parámetros
2. Crear una función que reciba una cadena de 8 caracteres y retorne en el mismo parámetro la cadena cortada de izquierda a derecha en 4 caracteres.
3. Crear una función que devuelva la fecha y hora actual
4. Escribir un comentario con //
5. Escribir un comentario con /*   */

#### Enumeraciones

1. Crear una enumeración con los días de la semana, comenzando por Domingo con valor 1.

2. Agregar a la enumeración la posibilidad de Imprimir un Texto por cada día de la semana

#### Conversiones

1.  Realizar la conversión de true, false, 1 y 0 utilizando los métodos Convert., bool.Parse y bool.TryParse. Explique cómo responde en cada caso cada uno de los métodos indicados.

2. Explique que sucede en los siguientes intentos de casteos de datos.
```
   int a = (int)344.4;
```
***Respuesta**: Se toma la parte entera del número 344.4 y se asigna a la variable a.*
```
   decimal a = 10;
```
***Respuesta**: No hay cambios, se asigna el valor 10 a la variable a de tipo decimal.*

```
   int a=443444;
   short b = (short)a;
```
***Respuesta**: Convierte la variable a a tipo short para asignar su valor a la variable b, también de tipo short.*

3. Escriba una sentencia switch utilizando una enumeración con 3 colores (blanco, azul y negro) y paracada caso indicar un mensaje de cual es el color informado.

4. Si se tiene una variable entera a, realice una sentencia if para evaluar si la variable a es mayor a 10. Si es verdad, mostrar un mensaje indicando que el valor es mayor a 10. 

5. Al ejercicio del punto 4), agregar la sentencia de else y, en ella, indicar un mensaje de error.

6. ¿Cuál es la diferencia entre la sentencia for y foreach? ¿Cuándo se debe utilizar cada una de ellas?

    El Bucle for es una estructura de control determinada porque se conoce a priori dónde empieza y dónde termina.
    La sentencia for consta de 3 partes:

       + Condición de comienzo
       + Condición de parada del proceso
       + Condición de incremento del for

    Utilizamos for con Arrays (una variable que almacena una gran cantidad de datos de un mismo tipo) para imprimirlos,
    accederlos, y realizar operaciones con ellos.
    Ademas un for se puede combinar con otras sentencias de control, como  if-else, if, etc., para darle más funcionalidad
    a nuestro programa.

    Asimismo, se pueden utilizar dentro del bucle for las sentencias de corte continue y break.
    Break detiene el bucle completamente.
    Continue detiene únicamente la iteración actual y salta a la siguiente.

    También podemos establecer una evaluación booleana que siempre sea true, el bucle no dejará nunca de ejecutarse hasta que el programa
    se detenga por falta de memoria.

    No podemos utilizar false en un bucle for.


    En cambio, el bucle for-each no permite tanto control como el bucle for.
    La sentencia for-each nos permite recorrer una lista de objetos o variables primitivas, tiene la ventaja de que no es necesario
    utilizar una variable que haga de contador ni requiere establecer una condición para comprobar si debe finalizar la iteración.

    La estructura for-each tiene una construcción sencilla, primero la palabra for seguida de un paréntesis, dentro de este hay 3 partes

        + Tipo de dato que se va a extraer.
        + Tipo de variable primitiva.
        + Nombre que recibe la variable local con la que se va a operar el bucle.
    
    No se puede prescindir de ninguna de las tres partes.

7. Defina una variable a que en cada ciclo de una sentencia while incremente su valor en 5. Cuando la variable a exceda el valor de 50, el ciclo while debe finalizar.
