using System;

namespace Entidades
{
    /// <summary>
    /// Excepcion personalizada usada para controlar la búsqueda de médicos al intentar asignar una consulta.
    /// </summary>
    public class BuscarException : Exception
    {
        public BuscarException(string mensaje) : base(mensaje)
        {

        }
    }
}
