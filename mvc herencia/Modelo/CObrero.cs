using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace mvc_herencia.Modelo
{
    public enum Oficio { Albañil, Pintor, Plomero, Yesero, Electricista }
    public enum Categoria { Oficial, Medio_oficial, Aprendiz }


    internal class CObrero : CEmpleado
    {
        /*Los obreros, que podrán ser de oficio albañil, pintor, plomero, yesero, electricista, etc., según su experiencia y dominio, se categorizan en 
            oficiales, medio-oficiales y aprendices. 

El haber mensual de los obreros, se calcula en base a un monto de referencia definido por el sindicato, que se cobra al 100% en el caso de los 
            oficiales, al 65% en los medio-oficiales, y al 25% en los aprendices. */

        // Atributos
        private Oficio oficio;
        private Categoria categoria;
        private float haberMensual;

        // Propiedades
        public Oficio Oficio
        {
            get { return this.oficio; }
        }
        public Categoria Categoria
        {
            get { return this.categoria; }
        }
        public float HaberMensual
        {
            get { return this.haberMensual; }
        }

        // Constructor
        public CObrero(Oficio oficio, Categoria categoria, float haberMensual, uint legajo, string apellido, string nombre) 
            : base(legajo, apellido, nombre)
        {
            this.oficio = oficio;
            this.categoria = categoria;
            this.haberMensual = haberMensual;
        }
    }
}
