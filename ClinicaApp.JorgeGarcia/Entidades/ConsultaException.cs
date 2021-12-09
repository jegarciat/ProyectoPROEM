using System;

namespace Entidades
{
    /// <summary>
    /// Excepcion personalizada usada para controlar la asignación y finalización de las consultas.
    /// </summary>
    public class ConsultaException : Exception
    {
        public ConsultaException(string mensaje) : base(mensaje)
        {

        }
    }
}
