using System;
using System.Collections.Generic;
using System.Text;

namespace mvc_herencia.Modelo
{
    internal class CEmpleado
    {
        /*Todos los empleados de la empresa, que pueden ser obreros o profesionales, acreditan: legajo (entero sin signo, único e irrepetible), 
            apellidos y nombres. */
        private uint legajo;
        private string apellido;
        private string nombre;

        public CEmpleado(uint legajo, string apellido, string nombre)
        {
            this.legajo = legajo;
            this.apellido = apellido;
            this.nombre = nombre;
        }

        public uint Legajo
        {
            get { return this.legajo; }
        }
        public string Apellido
        {
            get { return this.apellido; }
        }
        public string Nombre
        {
            get { return this.nombre; }
        }
    }
}
