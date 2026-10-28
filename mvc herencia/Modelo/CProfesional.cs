using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace mvc_herencia.Modelo
{
    public enum Profesion { Arquitecto, Ingeniero, Tecnico_Constructor, Maestro_Mayor_De_Obra }

    internal class CProfesional : CEmpleado
    {
        /*Los profesionales, por su parte, son los responsables por la supervisión de una o más de una obra y acreditan, además, como datos propios: 
            el título habilitante (arquitecto, ingeniero, técnico constructor, maestro mayor de obra, etc.), su número de matrícula (entero largo sin signo)
            y el nombre del consejo profesional que la emite (Ejemplo: “Colegio de Arquitectos de la Provincia de Buenos Aires”). 

Los profesionales perciben un haber mensual que surge de aplicarle al monto de referencia (sueldo mensual de un obrero con categoría de oficial), 
            un porcentaje propio y particular de aumento (negociado entre ese profesional y la empresa), al que se agregará, luego, un monto fijo 
            (de idéntico valor para todos los profesionales), en carácter de canon universal para el pago de su matrícula, 
            sólo si se encuentra supervisando, al menos, una obra. */

        // Atributos
        private Profesion profesion;
        private ulong numMatricula;
        private string nombreConsejo;
        private float haberMensual;

        // Propiedades
        public Profesion Profesion
        {
            get { return this.profesion; }
        }
        public ulong NumMatricula
        {
            get { return this.numMatricula; }
        }
        public string NombreConsejo
        {
            get { return this.nombreConsejo; }
        }
        public float HaberMensual
        {
            get { return this.haberMensual; }
        }

        public CProfesional(Profesion profesion, ulong numMatricula, string nombreConsejo, float haberMensual, uint legajo, string apellido, string nombre) 
            : base(legajo, apellido, nombre)
        {
            this.profesion = profesion;
            this.numMatricula = numMatricula;
            this.nombreConsejo = nombreConsejo;
        }
    }
}
