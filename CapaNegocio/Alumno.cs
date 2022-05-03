using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Alumno : Persona
    {
        //atributos
        private string seguro;
        private string escuela;

        //propiedades
        public string Seguro { get => seguro; set => seguro = value; }
        public string Escuela { get => escuela; set => escuela = value; }

        //metodos
        public string Estudiar()
        {
            return "El metodo Estudiar no ha sido implementado";
        }
        public string Trabajar()
        {
            return "El metodo Trabajar no ha sido implementado";
        }
    }
}
