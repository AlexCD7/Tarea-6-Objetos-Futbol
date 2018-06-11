using System;
//HERENCIA
public class Arbitro:Persona
    {
         
            public string posicion;
            //CONSTRUCTOR
            public Arbitro(string nombre ,string apellido ,string posicion,int edad){
                this.nombre=nombre;
                this.apellido=apellido;
                this.posicion=posicion;
                this.edad=edad;
    }
    
            
            public void CumplirReglas()
            {
               Console.WriteLine("El árbitro cumplio con las reglas");
                //TODO = Por hacer
            }
    }