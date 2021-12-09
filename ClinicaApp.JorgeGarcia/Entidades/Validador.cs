using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validador
    {
        /// <summary>
        /// Verifica que el string este compuesto por solo letras.
        /// </summary>
        /// <param name="texto"></param>
        /// <returns>true si es solo letras, o una exception del tipo PersonaException en caso contrario.</returns>
        public static bool SoloLetras(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                throw new PersonaException("Nombre o apellido inválido.");
            }

            foreach (char caracter in texto.ToCharArray())
            {
                if (char.IsDigit(caracter))
                    throw new PersonaException("Nombre o apellido inválido.");
            }

            return true;
        }

        /// <summary>
        /// Verifica que el DNI de tipo string sea válido.
        /// </summary>
        /// <param name="dni"></param>
        /// <returns>true si es un DNI válido, o una exception del tipo PersonaException en caso contrario.</returns>
        public static bool DniValido(string dni)
        {
            if (!string.IsNullOrWhiteSpace(dni) && int.TryParse(dni, out int auxDNI))
                return DniValido(auxDNI);

            return false;
        }

        /// <summary>
        /// Verifica que el DNI de tipo int sea válido.
        /// </summary>
        /// <param name="dni"></param>
        /// <returns>true si es un DNI válido, o una exception del tipo PersonaException en caso contrario.</returns>
        public static bool DniValido(int dni)
        {
            if (dni <= 0 || dni > int.MaxValue)
                throw new PersonaException("DNI inválido.");

            return true;
        }

        /// <summary>
        /// Valida que el parámetro del tipo string sea una edad válida.
        /// </summary>
        /// <param name="edad"></param>
        /// <returns>true si es una edad válida, o una exception del tipo PersonaException en caso contrario.</returns>
        public static bool EdadValida(string edad)
        {
            if (!string.IsNullOrWhiteSpace(edad) && int.TryParse(edad, out int auxEdad))
                return EdadValida(auxEdad);
            else
                throw new PersonaException("Edad inválida.");
        }

        /// <summary>
        /// Valida que el parámetro de tipo int sea una edad válida.
        /// </summary>
        /// <param name="edad"></param>
        /// <returns>true si es una edad válida, o una exception del tipo PersonaException en caso contrario.</returns>
        public static bool EdadValida(int edad)
        {
            if (edad > 0 && edad < 99)
                return true;
            else
                throw new PersonaException("Edad inválida.");

        }
    }
}
