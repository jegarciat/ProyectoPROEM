using System.Text;

namespace Entidades
{
    public enum EObraSocial
    {
        NoTiene,
        CoberturaBasica,
        CoberturaCompleta
    }

    public class Paciente : Persona
    {
        private static int ultimoID;
        private int idPaciente;
        private EObraSocial obraSocial;

        static Paciente()
        {
            ultimoID = 0;
        }

        /// <summary>
        /// Constructor necesario para deserializar los paciente hardcodeados del archivo Pacientes.xml
        /// </summary>
        public Paciente() : this(0, "Predeterminado", "Predeterminado", 0, EObraSocial.NoTiene)
        {
        }

        public Paciente(int dni, string nombre, string apellido, int edad, EObraSocial obraSocial) : base(dni, nombre, apellido, edad)
        {
            ultimoID++;
            this.idPaciente = ultimoID;
            this.obraSocial = obraSocial;
        }

        public Paciente(int dni, string nombre, string apellido, int edad) : this(dni, nombre, apellido, edad, EObraSocial.NoTiene)
        {
        }

        /// <summary>
        /// Propiedad de lectura/escritura que encapsula la variable ID.
        /// </summary>
        public override int ID
        {
            get
            {
                return this.idPaciente;
            }
            set
            {
                if(value > 0 && value > ultimoID)
                    this.idPaciente = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura/escritura que encapsula la variable obraSocial.
        /// </summary>
        public EObraSocial ObraSocial
        {
            get
            {
                return this.obraSocial;
            }
            set
            {
                this.obraSocial = value;
            }
        }

        /// <summary>
        /// Se encarga de exponer todos los datos de un paciente en un string.
        /// </summary>
        /// <returns>Los datos del paciente</returns>
        public override string Informacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Paciente: {this.ID}\n");
            sb.AppendLine(base.Informacion());
            sb.AppendLine($"Obra social: {this.obraSocial}");

            return sb.ToString();
        }

        /// <summary>
        /// Expone el nombre y apellido del paciente.
        /// </summary>
        /// <returns>El nombre y apellido del paciente</returns>
        public override string ToString()
        {
            return $"{this.Nombre} {this.Apellido}";
        }
    }
}
