using System;

namespace Entidades
{
    /// <summary>
    /// Excepcion personalizada para controlar el ingreso de los datos de una persona.
    /// </summary>
    public class PersonaException : Exception
    {
        public PersonaException(string mensaje) : base(mensaje)
        {

        }
    }
}
