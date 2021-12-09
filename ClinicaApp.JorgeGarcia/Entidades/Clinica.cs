using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Entidades
{
    public static class Clinica
    {
        private static List<Medico> medicos;
        private static Queue<Paciente> pacientesEnEspera;
        private static List<Consulta> consultas;
        private static string ruta;

        static Clinica()
        {
            ruta = AppDomain.CurrentDomain.BaseDirectory;
            consultas = new List<Consulta>();
            medicos = new List<Medico>();
            pacientesEnEspera = new Queue<Paciente>();
        }

        public static List<Medico> Medicos
        {
            get
            {
                return medicos;
            }
            set
            {
                if (value is not null)
                    medicos = value;
            }
        }

        public static List<Consulta> Consultas
        {
            get
            {
                return consultas;
            }
            set
            {
                if (value is not null)
                    consultas = value;
            }
        }
        public static Queue<Paciente> PacientesEnEspera
        {
            get
            {
                return pacientesEnEspera;
            }
            set
            {
                if (value is not null)
                    pacientesEnEspera = value;
            }
        }

        /// <summary>
        /// Se encarga de importar los médicos harcodeados del archivo Medicos.xml.
        /// </summary>
        /// <returns>La lista de médicos o un ArchivoException en caso de error al importar.</returns>
        public static List<Medico> CargarMedicos()
        {
            string rutaMedicos = ruta + "Medicos.xml";

            try
            {
                List<Medico> medicos = new List<Medico>();

                using (StreamReader lector = new StreamReader(rutaMedicos))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Medico>));
                    medicos = (List<Medico>)serializer.Deserialize(lector);
                }

                return medicos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Se encarga de importar los pacientes harcodeados del archivo Pacientes.xml
        /// </summary>
        /// <returns>La cola de pacientes o un ArchivoException en caso de error al importar.</returns>
        public static Queue<Paciente> CargarPacientes()
        {
            string rutaPacientes = ruta + "Pacientes.xml";

            try
            {
                Queue<Paciente> colaDePacientes = new Queue<Paciente>();
                List<Paciente> pacientes = new List<Paciente>();

                using (StreamReader lector = new StreamReader(rutaPacientes))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Paciente>));
                    pacientes = (List<Paciente>)serializer.Deserialize(lector);
                }

                pacientes.ForEach((item) => colaDePacientes.Enqueue(item));

                return colaDePacientes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Se encarga de buscar el médico con más pacientes atendidos enla clínica.
        /// </summary>
        /// <returns>El nombre y apellido del médico, o si no hay consultas un mensaje.</returns>
        public static string MedicoConMasPacientesAtendidos()
        {
            if (Consultas.Count > 0)
            {
                List<Medico> medicosOrdenados = Medicos.OrderByDescending(x => x.PacientesAtendidos.Count).ToList();
                return medicosOrdenados[0].ToString();
            }

            return "No hay consultas para comparar";
        }

        /// <summary>
        /// Se encarga de buscar la especialidad con más consultas.
        /// </summary>
        /// <returns>La especialidad con más consultas o un mensaje si no hay consultas.</returns>
        public static string EspecialidadConMasConsultas()
        {
            Dictionary<EEspecialidad, int> conteo = new Dictionary<EEspecialidad, int>();

            if (Consultas.Count > 0)
            {
                Consultas.ForEach(x =>
                {
                    if (conteo.ContainsKey(x.Especialidad))
                    {
                        conteo[x.Especialidad] += 1;
                    }
                    else
                    {
                        conteo.Add(x.Especialidad, 1);
                    }
                });

                EEspecialidad especialidad = conteo.OrderByDescending(x => x.Value).First().Key;

                string especialidadMax = especialidad.ToString();

                return especialidadMax;
            }

            return "No hay consultas para comparar";
        }

        /// <summary>
        /// Se encarga de buscar los médicos con menos pacientes atendidos.
        /// </summary>
        /// <returns>Lista de médicos que menos atendieron.</returns>
        public static List<Medico> MedicosQueMenosPacientesAtendieron()
        {
            List<Medico> medicosOrdenados = Medicos.OrderBy(x => x.PacientesAtendidos.Count).ToList();
            List<Medico> medicosConMenosPacientes = new List<Medico>();
            bool flag = true;

            medicosOrdenados.ForEach((x) =>
            {
                if (flag)
                {
                    medicosConMenosPacientes.Add(x);
                    flag = false;
                }
                else if(x.PacientesAtendidos.Count == medicosConMenosPacientes[0].PacientesAtendidos.Count)
                {
                    medicosConMenosPacientes.Add(x);
                }
            });

            return medicosConMenosPacientes;
        }
    }
}
