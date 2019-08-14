using System;
using System.Collections.Generic;

namespace ProyectosSenova
{
    class Program
    {
        static void Main(string[] args)
        {
            //int edad;
            //int puntaje = 0;
         




            //Proyecto miProyecto2 = new Proyecto();
            Proyecto miProyecto3 = new Proyecto();
            miProyecto3.IngresarProyecto();

            Console.WriteLine("dijite !!!");
            var x = int.Parse(Console.ReadLine());
            miProyecto3.DetenerMayores(x);
            List<Proyecto> proyectos = new List<Proyecto>();
            //Proyecto miProyecto4 = new Proyecto("Realidad aumentada",12540,"sistemas",10);
            //Proyecto miProyecto5 = new Proyecto("Talento Humano", 5);

            // miProyecto3.IngresarProyecto();
            // miProyecto3.ImprimirProyecto();
            //miProyecto4.ImprimirProyecto();
            //miProyecto5.ImprimirProyecto();



            //miProyecto.Area = "Sistemas";
            //miProyecto.Codigo = 12000;
            //miProyecto.Duracion = 13;
            //miProyecto.Nombre = "Desarrollo internet  de las cosas IOT";

            //Console.WriteLine($"Area: {miProyecto.Area}");
            //Console.WriteLine($"Codigo:{miProyecto.Codigo}");
            //Console.WriteLine($"Duracion:{miProyecto.Duracion}");
            //Console.WriteLine($"Nombre:{miProyecto.Nombre}");

            //miProyecto2.Area = "Redes";
            //miProyecto2.Codigo = 13000;
            //miProyecto2.Duracion = 14;
            //miProyecto2.Nombre = "Desarrollo Arduino";

            //Console.WriteLine($"Area: {miProyecto.Area}");
            //Console.WriteLine($"Codigo:{miProyecto.Codigo}");
            //Console.WriteLine($"Duracion:{miProyecto.Duracion}");
            //Console.WriteLine($"Nombre:{miProyecto.Nombre}");
            Console.ReadLine();
    



        }

    }
}
//obrener todos los proyectos cuya codigo sea igaul a 20 y sea par 
//ordenar los proyectos ascendentemente por duracion 
    // selecionar el primer proyecto que sea multipo de 6
    //listar y mostrar las areas de los proyectos 
    //mostrar nombre y codigo los proyectos 
    // sumar la duracion de todos los proyectos 
    //agrupar los proyectos por areas 