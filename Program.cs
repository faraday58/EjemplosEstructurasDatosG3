using System;
using Estructuras;
using System.Collections.Generic;
namespace EjemplosEstructurasDatos
{
    class Program
    {
        static void Main()
        {
            Empleado empleado;
            empleado.nombre = "Jorge Armando Rodríguez Vera";
            empleado.edad = 50;
            empleado.antiguedad = 15;
            empleado.direccion.calle = "Las américas";
            empleado.direccion.codigoPostal = "099000";
            
            Console.WriteLine("Ingresa los datos que se a continuación");
            List<Empleado> empleados = new List<Empleado>();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Ingresa el nombre del Empleado");
                empleado.nombre= Console.ReadLine();
                Console.WriteLine("Ingresa la edad del empleado");
                empleado.edad = byte.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la antigüedad del empleado");
                empleado.antiguedad = byte.Parse(Console.ReadLine());
                empleados.Add(empleado);
            }



            /*
                        Empleado[]  empleados= new Empleado[2];
                        for(int i=0; i <2;i++   )
                        {
                            Console.WriteLine("Ingresa el nombre del Empleado");
                            empleados[i].nombre = Console.ReadLine();
                            Console.WriteLine("Ingresa la edad del empleado");
                            empleados[i].edad = byte.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresa la antigüedad del empleado");
                            empleados[i].antiguedad = byte.Parse(Console.ReadLine());
                        }
              */
            /*
                        Console.WriteLine("Datos del Empleado: ");
                        Console.WriteLine("Nombre: {0}:", empleado1.nombre);
                        Console.WriteLine("Edad: {0} años", empleado1.edad);
                        Console.WriteLine("Antigüedad: {0} años de labor", empleado1.antiguedad);
                        Console.ReadLine();
            */
            /*
                        Console.WriteLine("Datos del Empleado: ");
                        Console.WriteLine("Nombre: {0}:", empleados[0].nombre);
                        Console.WriteLine("Edad: {0} años", empleados[0].edad);
                        Console.WriteLine("Antigüedad: {0} años de labor", empleados[0].antiguedad);
                        Console.ReadLine();
            */
/*
            foreach (Empleado empleado1 in empleados  )
            {
                Console.WriteLine("Datos del Empleado: ");
                Console.WriteLine("Nombre: {0}:", empleado1.nombre);
                Console.WriteLine("Edad: {0} años", empleado1.edad);
                Console.WriteLine("Antigüedad: {0} años de labor", empleado1.antiguedad);
                Console.ReadLine();
            }

*/

            for(int i=0;i < empleados.Count;i++)
            {
                Console.WriteLine("Datos del Empleado: ");
                Console.WriteLine("Nombre: {0}:", empleados[0].nombre);
                Console.WriteLine("Edad: {0} años", empleados[0].edad);
                Console.WriteLine("Antigüedad: {0} años de labor", empleados[0].antiguedad);
                Console.ReadLine();
            }



        }
    }
}
