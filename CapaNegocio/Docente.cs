using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Docente : Persona, IMantenimiento
    {
        //atributos
        private string gradoAcademico;
        private string afp;
        private string capacitaciones;

        //propiedades
        public string GradoAcademico { get => gradoAcademico; set => gradoAcademico = value; }
        public string Afp { get => afp; set => afp = value; }
        public string Capacitaciones { get => capacitaciones; set => capacitaciones = value; }

        //metodos
        public bool Actualizar()
        {
            throw new NotImplementedException();
        }

        public bool Agregar()
        {
            throw new NotImplementedException();
        }

        public string Buscar()
        {
            throw new NotImplementedException();
        }

        public bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public string Listar()
        {
            throw new NotImplementedException();
        }
    }
}