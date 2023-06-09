﻿using System;

namespace POO;

class Program
{
    static void Main(string[] args)
    {
        circulo();

        carro();
    
        Match();

        clasesAnonimas();
    }

    static void circulo(){
        //class circulo
        double radio;

        circulo miCirculo=new circulo();       //Creación de objeto/variable tipo circulo 
        Console.WriteLine("Calculo de area de circulo");
        Console.WriteLine("Introduce el radio del Circulo:");
        radio=double.Parse(Console.ReadLine());

        Console.WriteLine($"El area del circulo es {miCirculo.areaCirculo(radio)}");
    }

    static void carro(){
        //class carro
        carro carroVip=new carro();
        carro carroN=new carro();
        string resp1;
        string resp2;
        string resp3;
        string resp4;
        string resp5;
        string color;
        bool climatizador;
        bool toquesDeoro;

        Console.WriteLine("Bienvenido al programa de carros\nQuieres un coche comun o uno vip (En el vip puedes escoger el color asi como sus extras)");
        Console.WriteLine("Comun o vip:");
        resp1=Console.ReadLine();

        if (resp1=="vip"){
            Console.WriteLine("Cual va a ser el color del carro:");
            color=Console.ReadLine();

            carroVip=new carro(color);

            Console.WriteLine("Quieres añadir extras (climatizador, toques de oro), responde si o no");
            resp2=Console.ReadLine();

            if (resp2=="si"){
                Console.WriteLine("¿Quieres climatizador?");
                resp3=Console.ReadLine();
                if (resp3!="no"){climatizador=true;} else{climatizador=false;}

                Console.WriteLine("¿Quieres toques de oro en el carro?");
                resp4=Console.ReadLine();
                if (resp4!="no"){toquesDeoro=true;} else{toquesDeoro=false;}

                carroVip.setExtras(climatizador, toquesDeoro);
            } 
            else if (resp2=="no"){carroVip.setExtras(false,false);}
            
        }
        else{
            carroN=new carro();
        }

        Console.WriteLine("¿Quieres ver la información del carro?");
        resp5=Console.ReadLine();

        if (resp5!="no" && resp1 == "vip"){
            Console.WriteLine(carroVip.getCarro());
        }
        
        else if(resp5!="no" && resp1!="vip"){
            Console.WriteLine(carroN.getCarro());
        }

        Console.WriteLine("Gracias por usar el programa");
    }

    static void Match(){
        //El match es una clase que nos permite realizar operaciones matematicas complejas
        double a;
        double b;
        

        Console.WriteLine("Bienvenido al programa del teorema de pitagoras.");
        Console.WriteLine("Ingrese el largo de la linea A");
        a=double.Parse(Console.ReadLine());

        Console.WriteLine("Inngrese el largo de la linea B");
        b=double.Parse(Console.ReadLine());
        
        trianguloPitagoras hipotenusa=new trianguloPitagoras(a,b);

        Console.WriteLine("EL resultado es:");
        hipotenusa.GetHipotenusa();
    }

    static void clasesAnonimas(){

        //Clases Anonimas:
        var cuenta1=new {Nombre="Manuel", Edad=28};
        //Dentro de las llaves colocamos las variables de la clase anonima, no puede contener metodos   

        var cuenta2=new {Nombre="Ana", Edad=19}; 
        //Al colocar las mismas variables, en el mismo orden, y con el mismo tipo de datos, es de la misma clase que la "cuenta1" 
        
        
        Console.WriteLine(cuenta1.Nombre+" "+cuenta1.Edad);
        Console.WriteLine(cuenta2.Nombre+" "+cuenta2.Edad);
        //Asi es como se llama a una clase anonima

        cuenta1=cuenta2;
        //Al ser de la misma clase se puede hacer esto.

        Console.WriteLine(cuenta1.Nombre+cuenta1.Edad);
    }
}

class circulo
{
    //Pueden aver mas de un constructor, pero estos tendran que tener parametros diferentes, 
    public circulo(){           //Esto es un constructor, se identifica porque tiene el mismo nombre que la clase
        pi=3.1416;
    }
    private double pi;             //esto es una propieded de la clase 
    
    public double areaCirculo(double radio){      //metodo de clase, lo que puede hacer la clase.
        //tiene un "public" que me permite acceder al metodo desde otra clase, tambien funciona con variables
        return radio * radio * pi;
    }
}

class carro
{
    public carro(){
        ruedas=4;
        asientos=5;
        largo=4.784;
        ancho=1.897;
        color="Blanco";
    }

    public carro(string color){
        ruedas=4;
        asientos=5;
        largo=4.831;
        ancho=1.905;

        //EL "this"sirve para dar a entender que se refiere a la variable de la clase y no la del metodo, muy util en estos casos
        this.color=color;              
    }

    public string getCarro(){         //Se sule usar el "get" a funciones de clases que dan informacion
        return "Información del Coche:\nRuedas:"+ruedas+"\nAsientos:"+asientos+"\nLargo:"+largo+"\nAncho:"+ancho+"\nColor:"+color+"\nClimaizador:"+climatizador+"\nToques de Oro:"+toquesDeoro;
    }

    public void setExtras(bool climatizador, bool toquesDeoro){        //se suele usar el "set" a funciones de clase que definen variables
        this.climatizador=climatizador;
        this.toquesDeoro=toquesDeoro;
    }


    private int ruedas;
    private int asientos;
    private double largo;
    private double ancho;
    private string color;
    private bool toquesDeoro;
    private bool climatizador;
    
}
    
class trianguloPitagoras
{
    public trianguloPitagoras(double a,double b){
        hipotenusa=Math.Sqrt(Math.Pow(a,2)+ Math.Pow(b,2));
    } 

    public void GetHipotenusa(){
        Console.WriteLine(hipotenusa);
    }

    private double hipotenusa;         
}