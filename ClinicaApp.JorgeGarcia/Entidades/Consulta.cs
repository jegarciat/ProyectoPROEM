using System;

namespace Entidades
{
    public enum EResultado
    {
        Atendiendo,
        Internacion,
        Cirugia,
        Tratamiento,
        Derivacion,
        Realizar_estudios,
    }

    public class Consulta
    {
        private static int ultimoID;
        private int idConsulta;
        private Medico medico;
        private Paciente paciente;
        private bool consultaActiva;
        private EResultado resultado;

        static Consulta()
        {
            ultimoID = 0;
        }

        public Consulta(Medico medico, Paciente paciente)
        {
            ultimoID++;
            this.idConsulta = ultimoID;
            this.medico = medico;
            this.paciente = paciente;
            this.resultado = EResultado.Atendiendo;
            this.consultaActiva = true;
            this.medico.Atendiendo = true;
            this.medico.PacientesAtendidos.Add(paciente);
        }

        /// <summary>
        /// Propiedad de lectura que encapsula la variable idConsulta.
        /// </summary>
        public int ID_Consulta
        {
            get
            {
                return this.idConsulta;
            }
        }

        /// <summary>
        /// Propiedad de lectura que encapsula la variable medico.
        /// </summary>
        public string Medico
        {
            get
            {
                return this.medico.ToString();
            }
        }

        /// <summary>
        /// Propiedad de lectura que encapsula la variable paciente.
        /// </summary>
        public string Paciente
        {
            get
            {
                return this.paciente.ToString();
            }
        }

        /// <summary>
        /// Propiedad de lectura que retorna la especialidad del médico de la consulta.
        /// </summary>
        public EEspecialidad Especialidad
        {
            get
            {
                return this.medico.Especialidad;
            }
        }

        /// <summary>
        /// Propiedad de lectura/escritura que encapsula la variable resultado.
        /// </summary>
        public EResultado Resultado
        {
            get
            {
                return this.resultado;
            }
            set
            {
                this.resultado = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura/escritura que encapsula la variable consultaActiva.
        /// En la escritura se lanza una excepcion si se intenta finalizar una consulta
        /// que ya esta finalizada.
        /// </summary>
        public bool Activa
        {
            get
            {
                return this.consultaActiva;
            }
            set
            {
                if (value == false && this.consultaActiva)
                    this.consultaActiva = value;
                else if (value == false && !this.consultaActiva)
                    throw new ConsultaException("Esta consulta ya está finalizada.");
            }
        }

        /// <summary>
        /// Se encarga de finalizar una consulta y cambiar el estado del médico. Si el médico tiene lista de espera
        /// se asigna una nueva consulta con el proximo paciente.
        /// </summary>
        /// <returns>true si se pudo finalizar la consulta con exito, o una ConsultaExcepcion si ocurrio un error.</returns>
        public bool FinalizarConsulta()
        {
            try
            {
                this.Activa = false;
                this.AsignarResultado();

                if (this.medico.PacientesEnEspera.Count > 0)
                {
                    Consulta nuevaConsulta = (Consulta)this.medico;
                    Clinica.Consultas.Add(nuevaConsulta);
                }
                else
                {
                    this.medico.Atendiendo = false;
                }

                return true;
            }
            catch (ConsultaException ex)
            {
                throw new ConsultaException(ex.Message);
            }
        }

        /// <summary>
        /// Se encarga de asignar un resultado aleatorio a la consulta.
        /// </summary>
        private void AsignarResultado()
        {
            Random random = new Random();
            this.Resultado = (EResultado)random.Next(1, 6);
        }

        /// <summary>
        /// Conversor explicito que instancia una nueva consulta con el próximo paciente de la lista de espera del médico.
        /// </summary>
        /// <param name="medico"></param>
        public static explicit operator Consulta(Medico medico)
        {
            return new Consulta(medico, medico.PacientesEnEspera.Dequeue());
        }
    }
}
