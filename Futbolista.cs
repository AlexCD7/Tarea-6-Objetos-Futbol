using System;
//HERENCUA
public class Futbolista:Persona
    {
         
            public string posicion;
            

              //CONSTRUCTOR
            public Futbolista(string nombre ,string apellido ,string posicion,int edad)
            {
                this.nombre=nombre;
                this.apellido=apellido;
                this.posicion=posicion;
                this.edad=edad;
            }
            
            public void Jugar()
            {
               Console.WriteLine("El futbolista terminó el juego ");
                //TODO = Por hacer
            }
    }