using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Ingresante : Alumno
    {
        //atributos
        private string colegio;
        private string puesto;

        //propiedades
        public string Colegio { get => colegio; set => colegio = value; }
        public string Puesto { get => puesto; set => puesto = value; }

        //métodos
        public string Adaptar()
        {
            return "El metodo Adaptar no ha sido implementado";
        }

        public string Mantener()
        {
            return "El metodo Mantener no ha sido implementado";
        }

        



    }
}