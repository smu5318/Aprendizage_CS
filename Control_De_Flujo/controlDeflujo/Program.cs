using System;

namespace controlDeflujo;

class Program
{
    static void Main(string[] args)
    {
        //if_();

        Switch();
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

        if (carnet=="si" && num1>=num2 && num1<=60){              //EL "if" solo jecuta lo que esta dentro de si, si la condicion es verdadera
            Console.WriteLine("Puedes conducir vehiculos=");    
            Console.WriteLine(bool1);
        }
        else                                    //El "else" ejecuta lo de su interior, Solo si la condicion del "if" anterior a el no se cumple
        {
            Console.WriteLine("No Puedes conducir vehiculos=");
            Console.WriteLine(!bool1);                             //EL '!' me permite revertir el valor de un booleano
        }


    }

    static void Switch(){
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
}