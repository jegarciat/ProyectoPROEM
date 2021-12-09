using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClinicaUI
{
    public partial class FrmEstadisticas : Form
    {
        public FrmEstadisticas()
        {
            InitializeComponent();
        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            CargarListaOrdenada();
            this.rtxInformacion.Text = CargarEstadisticas();
        }

        /// <summary>
        /// Carga el listBox con los médicos ordenados por cantidad de pacientes atendidos de forma descendente. 
        /// </summary>
        private void CargarListaOrdenada()
        {
            List<Medico> medicosOrdenados = Clinica.Medicos.OrderByDescending(x => x.PacientesAtendidos.Count).ToList();
            string datosMedico;

            foreach (Medico item in medicosOrdenados)
            {
                datosMedico = $"{item} - Pacientes atendidos: {item.PacientesAtendidos.Count} - {item.Especialidad}";

                this.lstMedicosOrdenados.Items.Add(datosMedico);
            }
        }

        /// <summary>
        /// Recopila toda la información necesario para mostrar en el RichTextBox.
        /// </summary>
        /// <returns>Un string con toda la inforamción.</returns>
        private string CargarEstadisticas()
        {
            StringBuilder stringBuilder = new StringBuilder();
            List<Medico> medicosConMenosDemanda = Clinica.MedicosQueMenosPacientesAtendieron();

            stringBuilder.AppendLine($"- Médico con más pacientes atendidos: {Clinica.MedicoConMasPacientesAtendidos()}");
            stringBuilder.AppendLine($"\n- Especialidad con más consultas: {Clinica.EspecialidadConMasConsultas()}");

            stringBuilder.AppendLine($"\n- Médico/s que menos pacientes atendieron: \n");

            if (Clinica.Medicos.TrueForAll((x) => x.PacientesAtendidos.Count == 0))
            {
                stringBuilder.AppendLine($"No hay pacientes atendidos para comparar");
            }
            else
            {
                medicosConMenosDemanda.ForEach((item) =>
                {
                    stringBuilder.AppendLine($"{item} - Pacientes atendidos: {item.PacientesAtendidos.Count}");
                });
            }

            return stringBuilder.ToString();
        }
    }
}
