using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public enum EEspecialidad
    {
        Odontologia,
        Cardiologia,
        Dermatología,
        Ginecología,
        Oftalmología,
        Urología,
        Pediatría,
        Fisioterapia,
        Psiquiatría
    }

    public class Medico : Persona
    {
        private static int ultimoID;
        private int idMedico;
        private bool atendiendo;
        private List<Paciente> pacientesAtendidos;
        private Queue<Paciente> pacientesEnEspera;
        private EEspecialidad especialidad;

        static Medico()
        {
            ultimoID = 0;
        }

        /// <summary>
        /// Constructor necesario para deserializar los médicos harcodeados del archivo Medicos.xml
        /// </summary>
        public Medico() : this(0, "Predeterminado", "Predeterminado", 0, EEspecialidad.Odontologia)
        {
        }

        public Medico(int dni, string nombre, string apellido, int edad, EEspecialidad especialidad) : base(dni, nombre, apellido, edad)
        {
            ultimoID++;
            this.idMedico = ultimoID;
            this.especialidad = especialidad;
            this.pacientesAtendidos = new List<Paciente>();
            this.pacientesEnEspera = new Queue<Paciente>();
        }

        /// <summary>
        /// Propiedad de lectura/escritura que encapsula la variable ID.
        /// </summary>
        public override int ID
        {
            get
            {
                return this.idMedico;
            }
            set
            {
                if (value > 0 && value > ultimoID)
                    this.idMedico = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura/escritura que encapsula la variable especialidad.
        /// </summary>
        public EEspecialidad Especialidad
        {
            get
            {
                return this.especialidad;
            }
            set
            {
                this.especialidad = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura/escritura que encapsula la variable atendiendo.
        /// </summary>
        public bool Atendiendo
        {
            get
            {
                return this.atendiendo;
            }
            set
            {
                this.atendiendo = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura que encapsula la variable pacientesAtendidos.
        /// </summary>
        public List<Paciente> PacientesAtendidos
        {
            get
            {
                return this.pacientesAtendidos;
            }
        }

        /// <summary>
        /// Propiedad de lecturaque encapsula la variable pacientesEnEspera.
        /// </summary>
        internal Queue<Paciente> PacientesEnEspera
        {
            get
            {
                return this.pacientesEnEspera;
            }
        }

        /// <summary>
        /// Expone todos los datos de un médicos en un string.
        /// </summary>
        /// <returns>Loa datos del médico.</returns>
        public override string Informacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"ID Médico: {this.ID}\n");
            sb.AppendLine(base.Informacion());
            sb.AppendLine($"Especialidad: {this.Especialidad}");

            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga del operador '+' que se encarga de asignar una consulta si el médico no está atendiendo  
        /// o agrega el paciente a la lista de espera si el médico no está disponible.
        /// </summary>
        /// <param name="medico">Médico encargado de la consulta.</param>
        /// <param name="paciente">Paciente que será atendido.</param>
        /// <returns>true si se asigno la consulta, false si se agrego el paciente a la lista de espera.</returns>
        public static bool operator +(Medico medico, Paciente paciente)
        {
            if (!medico.Atendiendo)
            {
                Consulta consulta = new Consulta(medico, paciente);
                Clinica.Consultas.Add(consulta);

                return true;
            }
            else
            {
                medico.pacientesEnEspera.Enqueue(paciente);
                return false;
            }
        }

        /// <summary>
        /// Expone el nombre y apellido del médico.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this.Nombre} {this.Apellido}";
        }
    }
}
