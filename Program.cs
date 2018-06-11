using System;


namespace myFutbol
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            //INSTANCIA
            Console.WriteLine("Clase MyFutbol");
            Console.Write("1º) Jugador del partido" + "\n" + "2º) Árbitro del partido" + "\n" + "3º) Estadio" + "\n");
            Console.Write("Seleccione una opción: ");
            
            switch (Console.Read())
            
            {
                
                case '1': 
                    Console.Clear();
                     var jugador =new Futbolista("Leonel","Messi","Delantero",29);
                    Console.WriteLine("Nombres:  " +jugador.nombre +" "+ jugador.apellido+
                    "\nEdad: "+ jugador.edad + "\nPosicion: "+jugador.posicion  );
                    jugador.Jugar();
                    break;

                case '2': 
                    Console.Clear();
                    var juez =new Arbitro("Omar","Ponce","Central",35);
                    Console.WriteLine("El arbitro es:  " +juez.nombre +" "+ juez.apellido+
                    "\nEdad: "+ juez.edad + "\nPosicion del árbitro: "+juez.posicion);
                    juez.CumplirReglas();
                    break;
                case '3':
                    Console.Clear();
                    var estadio  = new Cancha("Camp Nou","España","Barcelona");
                    Console.WriteLine("Nombre del estadio: " +estadio.nombre +" \nPais: "+ estadio.pais+
                    "\nCiudad: "+ estadio.ciudad );
                    break;
               
            } 
               
                Console.ReadLine();
            
        }
    }
}
