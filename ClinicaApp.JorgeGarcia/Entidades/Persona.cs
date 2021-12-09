using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        protected int dni;
        protected string nombre;
        protected string apellido;
        protected int edad;

        public Persona(int dni, string nombre, string apellido, int edad)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public abstract int ID { get; set; }

        /// <summary>
        /// Propiedad de lectura/escritura que encapsula la variable nombre.
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (Validador.SoloLetras(value))
                    this.nombre = value;
                else
                    throw new PersonaException("Nombre inválido.");
            }
        }

        /// <summary>
        /// Propiedad de lectura/escritura que encapsula la variable apellido.
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                if (Validador.SoloLetras(value))
                    this.apellido = value;
                else
                    throw new PersonaException("Apellido inválido.");
            }
        }

        /// <summary>
        /// Propiedad de lectura/escritura que encapsula la variable dni.
        /// </summary>
        public int DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                if (Validador.DniValido(value))
                    this.dni = value;
                else
                    throw new PersonaException("DNI inválido.");
            }
        }

        /// <summary>
        /// Propiedad de lectura/escritura que encapsula la variable edad.
        /// </summary>
        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                if (Validador.EdadValida(value))
                    this.edad = value;
                else
                    throw new PersonaException("Edad inválida.");
            }
        }

        /// <summary>
        /// Sobrecarga del operador == que compara el DNI de 2 personas sean iguales.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>true si son iguales, false en caso contrario.</returns>
        public static bool operator ==(Persona p1, Persona p2)
        {
            return p1 is not null && p2 is not null && p1.DNI == p2.DNI;
        }

        /// <summary>
        /// Sobrecarga del operador != que compara que el DNI de 2 personas sea distinto.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>true si son distintos, false si son iguales.</returns>
        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// Se encarga de exporner los datos de una persona en un solo string.
        /// </summary>
        /// <returns>Los datos de la persona.</returns>
        public virtual string Informacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"DNI: {this.DNI}");
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Apellido: {this.Apellido}");
            sb.AppendLine($"Edad: {this.Edad}");

            return sb.ToString();
        }
    }
}
