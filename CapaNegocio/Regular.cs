using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Regular : Alumno
    {
        private string ciclo;
        private string convalidaciones;
        private string creditos;

        public string Ciclo { get => ciclo; set => ciclo = value; }
        public string Convalidaciones { get => convalidaciones; set => convalidaciones = value; }
        public string Creditos { get => creditos; set => creditos = value; }

        public string Mejorar()
        {
            return "El metodo Mejorar no ha sido implementado";
        }

        public string Ponderar()
        {
            return "El metodo Ponderar no ha sido implementado";
        }
    }
}