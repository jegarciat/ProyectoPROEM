using Entidades;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ClinicaUI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga las listas de la clínica y configura los controles del formulario.
        /// Muestra una excepción si no se pudieron importar los datos de los archivos xml.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                Clinica.Medicos = Clinica.CargarMedicos();
                Clinica.PacientesEnEspera = Clinica.CargarPacientes();
                dgvClinica.DataSource = Clinica.Medicos;
                this.btnFinalizarConsulta.Enabled = false;
                this.btnFinalizarTodas.Enabled = false;
                this.lblTitulo.Text = "Lista de médicos";
                this.lblConteoPacientes.Text = $"Pacientes en espera: {Clinica.PacientesEnEspera.Count}";
                this.lblTurno.Text = $"Próximo turno: {Clinica.PacientesEnEspera.Peek().ID}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Carga el dataGridView con todos los médicos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMedicos_Click(object sender, EventArgs e)
        {
            dgvClinica.DataSource = null;
            dgvClinica.DataSource = Clinica.Medicos;
            this.btnFinalizarConsulta.Enabled = false;
            this.btnFinalizarTodas.Enabled = false;
            this.lblTitulo.Text = this.btnMedicos.Text;
        }

        /// <summary>
        /// Carga el dataGridView con todos los médicos que están atendiendo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMedicosAtendiendo_Click(object sender, EventArgs e)
        {
            dgvClinica.DataSource = null;
            dgvClinica.DataSource = Clinica.Medicos.FindAll((x) => x.Atendiendo == true);
            this.btnFinalizarConsulta.Enabled = false;
            this.btnFinalizarTodas.Enabled = false;
            this.lblTitulo.Text = this.btnMedicosAtendiendo.Text;
        }

        /// <summary>
        /// Carga el dataGridView con todos los médicos que no están atendiendo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMedicosLibres_Click(object sender, EventArgs e)
        {
            dgvClinica.DataSource = null;
            dgvClinica.DataSource = Clinica.Medicos.FindAll((x) => x.Atendiendo == false);
            this.btnFinalizarConsulta.Enabled = false;
            this.btnFinalizarTodas.Enabled = false;
            this.lblTitulo.Text = this.btnMedicosLibres.Text;
        }

        /// <summary>
        /// Carga el dataGridView con todos los pacientes en la lista de espera general.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPacientesEnEspera_Click(object sender, EventArgs e)
        {
            dgvClinica.DataSource = null;
            dgvClinica.DataSource = Clinica.PacientesEnEspera.ToList();
            this.btnFinalizarConsulta.Enabled = false;
            this.btnFinalizarTodas.Enabled = false;
            this.lblTitulo.Text = this.btnPacientesEnEspera.Text;
        }

        /// <summary>
        /// Carga el dataGridView con todas las consultas activas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultasActivas_Click(object sender, EventArgs e)
        {
            RefrescarLista(true);
            this.lblTitulo.Text = this.btnConsultasActivas.Text;
        }

        /// <summary>
        /// Carga el dataGridView con todas las consultas finalizadas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultasFinalizadas_Click(object sender, EventArgs e)
        {
            RefrescarLista(false);
            this.lblTitulo.Text = this.btnConsultasFinalizadas.Text;
        }

        /// <summary>
        /// Abre el formulario para asignar una consulta al primer paciente en la lista de espera.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsignarConsulta_Click(object sender, EventArgs e)
        {
            Paciente proximoPaciente = Clinica.PacientesEnEspera.Dequeue();
            FrmConsulta frmConsulta = new FrmConsulta(proximoPaciente);

            MessageBox.Show(proximoPaciente.Informacion(), "Próximo paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (frmConsulta.ShowDialog() == DialogResult.OK)
            {
                RefrescarLista(true);
            }
            else
            {
                dgvClinica.DataSource = Clinica.PacientesEnEspera.ToList();
                this.lblConteoPacientes.Text = $"Pacientes en espera: {Clinica.PacientesEnEspera.Count}";
                this.lblTurno.Text = $"Próximo turno: {Clinica.PacientesEnEspera.Peek().ID}";
            }
        }

        /// <summary>
        /// Finaliza la consulta seleccionada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinalizarConsulta_Click(object sender, EventArgs e)
        {
            if (dgvClinica.SelectedRows.Count == 1)
            {
                Consulta consulta = (Consulta)dgvClinica.CurrentRow.DataBoundItem;

                try
                {
                    consulta.FinalizarConsulta();
                    RefrescarLista(true);
                    MessageBox.Show($"Consulta {consulta.ID_Consulta} finalizada.", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (ConsultaException ex)
                {
                    MessageBox.Show(ex.Message, "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Abre un formulario con las estadísticas de la clínica.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            FrmEstadisticas frmEstadisticas = new FrmEstadisticas();

            frmEstadisticas.Show();
        }

        /// <summary>
        /// Refresca el dataGridView para mostrar las consultas activas o inactivas dependiendo del parámetro.
        /// </summary>
        /// <param name="estadoConsulta"></param>
        private void RefrescarLista(bool estadoConsulta)
        {
            dgvClinica.DataSource = null;
            dgvClinica.DataSource = Clinica.Consultas.FindAll((x) => x.Activa == estadoConsulta);
            this.btnFinalizarConsulta.Enabled = true;
            this.btnFinalizarTodas.Enabled = true;
            this.lblConteoPacientes.Text = $"Pacientes en espera: {Clinica.PacientesEnEspera.Count}";
            this.lblTurno.Text = $"Próximo turno: {Clinica.PacientesEnEspera.Peek().ID}";

            if(estadoConsulta)
                this.lblTitulo.Text = this.btnConsultasActivas.Text;
            else
                this.lblTitulo.Text = this.btnConsultasFinalizadas.Text;
        }

        /// <summary>
        /// Abre un formulario para ingresar un paciente a la lista de espera.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresarPaciente_Click(object sender, EventArgs e)
        {
            FrmAltaPaciente altaPaciente = new FrmAltaPaciente();

            if (altaPaciente.ShowDialog() == DialogResult.OK)
            {
                dgvClinica.DataSource = null;
                dgvClinica.DataSource = Clinica.PacientesEnEspera.ToList();
                this.lblTitulo.Text = this.btnPacientesEnEspera.Text;
                this.lblConteoPacientes.Text = $"Pacientes en espera: {Clinica.PacientesEnEspera.Count}";
                this.lblTurno.Text = $"Próximo turno: {Clinica.PacientesEnEspera.Peek().ID}";
            }
        }

        /// <summary>
        /// Finaliza todas las consultas a la vista.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinalizarTodas_Click(object sender, EventArgs e)
        {
            if (dgvClinica.Rows.Count > 0)
            {
                Consulta consulta;

                try
                {
                    for (int i = 0; i < dgvClinica.Rows.Count; i++)
                    {
                        consulta = (Consulta)dgvClinica.Rows[i].DataBoundItem;
                        consulta.FinalizarConsulta();
                    }

                    RefrescarLista(true);

                    MessageBox.Show($"Consultas finalizadas", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (ConsultaException ex)
                {
                    MessageBox.Show(ex.Message, "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
