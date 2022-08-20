using Clase16.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16.Repositorio
{
    public class RepositorioDePersonas
    {
        public List<Persona> Personas { get; set; }

        public RepositorioDePersonas()
        {
            Personas = new List<Persona>();
        }

        public void Insertar(Persona persona)
        {
            Personas.Add(persona);
        }

        public void Eliminar(string dni)
        {
            //Definir como eliminar una persona de la lista de Personas.
        }

        public void Actualizar(Persona persona)
        {
            Persona personaEncontrada;
            foreach(Persona personaActual in Personas)
            {
                if(personaActual.NumeroDeDocumento == persona.NumeroDeDocumento)
                {
                    personaActual.Nombre = persona.Nombre;
                    personaActual.Apellido = persona.Apellido;
                    personaActual.FechaNacimiento = persona.FechaNacimiento;
                }
            }
        }
    }
}
