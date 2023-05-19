using System;

namespace controlDeflujo;

class Program
{
    static void Main(string[] args)
    {
        if_();

        switch_();

        while_();

        Ejer1();
    }

    static void if_(){
        string carnet;
        bool bool1=true;
        int num1;
        const int num2=18;

        Console.WriteLine("¿Puedes conducir?");

        Console.WriteLine("Introduce tu edad:");
        num1=int.Parse(Console.ReadLine());

        Console.WriteLine("Tienes Carnet");
        carnet=Console.ReadLine();

        if (carnet=="si" && num1>=num2 && num1<=60){              //EL "if" solo ejecuta lo que esta dentro de si, si la condicion es verdadera
            Console.WriteLine("Puedes conducir vehiculos=");    
            Console.WriteLine(bool1);
        }
        else                                    //El "else" ejecuta lo de su interior, Solo si la condicion del "if" anterior a el no se cumple
        {
            Console.WriteLine("No Puedes conducir vehiculos=");
            Console.WriteLine(!bool1);                             //EL '!' me permite revertir el valor de un booleano
        }


    }

    static void switch_(){
        string Direccion;

        Console.WriteLine("Programa de encuesta");
        Console.WriteLine("Eres derecho o zurdo");
        Direccion=Console.ReadLine();

        switch(Direccion){
            case "derecho":                                                 //Los case pueden tener return
                Console.WriteLine("Eres derecho, gracias por colaborar");
                break;

            case "izquierdo":
                Console.WriteLine("Eres izquierdo, gracias por colaborar");
                break;

            case "diestro":
                Console.WriteLine("Eres diestro, gracias por colaborar");
                break;

            case "zurdo":
                Console.WriteLine("Eres zurdo, gracias por colaborar");    
                break;
            
            case "bidiestro":
                Console.WriteLine("Eres bidiestro, gracias por colaborar");
                break;
            
            default:            //Se usa para cuando el "switch" no encuentra un dato coincidente
                Console.WriteLine("Asegurate de estar escribiendo bien la respuesta");
                break;
        }
    }

    static void while_(){               
        //esta el bucle "while" que ejecutara lo de su interior si la condición se cumple y el bucle "do while" qu eejecuta su interior 1 vez aunque la condición sea falsa
        //la sintaxis es:   do{Console.WriteLine("Hola Mundo");}while(3!=4);

        string resp1;
        int resu1;
        int num1;
        int num2;
        int num3;
        
        Console.WriteLine("Bienvenido al programa de sumas");
        Console.WriteLine("Introduce el primer numero:");
        num1=int.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el siguiente numero:");
        num2=int.Parse(Console.ReadLine());

        resu1=num1+num2;

        Console.WriteLine("¿Quieres sumar otro numero?");
        resp1=Console.ReadLine();

        while(resp1!="no"){                     //El while repite lo de su interior simpre que la condición se cumpla
            Console.WriteLine("Introduce el siguiente numero:");
            num3=int.Parse(Console.ReadLine());
            resu1=resu1+num3;
            
            Console.WriteLine("¿Quieres sumar otro numero?");
            resp1=Console.ReadLine();
        }
        
        Console.WriteLine("El resultado es:"+resu1);
        Console.WriteLine("Gracias por usar el programa");
    }

    static void Ejer1(){
        Random numero=new Random();             //Estas dos lineas de codigo me permiten generar un numero aleatorio
        int numAleatorio=numero.Next(0,100);

        int res1;
        int numIntentos=0;

        Console.WriteLine("Bienvenido al juego");
        Console.WriteLine("Tienes que introdicir un numero del 0 al 100 hasta adivinar el correcto, el programa va a dar pistas");
        Console.WriteLine("Empezemos. Introduce un numero del 0 al 100:");
        res1=int.Parse(Console.ReadLine());
        numIntentos++;

        while(res1 != numAleatorio){
            
            if (res1<numAleatorio){
                Console.WriteLine("El numero oculto es mayor");
            }
            else{
                Console.WriteLine("El numero oculto es menor");
            }
            Console.WriteLine("Intentalo de nuevo:");
            res1=int.Parse(Console.ReadLine());

            numIntentos++;
        }

        Console.WriteLine($"Felicidades, Ganaste en {numIntentos} intentos");

    }
}