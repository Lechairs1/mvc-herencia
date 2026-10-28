using System;
using System.Collections.Generic;
using System.Text;

namespace mvc_herencia
{
    internal class CVista
    {
        private CControladora sistema = new CControladora();

        /*Este sistema, mediante un menú interactivo, en cualquier momento y en cualquier orden, deberá permitir:  

Establecer e informar las variables de sueldos (el monto de referencia definido por el sindicato y el canon universal para el pago de la matrícula 
            profesional) y los datos y haber mensual de todos los empleados registrados en la empresa. 
Registrar un empleado, que puede ser obrero o profesional, con un legajo único y con todos los datos necesarios. 
Listar los datos completos de todos los empleados de la empresa y su haber mensual, ordenados por apellidos (alfabéticamente). 
Registrar una obra con un código único y todos sus datos (profesional designado para su supervisión incluido). 
Modificar el profesional designado como supervisor de una obra. 
Asignar un obrero en una obra (cuidar que no se encuentre asignado en más de una). 
Listar, para un código de obra, los datos completos, de todos los empleados asignados a ella. 
Eliminar un profesional de la empresa (verificar que no se encuentre supervisando ninguna obra).*/
        public void Menu()
        {
            // Menu principal

            byte opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("Menu principal");
                Console.WriteLine("1. Registrar un empleado");
                Console.WriteLine("0. Salir");
                Console.Write("\nIngrese su opcion: ");
                opcion = byte.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        // Registrar un empleado
                        RegistrarEmpleado();
                        break;
                    case 0:
                        // Salir

                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 0);
        }

        public void RegistrarEmpleado()
        {
            /*Registrar un empleado, que puede ser obrero o profesional, con un legajo único y con todos los datos necesarios.*/

            uint legajo;
            string apellido;
            string nombre;

            do
            {
                Console.Clear();
                Console.Write("Ingrese el legajo (0 para salir): ");
                legajo = UInt32.Parse(Console.ReadLine());

                if(legajo != 0)
                {

                }
            } while (legajo != 0);
        }
    }
}
