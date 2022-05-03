using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    
    public class Administrativo : Persona, IMantenimiento
    {
        //atributos
        private string experiencia;
        private string turno;
        private string especialidad;

        //propiedades
        public string Experiencia { get => experiencia; set => experiencia = value; }
        public string Turno { get => turno; set => turno = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }

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