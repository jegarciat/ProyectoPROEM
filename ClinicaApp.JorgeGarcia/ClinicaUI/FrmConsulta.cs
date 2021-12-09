using Entidades;
using System;
using System.Windows.Forms;

namespace ClinicaUI
{
    public partial class FrmConsulta : Form
    {
        private Paciente paciente;

        public FrmConsulta()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructror que recibe el paciente que se va a atender.
        /// </summary>
        /// <param name="paciente"></param>
        public FrmConsulta(Paciente paciente) : this()
        {
            this.paciente = paciente;
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            this.dgvMedicos.DataSource = Clinica.Medicos;
            this.cmbEspecialidad.DataSource = Enum.GetValues(typeof(EEspecialidad));
        }

        /// <summary>
        /// Busca todos los médicos con la especialidad seleccionada en el comboBox.
        /// </summary>
        private void BuscarPorEspecialidad()
        {
            if (!string.IsNullOrWhiteSpace(this.cmbEspecialidad.Text))
            {
                dgvMedicos.DataSource = Clinica.Medicos.FindAll((x) => x.Especialidad == (EEspecialidad)cmbEspecialidad.SelectedItem);
            }
            else
            {
                MessageBox.Show("Debes seleccionar una especialidad", "Error al buscar por especialidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Busca todos los médicos con el nombre escrito en el textBox.
        /// </summary>
        /// <returns>true si existe el médico, un BuscarException si no existe el médico.</returns>
        private bool BuscarPorNombre()
        {
            if (!string.IsNullOrWhiteSpace(this.txtNombre.Text) && Validador.SoloLetras(this.txtNombre.Text))
            {
                string auxNombre = this.txtNombre.Text.ToLower().Trim();

                if (Clinica.Medicos.Exists((x) => x.Nombre.ToLower() == auxNombre))
                {
                    return true;
                }
                else
                {
                    throw new BuscarException("No existe un médico con ese nombre. Vuelva a intentarlo y chequea la lista de médicos.");
                }
            }

            return false;
        }

        /// <summary>
        /// Muestra en el dataGridView el médico que coincida con el nombre a buscar
        /// o muestra un mensaje de error si no existe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarPorNombre_Click(object sender, EventArgs e)
        {
            try
            {
                if (!BuscarPorNombre())
                {
                    MessageBox.Show("Debes escribir un nombre válido.", "Error al buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string auxNombre = this.txtNombre.Text.ToLower().Trim();
                    dgvMedicos.DataSource = null;
                    dgvMedicos.DataSource = Clinica.Medicos.FindAll((x) => x.Nombre.ToLower() == auxNombre);
                }
            }
            catch (BuscarException ex)
            {
                MessageBox.Show(ex.Message, "Error al buscar por nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Muestra en el dataGridView los médicos con la especialidad requerida.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarPorEspecialidad_Click(object sender, EventArgs e)
        {
            dgvMedicos.DataSource = null;
            BuscarPorEspecialidad();
        }

        /// <summary>
        /// Asigna la consulta la médico seleccionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsignarConsulta_Click(object sender, EventArgs e)
        {
            if (dgvMedicos.SelectedRows.Count == 1)
            {
                Medico medico = (Medico)dgvMedicos.CurrentRow.DataBoundItem;

                if (!(medico + paciente))
                {
                    MessageBox.Show($"El médico no está disponible. Se agrego el paciente a la lista de espera del médico {medico}.", 
                        "Paciente a la lista de espera", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show($"{paciente} esta siendo atendido/a", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                this.DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Muestra todos los médicos en el dataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            dgvMedicos.DataSource = null;
            dgvMedicos.DataSource = Clinica.Medicos;
        }

        /// <summary>
        /// Cierra el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
