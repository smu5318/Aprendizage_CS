using System;

namespace Sintaxis_Basica
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            
            
            /*//Metodos
            int resultado;

            Console.WriteLine("Programa de suma y multiplicación del resultado");

            Console.WriteLine("Introduce el primer número:");
            num1=int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número:");
            num2=int.Parse(Console.ReadLine());
            
            resultado=sumaNumeros();

            Console.WriteLine("El resultado es:"+resultado);      //La sintaxis para llamar un metodo es: "nombreMetodo(parametros, divididosPorComas, Opcional);"
            
            Console.WriteLine("Introduce el valor por el que multiplicar el resultado:");
            multiplicacionNumeros(int.Parse(Console.ReadLine()), resultado);

            //un metodo es un proceso que solo funciona cuando se llama, puede tener parametros"num1, num2"
            int sumaNumeros(){        //La sintaxis para declarar un metodo es:"tipodeDato nombreMetodo(parametros, opcional){return;}"
                int resultado= num1+num2;
                return resultado;                       //todo return que no sea void, debe regresar un "return" con el valor que va a devolver el metodo
            }*/
            /*//Conversión de texto 

            Console.WriteLine("Programa De Multiplicaciones");

            Console.WriteLine("Introduce el primer número:");
            num1=int.Parse(Console.ReadLine());                 //El "Parse" es un metodo que permite convertir texto a un numero
            
            Console.WriteLine("Introduce el segundo número:");
            num2=int.Parse(Console.ReadLine());                 //El "readLine" es un metodo que permite que el usuario introduzca un valor STRING

            Console.WriteLine("El resultado es: "+(num1*num2));*/
            /*//conversion explícita
            int num1=32.21;
            int num2=(int) num1;

            Console.WriteLine(num1);    //"Console" es una clase de la libreria "System" y "WriteLine" es un metodo que nos permite imprimir un dato en la consola
            Console.WriteLine(num2); */

        }

        /*  //Metodos static
            static void multiplicacionNumeros(int num3, int resultado){
            Console.WriteLine(resultado*num3);
        }*/
    }
}
